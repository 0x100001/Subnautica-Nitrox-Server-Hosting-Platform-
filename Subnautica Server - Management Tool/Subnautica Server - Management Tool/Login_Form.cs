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
using _x101.HWID_System;
using System.Threading;

namespace Subnautica_Server___Management_Tool
{
    public partial class Login_Form : Form
    {
        public String HWID;

        //User Information
        public string username;
        public string password;

        //Server Information
        public string host_name;
        public int port;

        //Database Information
        public string mysql_host;
        public string mysql_database;
        public string mysql_username;
        public string mysql_password;
        public string mysql_port;

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

        public void Alert(string msg, Helper.Form_Alert.enmType type)
        {
            Helper.Form_Alert frm = new Helper.Form_Alert();
            frm.showAlert(msg, type);
        }

        //######################################GUI END###############################################

        public Login_Form()
        {
            InitializeComponent();

            //Check Version
            WebClient webClient = new WebClient();
            webClient.Headers.Add("User-Agent", Settings.Useragent);
            string versioncheck = webClient.DownloadString(Settings.Check_Version);

            if (versioncheck != Settings.Version)
            {
                MessageBox.Show("Update found. Please download.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                Process.Start(Settings.Update_Url);

                
                Application.Exit();
            }
            
            HWID = HW_UID_ENGINE.HW_UID; //Init HWID Gen

            contact_label.Parent = background_picturebox;

            //Create Log Folder
            if (Directory.Exists(Application.StartupPath + @"\logs") == false)
                Directory.CreateDirectory(Application.StartupPath + @"\logs");
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            username_textbox.Focus();

            try
            {
                username_textbox.Text = StringCipher.Decrypt(Properties.Settings.Default.Username, Settings.Absolutely_Not_Safe_Key);
                password_textbox.Text = StringCipher.Decrypt(Properties.Settings.Default.Password, Settings.Absolutely_Not_Safe_Key);
            }
            catch
            {

            }
        }

        private void show_forms()
        {
            this.Hide();
            var show_form = new Main_Form();
            show_form.Closed += (s, args) => this.Close();
            show_form.Show();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            try
            {
                WebClient login_request = new WebClient(); // creats a new webclient called wb
                string loginstring; // declares a string called loginstring so we can assign a value later
                login_request.Headers.Add("User-Agent", Settings.Useragent); // adds Useragent for leak protection

                loginstring = login_request.DownloadString(Settings.Auth + "?username=" + username_textbox.Text + "&password=" + password_textbox.Text + "&hwid=" + HWID); // makes a webrequest using wb for authentication, other parameters are in Settings.cs
                if (loginstring.Contains("687c6546v968057nv58z6b85897vn589v6")) //if the password is correct
                {
                    try
                    {
                        Properties.Settings.Default.Username = StringCipher.Encrypt(username_textbox.Text, Settings.Absolutely_Not_Safe_Key);
                        Properties.Settings.Default.Password = StringCipher.Encrypt(password_textbox.Text, Settings.Absolutely_Not_Safe_Key);
                        Properties.Settings.Default.Save();
                    }
                    catch (Exception ex)
                    {
                        File.AppendAllText(Application.StartupPath + @"\logs\error.log", DateTime.Now + " - Save Username & Password: " + ex.Message + Environment.NewLine);

                        Process.Start(Application.StartupPath + @"\logs\error.log");
                    }

                    if (loginstring.Contains("648cm66v75v9677774cm7689vm8956b7m894v689548")) //if the hwid is correct
                    {
                        this.BeginInvoke(new MethodInvoker(show_forms));
                    }
                    else if (loginstring.Contains("5346578x43656v37cm8943v673465c5643tr74t")) // if the hwid is wrong
                    {
                        MessageBox.Show("Wrong HardwareID. Please contact the support.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (loginstring.Contains("4c675897m5v087m489v65857v5467v854mv68")) //if the hwid is blank
                    {
                        MessageBox.Show("HardwareID successfully registered. Please login again.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); //messagebox that says you are not vip
                    }
                }
                else // if the password is wrong
                {
                    MessageBox.Show("Username or password wrong.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error); //messagebox that says password is wrong
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unknown error. Please contact support.\nError: " + ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void register_server_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var show_form = new Helper.Terms_Of_Service_Form();
            show_form.Closed += (s, args) => this.Close();
            show_form.Show();
        }

        private void contact_label_Click(object sender, EventArgs e)
        {
            Process.Start("https://subnautica-servers.101.wtf");
        }
    }
}