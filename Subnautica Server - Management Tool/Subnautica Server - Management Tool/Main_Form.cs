using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Net;
using Microsoft.Win32;
using System.Diagnostics;

namespace Subnautica_Server___Management_Tool
{
    public partial class Main_Form : Form
    {
        //Username, Password & HWID
        string username;
        string password;
        string hwid;

        public static class StringCipher
        {
            // This constant is used to determine the keysize of the encryption algorithm in bits.
            // We divide this by 8 within the code below to get the equivalent number of bytes.
            private const int Keysize = 256;

            // This constant determines the number of iterations for the password bytes generation function.
            private const int DerivationIterations = 1000;

            public static string Encrypt(string plainText, string passPhrase)
            {
                // Salt and IV is randomly generated each time, but is preprended to encrypted cipher text
                // so that the same Salt and IV values can be used when decrypting.  
                var saltStringBytes = Generate256BitsOfRandomEntropy();
                var ivStringBytes = Generate256BitsOfRandomEntropy();
                var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
                using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
                {
                    var keyBytes = password.GetBytes(Keysize / 8);
                    using (var symmetricKey = new RijndaelManaged())
                    {
                        symmetricKey.BlockSize = 256;
                        symmetricKey.Mode = CipherMode.CBC;
                        symmetricKey.Padding = PaddingMode.PKCS7;
                        using (var encryptor = symmetricKey.CreateEncryptor(keyBytes, ivStringBytes))
                        {
                            using (var memoryStream = new MemoryStream())
                            {
                                using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                                {
                                    cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                                    cryptoStream.FlushFinalBlock();
                                    // Create the final bytes as a concatenation of the random salt bytes, the random iv bytes and the cipher bytes.
                                    var cipherTextBytes = saltStringBytes;
                                    cipherTextBytes = cipherTextBytes.Concat(ivStringBytes).ToArray();
                                    cipherTextBytes = cipherTextBytes.Concat(memoryStream.ToArray()).ToArray();
                                    memoryStream.Close();
                                    cryptoStream.Close();
                                    return Convert.ToBase64String(cipherTextBytes);
                                }
                            }
                        }
                    }
                }
            }

            public static string Decrypt(string cipherText, string passPhrase)
            {
                // Get the complete stream of bytes that represent:
                // [32 bytes of Salt] + [32 bytes of IV] + [n bytes of CipherText]
                var cipherTextBytesWithSaltAndIv = Convert.FromBase64String(cipherText);
                // Get the saltbytes by extracting the first 32 bytes from the supplied cipherText bytes.
                var saltStringBytes = cipherTextBytesWithSaltAndIv.Take(Keysize / 8).ToArray();
                // Get the IV bytes by extracting the next 32 bytes from the supplied cipherText bytes.
                var ivStringBytes = cipherTextBytesWithSaltAndIv.Skip(Keysize / 8).Take(Keysize / 8).ToArray();
                // Get the actual cipher text bytes by removing the first 64 bytes from the cipherText string.
                var cipherTextBytes = cipherTextBytesWithSaltAndIv.Skip((Keysize / 8) * 2).Take(cipherTextBytesWithSaltAndIv.Length - ((Keysize / 8) * 2)).ToArray();

                using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
                {
                    var keyBytes = password.GetBytes(Keysize / 8);
                    using (var symmetricKey = new RijndaelManaged())
                    {
                        symmetricKey.BlockSize = 256;
                        symmetricKey.Mode = CipherMode.CBC;
                        symmetricKey.Padding = PaddingMode.PKCS7;
                        using (var decryptor = symmetricKey.CreateDecryptor(keyBytes, ivStringBytes))
                        {
                            using (var memoryStream = new MemoryStream(cipherTextBytes))
                            {
                                using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                                {
                                    var plainTextBytes = new byte[cipherTextBytes.Length];
                                    var decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                                    memoryStream.Close();
                                    cryptoStream.Close();
                                    return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
                                }
                            }
                        }
                    }
                }
            }

            private static byte[] Generate256BitsOfRandomEntropy()
            {
                var randomBytes = new byte[32]; // 32 Bytes will give us 256 bits.
                using (var rngCsp = new RNGCryptoServiceProvider())
                {
                    // Fill the array with cryptographically secure random bytes.
                    rngCsp.GetBytes(randomBytes);
                }
                return randomBytes;
            }
        }

        //######################################GUI START###############################################

        //GUI Handling
        Point move_window_last_point;

        //Move From if left mouse button clicked on it.
        private void form_header_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - move_window_last_point.X;
                this.Top += e.Y - move_window_last_point.Y;
            }
        }

        //Move Form if header is selected
        private void form_header_MouseDown(object sender, MouseEventArgs e)
        {
            move_window_last_point = new Point(e.X, e.Y);
        }

        private void header_title_label_MouseDown(object sender, MouseEventArgs e)
        {
            move_window_last_point = new Point(e.X, e.Y);
        }

        private void header_title_label_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - move_window_last_point.X;
                this.Top += e.Y - move_window_last_point.Y;
            }
        }

        private void background_picturebox_MouseDown(object sender, MouseEventArgs e)
        {
            move_window_last_point = new Point(e.X, e.Y);
        }

        private void background_picturebox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - move_window_last_point.X;
                this.Top += e.Y - move_window_last_point.Y;
            }
        }

        private void gui_misc_loader()
        {

        }

        public void Alert(string msg, Helper.Form_Alert.enmType type)
        {
            Helper.Form_Alert frm = new Helper.Form_Alert();
            frm.showAlert(msg, type);
        }

        //######################################GUI END###############################################
        public Main_Form()
        {
            InitializeComponent();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            //Assign Username, Password and HWID
            var Main_Form_Init = Application.OpenForms.OfType<Login_Form>().FirstOrDefault();

            username = Main_Form_Init.username_textbox.Text;
            password = Main_Form_Init.password_textbox.Text;
            hwid = Main_Form_Init.HWID;

            load_game_settings();
        }

        //Get Client Information
        private void load_game_settings()
        {
            //Request Server Connection Info
            string Server_Hostname;
            string Server_Port;

            //Request Server Settings
            string ServerPassword;
            string AdminPassword;

            //Request Game Settings
            string GameMode;
            string DefaultOxygenValue;
            string DefaultMaxOxygenValue;
            string DefaultHealthValue;
            string DefaultHungerValue;
            string DefaultThirstValue;
            string DefaultInfectionValue;

            //Create Webclient
            WebClient web_request = new WebClient();

            /*Receive Game Server Hostname*/
            try
            {
                web_request.Headers.Add("User-Agent", Settings.Useragent); // adds Useragent for leak protection
                Server_Hostname = web_request.DownloadString(Settings.Game_Settings_Loader_URL + "?username=" + username + "&password=" + password + "&hwid=" + hwid + "&sh=1");

                //Convert from base64 to byte array
                byte[] Server_Hostname_decoded = Convert.FromBase64String(Server_Hostname);

                //Convert from byte array to utf8 string
                string Server_Hostname_recoded = Encoding.UTF8.GetString(Server_Hostname_decoded);

                //Decrypt and assign RDP Server to String
                overview_hostname_textbox.Text = StringCipher.Decrypt(Server_Hostname_recoded, Settings.Absolutely_Not_Safe_Key);
            }
            catch (Exception ex)
            {
                File.AppendAllText(Application.StartupPath + @"\logs\error.log", DateTime.Now + " - Request Server Hostname: " + ex.Message + Environment.NewLine);

                Process.Start(Application.StartupPath + @"\logs\error.log");
            }

            /*Receive Game Server Port*/
            try
            {
                web_request.Headers.Add("User-Agent", Settings.Useragent); // adds Useragent for leak protection
                Server_Port = web_request.DownloadString(Settings.Game_Settings_Loader_URL + "?username=" + username + "&password=" + password + "&hwid=" + hwid + "&sp=1");

                overview_port_textbox.Text = Server_Port;
            }
            catch (Exception ex)
            {
                File.AppendAllText(Application.StartupPath + @"\logs\error.log", DateTime.Now + " - Request Server Port: " + ex.Message + Environment.NewLine);

                Process.Start(Application.StartupPath + @"\logs\error.log");
            }

            /*Receive Game Server Password*/
            try
            {
                web_request.Headers.Add("User-Agent", Settings.Useragent); // adds Useragent for leak protection
                ServerPassword = web_request.DownloadString(Settings.Game_Settings_Loader_URL + "?username=" + username + "&password=" + password + "&hwid=" + hwid + "&spw=1");

                //Convert from base64 to byte array
                byte[] ServerPassword_decoded = Convert.FromBase64String(ServerPassword);

                //Convert from byte array to utf8 string
                string ServerPassword_recoded = Encoding.UTF8.GetString(ServerPassword_decoded);

                //Decrypt and assign RDP Server to String
                server_settings_server_password_textbox.Text = StringCipher.Decrypt(ServerPassword_recoded, Settings.Absolutely_Not_Safe_Key);
            }
            catch (Exception ex)
            {
                File.AppendAllText(Application.StartupPath + @"\logs\error.log", DateTime.Now + " - Request Game Server Password: " + ex.Message + Environment.NewLine);

                Process.Start(Application.StartupPath + @"\logs\error.log");
            }

            /*Receive Game Admin Password*/
            try
            {
                web_request.Headers.Add("User-Agent", Settings.Useragent); // adds Useragent for leak protection
                AdminPassword = web_request.DownloadString(Settings.Game_Settings_Loader_URL + "?username=" + username + "&password=" + password + "&hwid=" + hwid + "&apw=1");

                //Convert from base64 to byte array
                byte[] AdminPassword_decoded = Convert.FromBase64String(AdminPassword);

                //Convert from byte array to utf8 string
                string AdminPassword_recoded = Encoding.UTF8.GetString(AdminPassword_decoded);

                //Decrypt and assign RDP Server to String
                server_settings_admin_password_textbox.Text = StringCipher.Decrypt(AdminPassword_recoded, Settings.Absolutely_Not_Safe_Key);
            }
            catch (Exception ex)
            {
                File.AppendAllText(Application.StartupPath + @"\logs\error.log", DateTime.Now + " - Request Admin Server Password: " + ex.Message + Environment.NewLine);

                Process.Start(Application.StartupPath + @"\logs\error.log");
            }

            /*Receive Game Mode Info*/
            try
            {
                web_request.Headers.Add("User-Agent", Settings.Useragent); // adds Useragent for leak protection
                GameMode = web_request.DownloadString(Settings.Game_Settings_Loader_URL + "?username=" + username + "&password=" + password + "&hwid=" + hwid + "&gm=1");

                //Decrypt and assign RDP Server to String
                game_settings_gamemode_combobox.SelectedIndex = game_settings_gamemode_combobox.FindStringExact(GameMode);
            }
            catch (Exception ex)
            {
                File.AppendAllText(Application.StartupPath + @"\logs\error.log", DateTime.Now + " - Request GameMode: " + ex.Message + Environment.NewLine);

                Process.Start(Application.StartupPath + @"\logs\error.log");
            }

            /*Receive DefaultOxygenValue Info*/
            try
            {
                web_request.Headers.Add("User-Agent", Settings.Useragent); // adds Useragent for leak protection
                DefaultOxygenValue = web_request.DownloadString(Settings.Game_Settings_Loader_URL + "?username=" + username + "&password=" + password + "&hwid=" + hwid + "&dov=1");

                //Decrypt and assign RDP Server to String
                game_settings_default_oxygen_value_textbox.Text = DefaultOxygenValue;
            }
            catch (Exception ex)
            {
                File.AppendAllText(Application.StartupPath + @"\logs\error.log", DateTime.Now + " - Request DefaultOxygenValue: " + ex.Message + Environment.NewLine);

                Process.Start(Application.StartupPath + @"\logs\error.log");
            }

            /*Receive DefaultMaxOxygenValue Info*/
            try
            {
                web_request.Headers.Add("User-Agent", Settings.Useragent); // adds Useragent for leak protection
                DefaultMaxOxygenValue = web_request.DownloadString(Settings.Game_Settings_Loader_URL + "?username=" + username + "&password=" + password + "&hwid=" + hwid + "&dmov=1");

                //Decrypt and assign RDP Server to String
                game_settings_default_max_oxygen_value_textbox.Text = DefaultMaxOxygenValue;
            }
            catch (Exception ex)
            {
                File.AppendAllText(Application.StartupPath + @"\logs\error.log", DateTime.Now + " - Request DefaultMaxOxygenValue: " + ex.Message + Environment.NewLine);

                Process.Start(Application.StartupPath + @"\logs\error.log");
            }

            /*Receive DefaultHealthValue Info*/
            try
            {
                web_request.Headers.Add("User-Agent", Settings.Useragent); // adds Useragent for leak protection
                DefaultHealthValue = web_request.DownloadString(Settings.Game_Settings_Loader_URL + "?username=" + username + "&password=" + password + "&hwid=" + hwid + "&dhv=1");

                //Decrypt and assign RDP Server to String
                game_settings_default_health_value_textbox.Text = DefaultHealthValue;
            }
            catch (Exception ex)
            {
                File.AppendAllText(Application.StartupPath + @"\logs\error.log", DateTime.Now + " - Request DefaultHealthValue: " + ex.Message + Environment.NewLine);

                Process.Start(Application.StartupPath + @"\logs\error.log");
            }

            /*Receive DefaultHungerValue Info*/
            try
            {
                web_request.Headers.Add("User-Agent", Settings.Useragent); // adds Useragent for leak protection
                DefaultHungerValue = web_request.DownloadString(Settings.Game_Settings_Loader_URL + "?username=" + username + "&password=" + password + "&hwid=" + hwid + "&dhuv=1");

                //Decrypt and assign RDP Server to String
                game_settings_default_hunger_value_textbox.Text = DefaultHungerValue;
            }
            catch (Exception ex)
            {
                File.AppendAllText(Application.StartupPath + @"\logs\error.log", DateTime.Now + " - Request DefaultHungerValue: " + ex.Message + Environment.NewLine);

                Process.Start(Application.StartupPath + @"\logs\error.log");
            }

            /*Receive DefaultThirstValue Info*/
            try
            {
                web_request.Headers.Add("User-Agent", Settings.Useragent); // adds Useragent for leak protection
                DefaultThirstValue = web_request.DownloadString(Settings.Game_Settings_Loader_URL + "?username=" + username + "&password=" + password + "&hwid=" + hwid + "&dtv=1");

                //Decrypt and assign RDP Server to String
                game_settings_default_thirst_value_textbox.Text = DefaultThirstValue;
            }
            catch (Exception ex)
            {
                File.AppendAllText(Application.StartupPath + @"\logs\error.log", DateTime.Now + " - Request DefaultThirstValue: " + ex.Message + Environment.NewLine);

                Process.Start(Application.StartupPath + @"\logs\error.log");
            }

            /*Receive DefaultInfectionValue Info*/
            try
            {
                web_request.Headers.Add("User-Agent", Settings.Useragent); // adds Useragent for leak protection
                DefaultInfectionValue = web_request.DownloadString(Settings.Game_Settings_Loader_URL + "?username=" + username + "&password=" + password + "&hwid=" + hwid + "&div=1");

                //Decrypt and assign RDP Server to String
                game_settings_default_infection_value_textbox.Text = DefaultInfectionValue;
            }
            catch (Exception ex)
            {
                File.AppendAllText(Application.StartupPath + @"\logs\error.log", DateTime.Now + " - Request DefaultInfectionValue: " + ex.Message + Environment.NewLine);

                Process.Start(Application.StartupPath + @"\logs\error.log");
            }

            this.Alert("Server Settings loaded.", Helper.Form_Alert.enmType.Success);
        }

        //Save Settings
        private void settings_save_button_Click(object sender, EventArgs e)
        {
            //Create Webclient
            WebClient web_request = new WebClient();

            /*Push ServerPassword*/
            try
            {
                //Encrypt and Encode
                string encrypted_string = StringCipher.Encrypt(server_settings_server_password_textbox.Text, Settings.Absolutely_Not_Safe_Key);
                byte[] clear_string = Encoding.UTF8.GetBytes(encrypted_string);
                string encoded_string = Convert.ToBase64String(clear_string);

                web_request.Headers.Add("User-Agent", Settings.Useragent); // adds Useragent for leak protection
                web_request.DownloadString(Settings.Game_Settings_Push_URL + "?username=" + username + "&password=" + password + "&hwid=" + hwid + "&spw=" + encoded_string);
            }
            catch (Exception ex)
            {
                File.AppendAllText(Application.StartupPath + @"\logs\error.log", DateTime.Now + " - Push ServerPassword: " + ex.Message + Environment.NewLine);

                Process.Start(Application.StartupPath + @"\logs\error.log");
            }

            /*Push AdminPassword*/
            try
            {
                //Encrypt and Encode
                string encrypted_string = StringCipher.Encrypt(server_settings_admin_password_textbox.Text, Settings.Absolutely_Not_Safe_Key);
                byte[] clear_string = Encoding.UTF8.GetBytes(encrypted_string);
                string encoded_string = Convert.ToBase64String(clear_string);

                web_request.Headers.Add("User-Agent", Settings.Useragent); // adds Useragent for leak protection
                web_request.DownloadString(Settings.Game_Settings_Push_URL + "?username=" + username + "&password=" + password + "&hwid=" + hwid + "&apw=" + encoded_string);
            }
            catch (Exception ex)
            {
                File.AppendAllText(Application.StartupPath + @"\logs\error.log", DateTime.Now + " - Push AdminPassword: " + ex.Message + Environment.NewLine);

                Process.Start(Application.StartupPath + @"\logs\error.log");
            }

            /*Push GameMode*/
            try
            {
                web_request.Headers.Add("User-Agent", Settings.Useragent); // adds Useragent for leak protection
                web_request.DownloadString(Settings.Game_Settings_Push_URL + "?username=" + username + "&password=" + password + "&hwid=" + hwid + "&gm=" + game_settings_gamemode_combobox.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                File.AppendAllText(Application.StartupPath + @"\logs\error.log", DateTime.Now + " - Push GameMode: " + ex.Message + Environment.NewLine);

                Process.Start(Application.StartupPath + @"\logs\error.log");
            }

            /*Push DefaultOxygenValue*/
            try
            {
                web_request.Headers.Add("User-Agent", Settings.Useragent); // adds Useragent for leak protection
                web_request.DownloadString(Settings.Game_Settings_Push_URL + "?username=" + username + "&password=" + password + "&hwid=" + hwid + "&dov=" + game_settings_default_oxygen_value_textbox.Text);
            }
            catch (Exception ex)
            {
                File.AppendAllText(Application.StartupPath + @"\logs\error.log", DateTime.Now + " - Push DefaultOxygenValue: " + ex.Message + Environment.NewLine);

                Process.Start(Application.StartupPath + @"\logs\error.log");
            }

            /*Push DefaultMaxOxygenValue*/
            try
            {
                web_request.Headers.Add("User-Agent", Settings.Useragent); // adds Useragent for leak protection
                web_request.DownloadString(Settings.Game_Settings_Push_URL + "?username=" + username + "&password=" + password + "&hwid=" + hwid + "&dmov=" + game_settings_default_max_oxygen_value_textbox.Text);
            }
            catch (Exception ex)
            {
                File.AppendAllText(Application.StartupPath + @"\logs\error.log", DateTime.Now + " - Push DefaultMaxOxygenValue: " + ex.Message + Environment.NewLine);

                Process.Start(Application.StartupPath + @"\logs\error.log");
            }

            /*Push DefaultHealthValue*/
            try
            {
                web_request.Headers.Add("User-Agent", Settings.Useragent); // adds Useragent for leak protection
                web_request.DownloadString(Settings.Game_Settings_Push_URL + "?username=" + username + "&password=" + password + "&hwid=" + hwid + "&dhv=" + game_settings_default_health_value_textbox.Text);
            }
            catch (Exception ex)
            {
                File.AppendAllText(Application.StartupPath + @"\logs\error.log", DateTime.Now + " - Push DefaultHealthValue: " + ex.Message + Environment.NewLine);

                Process.Start(Application.StartupPath + @"\logs\error.log");
            }

            /*Push DefaultHungerValue*/
            try
            {
                web_request.Headers.Add("User-Agent", Settings.Useragent); // adds Useragent for leak protection
                web_request.DownloadString(Settings.Game_Settings_Push_URL + "?username=" + username + "&password=" + password + "&hwid=" + hwid + "&dhuv=" + game_settings_default_hunger_value_textbox.Text);
            }
            catch (Exception ex)
            {
                File.AppendAllText(Application.StartupPath + @"\logs\error.log", DateTime.Now + " - Push DefaultHungerValue: " + ex.Message + Environment.NewLine);

                Process.Start(Application.StartupPath + @"\logs\error.log");
            }

            /*Push DefaultThirstValue*/
            try
            {
                web_request.Headers.Add("User-Agent", Settings.Useragent); // adds Useragent for leak protection
                web_request.DownloadString(Settings.Game_Settings_Push_URL + "?username=" + username + "&password=" + password + "&hwid=" + hwid + "&dtv=" + game_settings_default_thirst_value_textbox.Text);
            }
            catch (Exception ex)
            {
                File.AppendAllText(Application.StartupPath + @"\logs\error.log", DateTime.Now + " - Push DefaultThirstValue: " + ex.Message + Environment.NewLine);

                Process.Start(Application.StartupPath + @"\logs\error.log");
            }

            /*Push DefaultInfectionValue*/
            try
            {
                web_request.Headers.Add("User-Agent", Settings.Useragent); // adds Useragent for leak protection
                web_request.DownloadString(Settings.Game_Settings_Push_URL + "?username=" + username + "&password=" + password + "&hwid=" + hwid + "&div=" + game_settings_default_infection_value_textbox.Text);
            }
            catch (Exception ex)
            {
                File.AppendAllText(Application.StartupPath + @"\logs\error.log", DateTime.Now + " - Push DefaultInfectionValue: " + ex.Message + Environment.NewLine);

                Process.Start(Application.StartupPath + @"\logs\error.log");
            }

            /*Push Sync Settings*/
            try
            {
                web_request.Headers.Add("User-Agent", Settings.Useragent); // adds Useragent for leak protection
                web_request.DownloadString(Settings.Game_Settings_Push_URL + "?username=" + username + "&password=" + password + "&hwid=" + hwid + "&sync=1");
            }
            catch (Exception ex)
            {
                File.AppendAllText(Application.StartupPath + @"\logs\error.log", DateTime.Now + " - Push Sync Settings: " + ex.Message + Environment.NewLine);

                Process.Start(Application.StartupPath + @"\logs\error.log");
            }

            MessageBox.Show("Server Settings successfully saved. Please allow up to two minutes for the changes to take effect.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Refresh Settings
        private void refresh_settings_toolstrip_button_Click(object sender, EventArgs e)
        {
            load_game_settings();
        }

        //Reset Settings to Default
        private void game_settings_reset_default_button_Click(object sender, EventArgs e)
        {
            game_settings_gamemode_combobox.SelectedItem = "SURVIVAL";
            game_settings_default_oxygen_value_textbox.Text = "45";
            game_settings_default_max_oxygen_value_textbox.Text = "45";
            game_settings_default_health_value_textbox.Text = "80";
            game_settings_default_hunger_value_textbox.Text = "50.5";
            game_settings_default_thirst_value_textbox.Text = "90.5";
            game_settings_default_infection_value_textbox.Text = "0.1";
        }
    }
}
