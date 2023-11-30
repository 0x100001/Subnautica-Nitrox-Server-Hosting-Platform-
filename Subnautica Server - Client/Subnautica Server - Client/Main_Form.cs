using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Security.Cryptography;
using System.Diagnostics;
using System.Management;

namespace Subnautica_Server___Client
{
    public partial class Main_Form : Form
    {
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

        private static void CloneDirectory(string root, string dest)
        {
            foreach (var directory in Directory.GetDirectories(root))
            {
                string dirName = Path.GetFileName(directory);
                if (!Directory.Exists(Path.Combine(dest, dirName)))
                {
                    Directory.CreateDirectory(Path.Combine(dest, dirName));
                }
                CloneDirectory(directory, Path.Combine(dest, dirName));
            }

            foreach (var file in Directory.GetFiles(root))
            {
                File.Copy(file, Path.Combine(dest, Path.GetFileName(file)));
            }
        }

        public Main_Form()
        {
            InitializeComponent();
        }


        //Sync every user
        private void sync_timer_Tick(object sender, EventArgs e)
        {
            string auth_pw = "5c68975m8965d78f7m895zhf5489f675467d5467gf87536f";

            string Sync_Settings = "0";

            //Request Server Connection Info
            string Server_Port = "";

            //Request Game Server Path
            string GameServerPath = "";
            string UserProcessPath = "";

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

            //Check for new users string
            string New_User = "";

            //Create Webclient
            WebClient web_request = new WebClient();

            /*Receive Sync Settings*/
            try
            {
                /*Check if Server is registered*/
                try
                {
                    web_request.Headers.Add("User-Agent", Settings.Useragent); // adds Useragent for leak protection
                    New_User = web_request.DownloadString(Settings.Register_Server_URL + "?auth_token=" + auth_pw + "&srr=1");
                    if (New_User != "")
                    {
                        if (Directory.Exists(@"C:\Users\Administrator\Desktop\Server_Files\" + New_User) == false)
                        {
                            Directory.CreateDirectory(@"C:\Users\Administrator\Desktop\Server_Files\" + New_User);

                            CloneDirectory(@"C:\Users\Administrator\Desktop\Server_Files\template", @"C:\Users\Administrator\Desktop\Server_Files\" + New_User);

                            File.AppendAllText(@"C:\Users\Administrator\Desktop\Subnautica Server Client\users.txt", New_User + Environment.NewLine);
                        }
                    }
                }
                catch (Exception ex)
                {
                    File.AppendAllText(Application.StartupPath + @"\logs\error.log", DateTime.Now + " - Create New Server for new User: " + ex.Message + Environment.NewLine);

                    Process.Start(Application.StartupPath + @"\logs\error.log");
                }

                //Remove and re-add users
                users_listbox.Items.Clear();

                //Load Users from Textfile
                foreach (var line in File.ReadAllLines(Application.StartupPath + @"\users.txt"))
                {
                    users_listbox.Items.Add(line);
                }

                //Sync every user
                foreach (var user in users_listbox.Items)
                {
                    web_request.Headers.Add("User-Agent", Settings.Useragent); // adds Useragent for leak protection
                    Sync_Settings = web_request.DownloadString(Settings.Game_Settings_Loader_URL + "?username=" + user.ToString() + "&auth_token=" + auth_pw + "&hwid=E71491B63D3625AA1309C32E60304FA2178BFBFF00870F10&sync=1");

                    if (Sync_Settings == "1")
                    {
                        /*Receive Game Server Path*/
                        try
                        {
                            web_request.Headers.Add("User-Agent", Settings.Useragent); // adds Useragent for leak protection
                            GameServerPath = web_request.DownloadString(Settings.Game_Settings_Loader_URL + "?username=" + user.ToString() + "&auth_token=" + auth_pw + "&hwid=E71491B63D3625AA1309C32E60304FA2178BFBFF00870F10&gsp=1");

                            if (File.Exists(GameServerPath + "\\path.txt"))
                                File.Delete(GameServerPath + "\\path.txt");

                            File.AppendAllText(GameServerPath + "\\path.txt", @"C:\Users\Administrator\Desktop\Game");
                        }
                        catch (Exception ex)
                        {
                            File.AppendAllText(Application.StartupPath + @"\logs\error.log", DateTime.Now + " - Request Game Server Path: " + ex.Message + Environment.NewLine);

                            Process.Start(Application.StartupPath + @"\logs\error.log");
                        }

                        //Delete old config
                        if (File.Exists(GameServerPath + "\\server.cfg"))
                            File.Delete(GameServerPath + "\\server.cfg");

                        //Start Filling Server Config
                        File.AppendAllText(GameServerPath + "\\server.cfg", "SaveInterval=120000" + Environment.NewLine);
                        File.AppendAllText(GameServerPath + "\\server.cfg", "MaxConnections=100" + Environment.NewLine);
                        File.AppendAllText(GameServerPath + "\\server.cfg", "DisableConsole=False" + Environment.NewLine);
                        File.AppendAllText(GameServerPath + "\\server.cfg", "DisableAutoSave=False" + Environment.NewLine);
                        File.AppendAllText(GameServerPath + "\\server.cfg", "SaveName=world" + Environment.NewLine);
                        File.AppendAllText(GameServerPath + "\\server.cfg", "SerializerMode=PROTOBUF" + Environment.NewLine);

                        /*Receive Game Server Port*/
                        try
                        {
                            web_request.Headers.Add("User-Agent", Settings.Useragent); // adds Useragent for leak protection
                            Server_Port = web_request.DownloadString(Settings.Game_Settings_Loader_URL + "?username=" + user.ToString() + "&auth_token=" + auth_pw + "&hwid=E71491B63D3625AA1309C32E60304FA2178BFBFF00870F10&sp=1");

                            File.AppendAllText(GameServerPath + "\\server.cfg", "ServerPort=" + Server_Port + Environment.NewLine);
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
                            ServerPassword = web_request.DownloadString(Settings.Game_Settings_Loader_URL + "?username=" + user.ToString() + "&auth_token=" + auth_pw + "&hwid=E71491B63D3625AA1309C32E60304FA2178BFBFF00870F10&spw=1");

                            //Convert from base64 to byte array
                            byte[] ServerPassword_decoded = Convert.FromBase64String(ServerPassword);

                            //Convert from byte array to utf8 string
                            string ServerPassword_recoded = Encoding.UTF8.GetString(ServerPassword_decoded);

                            //Decrypt and assign RDP Server to String
                            File.AppendAllText(GameServerPath + "\\server.cfg", "ServerPassword=" + StringCipher.Decrypt(ServerPassword_recoded, Settings.Encryption_Key) + Environment.NewLine);
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
                            AdminPassword = web_request.DownloadString(Settings.Game_Settings_Loader_URL + "?username=" + user.ToString() + "&auth_token=" + auth_pw + "&hwid=E71491B63D3625AA1309C32E60304FA2178BFBFF00870F10&apw=1");

                            //Convert from base64 to byte array
                            byte[] AdminPassword_decoded = Convert.FromBase64String(AdminPassword);

                            //Convert from byte array to utf8 string
                            string AdminPassword_recoded = Encoding.UTF8.GetString(AdminPassword_decoded);

                            //Decrypt and assign RDP Server to String
                            File.AppendAllText(GameServerPath + "\\server.cfg", "AdminPassword=" + StringCipher.Decrypt(AdminPassword_recoded, Settings.Encryption_Key) + Environment.NewLine);
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
                            GameMode = web_request.DownloadString(Settings.Game_Settings_Loader_URL + "?username=" + user.ToString() + "&auth_token=" + auth_pw + "&hwid=E71491B63D3625AA1309C32E60304FA2178BFBFF00870F10&gm=1");

                            //Decrypt and assign RDP Server to String
                            File.AppendAllText(GameServerPath + "\\server.cfg", "GameMode=" + GameMode + Environment.NewLine);
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
                            DefaultOxygenValue = web_request.DownloadString(Settings.Game_Settings_Loader_URL + "?username=" + user.ToString() + "&auth_token=" + auth_pw + "&hwid=E71491B63D3625AA1309C32E60304FA2178BFBFF00870F10&dov=1");

                            //Decrypt and assign RDP Server to String
                            File.AppendAllText(GameServerPath + "\\server.cfg", "DefaultOxygenValue=" + DefaultOxygenValue + Environment.NewLine);
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
                            DefaultMaxOxygenValue = web_request.DownloadString(Settings.Game_Settings_Loader_URL + "?username=" + user.ToString() + "&auth_token=" + auth_pw + "&hwid=E71491B63D3625AA1309C32E60304FA2178BFBFF00870F10&dmov=1");

                            //Decrypt and assign RDP Server to String
                            File.AppendAllText(GameServerPath + "\\server.cfg", "DefaultMaxOxygenValue=" + DefaultMaxOxygenValue + Environment.NewLine);
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
                            DefaultHealthValue = web_request.DownloadString(Settings.Game_Settings_Loader_URL + "?username=" + user.ToString() + "&auth_token=" + auth_pw + "&hwid=E71491B63D3625AA1309C32E60304FA2178BFBFF00870F10&dhv=1");

                            //Decrypt and assign RDP Server to String
                            File.AppendAllText(GameServerPath + "\\server.cfg", "DefaultHealthValue=" + DefaultHealthValue + Environment.NewLine);
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
                            DefaultHungerValue = web_request.DownloadString(Settings.Game_Settings_Loader_URL + "?username=" + user.ToString() + "&auth_token=" + auth_pw + "&hwid=E71491B63D3625AA1309C32E60304FA2178BFBFF00870F10&dhuv=1");

                            //Decrypt and assign RDP Server to String
                            File.AppendAllText(GameServerPath + "\\server.cfg", "DefaultHungerValue=" + DefaultHungerValue + Environment.NewLine);
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
                            DefaultThirstValue = web_request.DownloadString(Settings.Game_Settings_Loader_URL + "?username=" + user.ToString() + "&auth_token=" + auth_pw + "&hwid=E71491B63D3625AA1309C32E60304FA2178BFBFF00870F10&dtv=1");

                            //Decrypt and assign RDP Server to String
                            File.AppendAllText(GameServerPath + "\\server.cfg", "DefaultThirstValue=" + DefaultThirstValue + Environment.NewLine);
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
                            DefaultInfectionValue = web_request.DownloadString(Settings.Game_Settings_Loader_URL + "?username=" + user.ToString() + "&auth_token=" + auth_pw + "&hwid=E71491B63D3625AA1309C32E60304FA2178BFBFF00870F10&div=1");

                            //Decrypt and assign RDP Server to String
                            File.AppendAllText(GameServerPath + "\\server.cfg", "DefaultInfectionValue=" + DefaultInfectionValue + Environment.NewLine);
                        }
                        catch (Exception ex)
                        {
                            File.AppendAllText(Application.StartupPath + @"\logs\error.log", DateTime.Now + " - Request DefaultInfectionValue: " + ex.Message + Environment.NewLine);

                            Process.Start(Application.StartupPath + @"\logs\error.log");
                        }

                        /*Deactivate Sync Settings*/
                        try
                        {
                            web_request.Headers.Add("User-Agent", Settings.Useragent); // adds Useragent for leak protection
                            web_request.DownloadString(Settings.Game_Settings_Loader_URL + "?username=" + user.ToString() + "&auth_token=" + auth_pw + "&hwid=E71491B63D3625AA1309C32E60304FA2178BFBFF00870F10&sync=0");
                        }
                        catch (Exception ex)
                        {
                            File.AppendAllText(Application.StartupPath + @"\logs\error.log", DateTime.Now + " - Push Sync Settings: " + ex.Message + Environment.NewLine);

                            Process.Start(Application.StartupPath + @"\logs\error.log");
                        }

                        //Find the server process id and stop it
                        UserProcessPath = GameServerPath + "\\" + "NitroxServer-Subnautica.exe";

                        var wmiQueryString = "SELECT ProcessId, ExecutablePath, CommandLine FROM Win32_Process";
                        using (var searcher = new ManagementObjectSearcher(wmiQueryString))
                        using (var results = searcher.Get())
                        {
                            var query = from p in Process.GetProcesses()
                                        join mo in results.Cast<ManagementObject>()
                                        on p.Id equals (int)(uint)mo["ProcessId"]
                                        select new
                                        {
                                            Process = p,
                                            Path = (string)mo["ExecutablePath"],
                                            CommandLine = (string)mo["CommandLine"],
                                        };
                            foreach (var item in query)
                            {
                                if (item.Path == UserProcessPath)
                                {
                                    int process_id = item.Process.Id;

                                    var process = Process.GetProcessById(process_id);
                                    process.Kill();
                                }
                            }
                        }

                        //Start Server Proces
                        ProcessStartInfo info = new ProcessStartInfo(UserProcessPath);
                        info.WorkingDirectory = GameServerPath;
                        Process.Start(info);
                    }
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(Application.StartupPath + @"\logs\error.log", DateTime.Now + " - Sync Settings: " + ex.Message + Environment.NewLine);

                Process.Start(Application.StartupPath + @"\logs\error.log");
            }
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {

        }

        private void manual_sync_button_Click(object sender, EventArgs e)
        {
            string auth_pw = "5c68975m8965d78f7m895zhf5489f675467d5467gf87536f";

            string Sync_Settings = "0";

            //Request Server Connection Info
            string Server_Port = "";

            //Request Game Server Path
            string GameServerPath = "";
            string UserProcessPath = "";

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

            //Check for new users string
            string New_User = "";

            //Create Webclient
            WebClient web_request = new WebClient();

            /*Receive Sync Settings*/
            try
            {
                /*Check if Server is registered*/
                try
                {
                    web_request.Headers.Add("User-Agent", Settings.Useragent); // adds Useragent for leak protection
                    New_User = web_request.DownloadString(Settings.Register_Server_URL + "?auth_token=" + auth_pw + "&srr=1");
                    if (New_User != "")
                    {
                        if (Directory.Exists(@"C:\Users\Administrator\Desktop\Server_Files\" + New_User) == false)
                        {
                            Directory.CreateDirectory(@"C:\Users\Administrator\Desktop\Server_Files\" + New_User);

                            CloneDirectory(@"C:\Users\Administrator\Desktop\Server_Files\template", @"C:\Users\Administrator\Desktop\Server_Files\" + New_User);

                            File.AppendAllText(@"C:\Users\Administrator\Desktop\Subnautica Server Client\users.txt", New_User + Environment.NewLine);
                        }
                    }
                }
                catch (Exception ex)
                {
                    File.AppendAllText(Application.StartupPath + @"\logs\error.log", DateTime.Now + " - Create New Server for new User: " + ex.Message + Environment.NewLine);

                    Process.Start(Application.StartupPath + @"\logs\error.log");
                }

                //Remove and re-add users
                users_listbox.Items.Clear();

                //Load Users from Textfile
                foreach (var line in File.ReadAllLines(Application.StartupPath + @"\users.txt"))
                {
                    users_listbox.Items.Add(line);
                }

                //Sync every user
                foreach (var user in users_listbox.Items)
                {
                    web_request.Headers.Add("User-Agent", Settings.Useragent); // adds Useragent for leak protection
                    Sync_Settings = web_request.DownloadString(Settings.Game_Settings_Loader_URL + "?username=" + user.ToString() + "&auth_token=" + auth_pw + "&hwid=E71491B63D3625AA1309C32E60304FA2178BFBFF00870F10&sync=1");

                    /*Receive Game Server Path*/
                    try
                    {
                        web_request.Headers.Add("User-Agent", Settings.Useragent); // adds Useragent for leak protection
                        GameServerPath = web_request.DownloadString(Settings.Game_Settings_Loader_URL + "?username=" + user.ToString() + "&auth_token=" + auth_pw + "&hwid=E71491B63D3625AA1309C32E60304FA2178BFBFF00870F10&gsp=1");

                        if (File.Exists(GameServerPath + "\\path.txt"))
                            File.Delete(GameServerPath + "\\path.txt");

                        File.AppendAllText(GameServerPath + "\\path.txt", @"C:\Users\Administrator\Desktop\Game");
                    }
                    catch (Exception ex)
                    {
                        File.AppendAllText(Application.StartupPath + @"\logs\error.log", DateTime.Now + " - Request Game Server Path: " + ex.Message + Environment.NewLine);

                        Process.Start(Application.StartupPath + @"\logs\error.log");
                    }

                    //Delete old config
                    if (File.Exists(GameServerPath + "\\server.cfg"))
                        File.Delete(GameServerPath + "\\server.cfg");

                    //Start Filling Server Config
                    File.AppendAllText(GameServerPath + "\\server.cfg", "SaveInterval=120000" + Environment.NewLine);
                    File.AppendAllText(GameServerPath + "\\server.cfg", "MaxConnections=100" + Environment.NewLine);
                    File.AppendAllText(GameServerPath + "\\server.cfg", "DisableConsole=False" + Environment.NewLine);
                    File.AppendAllText(GameServerPath + "\\server.cfg", "DisableAutoSave=False" + Environment.NewLine);
                    File.AppendAllText(GameServerPath + "\\server.cfg", "SaveName=world" + Environment.NewLine);
                    File.AppendAllText(GameServerPath + "\\server.cfg", "SerializerMode=PROTOBUF" + Environment.NewLine);

                    /*Receive Game Server Port*/
                    try
                    {
                        web_request.Headers.Add("User-Agent", Settings.Useragent); // adds Useragent for leak protection
                        Server_Port = web_request.DownloadString(Settings.Game_Settings_Loader_URL + "?username=" + user.ToString() + "&auth_token=" + auth_pw + "&hwid=E71491B63D3625AA1309C32E60304FA2178BFBFF00870F10&sp=1");

                        File.AppendAllText(GameServerPath + "\\server.cfg", "ServerPort=" + Server_Port + Environment.NewLine);
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
                        ServerPassword = web_request.DownloadString(Settings.Game_Settings_Loader_URL + "?username=" + user.ToString() + "&auth_token=" + auth_pw + "&hwid=E71491B63D3625AA1309C32E60304FA2178BFBFF00870F10&spw=1");

                        //Convert from base64 to byte array
                        byte[] ServerPassword_decoded = Convert.FromBase64String(ServerPassword);

                        //Convert from byte array to utf8 string
                        string ServerPassword_recoded = Encoding.UTF8.GetString(ServerPassword_decoded);

                        //Decrypt and assign RDP Server to String
                        File.AppendAllText(GameServerPath + "\\server.cfg", "ServerPassword=" + StringCipher.Decrypt(ServerPassword_recoded, Settings.Encryption_Key) + Environment.NewLine);
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
                        AdminPassword = web_request.DownloadString(Settings.Game_Settings_Loader_URL + "?username=" + user.ToString() + "&auth_token=" + auth_pw + "&hwid=E71491B63D3625AA1309C32E60304FA2178BFBFF00870F10&apw=1");

                        //Convert from base64 to byte array
                        byte[] AdminPassword_decoded = Convert.FromBase64String(AdminPassword);

                        //Convert from byte array to utf8 string
                        string AdminPassword_recoded = Encoding.UTF8.GetString(AdminPassword_decoded);

                        //Decrypt and assign RDP Server to String
                        File.AppendAllText(GameServerPath + "\\server.cfg", "AdminPassword=" + StringCipher.Decrypt(AdminPassword_recoded, Settings.Encryption_Key) + Environment.NewLine);
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
                        GameMode = web_request.DownloadString(Settings.Game_Settings_Loader_URL + "?username=" + user.ToString() + "&auth_token=" + auth_pw + "&hwid=E71491B63D3625AA1309C32E60304FA2178BFBFF00870F10&gm=1");

                        //Decrypt and assign RDP Server to String
                        File.AppendAllText(GameServerPath + "\\server.cfg", "GameMode=" + GameMode + Environment.NewLine);
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
                        DefaultOxygenValue = web_request.DownloadString(Settings.Game_Settings_Loader_URL + "?username=" + user.ToString() + "&auth_token=" + auth_pw + "&hwid=E71491B63D3625AA1309C32E60304FA2178BFBFF00870F10&dov=1");

                        //Decrypt and assign RDP Server to String
                        File.AppendAllText(GameServerPath + "\\server.cfg", "DefaultOxygenValue=" + DefaultOxygenValue + Environment.NewLine);
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
                        DefaultMaxOxygenValue = web_request.DownloadString(Settings.Game_Settings_Loader_URL + "?username=" + user.ToString() + "&auth_token=" + auth_pw + "&hwid=E71491B63D3625AA1309C32E60304FA2178BFBFF00870F10&dmov=1");

                        //Decrypt and assign RDP Server to String
                        File.AppendAllText(GameServerPath + "\\server.cfg", "DefaultMaxOxygenValue=" + DefaultMaxOxygenValue + Environment.NewLine);
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
                        DefaultHealthValue = web_request.DownloadString(Settings.Game_Settings_Loader_URL + "?username=" + user.ToString() + "&auth_token=" + auth_pw + "&hwid=E71491B63D3625AA1309C32E60304FA2178BFBFF00870F10&dhv=1");

                        //Decrypt and assign RDP Server to String
                        File.AppendAllText(GameServerPath + "\\server.cfg", "DefaultHealthValue=" + DefaultHealthValue + Environment.NewLine);
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
                        DefaultHungerValue = web_request.DownloadString(Settings.Game_Settings_Loader_URL + "?username=" + user.ToString() + "&auth_token=" + auth_pw + "&hwid=E71491B63D3625AA1309C32E60304FA2178BFBFF00870F10&dhuv=1");

                        //Decrypt and assign RDP Server to String
                        File.AppendAllText(GameServerPath + "\\server.cfg", "DefaultHungerValue=" + DefaultHungerValue + Environment.NewLine);
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
                        DefaultThirstValue = web_request.DownloadString(Settings.Game_Settings_Loader_URL + "?username=" + user.ToString() + "&auth_token=" + auth_pw + "&hwid=E71491B63D3625AA1309C32E60304FA2178BFBFF00870F10&dtv=1");

                        //Decrypt and assign RDP Server to String
                        File.AppendAllText(GameServerPath + "\\server.cfg", "DefaultThirstValue=" + DefaultThirstValue + Environment.NewLine);
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
                        DefaultInfectionValue = web_request.DownloadString(Settings.Game_Settings_Loader_URL + "?username=" + user.ToString() + "&auth_token=" + auth_pw + "&hwid=E71491B63D3625AA1309C32E60304FA2178BFBFF00870F10&div=1");

                        //Decrypt and assign RDP Server to String
                        File.AppendAllText(GameServerPath + "\\server.cfg", "DefaultInfectionValue=" + DefaultInfectionValue + Environment.NewLine);
                    }
                    catch (Exception ex)
                    {
                        File.AppendAllText(Application.StartupPath + @"\logs\error.log", DateTime.Now + " - Request DefaultInfectionValue: " + ex.Message + Environment.NewLine);

                        Process.Start(Application.StartupPath + @"\logs\error.log");
                    }

                    /*Deactivate Sync Settings*/
                    try
                    {
                        web_request.Headers.Add("User-Agent", Settings.Useragent); // adds Useragent for leak protection
                        web_request.DownloadString(Settings.Game_Settings_Loader_URL + "?username=" + user.ToString() + "&auth_token=" + auth_pw + "&hwid=E71491B63D3625AA1309C32E60304FA2178BFBFF00870F10&sync=0");
                    }
                    catch (Exception ex)
                    {
                        File.AppendAllText(Application.StartupPath + @"\logs\error.log", DateTime.Now + " - Push Sync Settings: " + ex.Message + Environment.NewLine);

                        Process.Start(Application.StartupPath + @"\logs\error.log");
                    }

                    //Find the server process id and stop it
                    UserProcessPath = GameServerPath + "\\" + "NitroxServer-Subnautica.exe";

                    var wmiQueryString = "SELECT ProcessId, ExecutablePath, CommandLine FROM Win32_Process";
                    using (var searcher = new ManagementObjectSearcher(wmiQueryString))
                    using (var results = searcher.Get())
                    {
                        var query = from p in Process.GetProcesses()
                                    join mo in results.Cast<ManagementObject>()
                                    on p.Id equals (int)(uint)mo["ProcessId"]
                                    select new
                                    {
                                        Process = p,
                                        Path = (string)mo["ExecutablePath"],
                                        CommandLine = (string)mo["CommandLine"],
                                    };
                        foreach (var item in query)
                        {
                            if (item.Path == UserProcessPath)
                            {
                                int process_id = item.Process.Id;

                                var process = Process.GetProcessById(process_id);
                                process.Kill();
                            }
                        }
                    }

                    //Start Server Proces
                    ProcessStartInfo info = new ProcessStartInfo(UserProcessPath);
                    info.WorkingDirectory = GameServerPath;
                    Process.Start(info);
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(Application.StartupPath + @"\logs\error.log", DateTime.Now + " - Sync Settings: " + ex.Message + Environment.NewLine);

                Process.Start(Application.StartupPath + @"\logs\error.log");
            }
        }

        private void start_servers_button_Click(object sender, EventArgs e)
        {
            string auth_pw = "5c68975m8965d78f7m895zhf5489f675467d5467gf87536f";

            string Sync_Settings = "0";

            //Request Server Connection Info
            string Server_Port = "";

            //Request Game Server Path
            string GameServerPath = "";
            string UserProcessPath = "";

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

            //Check for new users string
            string New_User = "";

            //Create Webclient
            WebClient web_request = new WebClient();

            /*Receive Sync Settings*/
            try
            {
                /*Check if Server is registered*/
                try
                {
                    web_request.Headers.Add("User-Agent", Settings.Useragent); // adds Useragent for leak protection
                    New_User = web_request.DownloadString(Settings.Register_Server_URL + "?auth_token=" + auth_pw + "&srr=1");
                    if (New_User != "")
                    {
                        if (Directory.Exists(@"C:\Users\Administrator\Desktop\Server_Files\" + New_User) == false)
                        {
                            Directory.CreateDirectory(@"C:\Users\Administrator\Desktop\Server_Files\" + New_User);

                            CloneDirectory(@"C:\Users\Administrator\Desktop\Server_Files\template", @"C:\Users\Administrator\Desktop\Server_Files\" + New_User);

                            File.AppendAllText(@"C:\Users\Administrator\Desktop\Subnautica Server Client\users.txt", New_User + Environment.NewLine);
                        }
                    }
                }
                catch (Exception ex)
                {
                    File.AppendAllText(Application.StartupPath + @"\logs\error.log", DateTime.Now + " - Create New Server for new User: " + ex.Message + Environment.NewLine);

                    Process.Start(Application.StartupPath + @"\logs\error.log");
                }

                //Remove and re-add users
                users_listbox.Items.Clear();

                //Load Users from Textfile
                foreach (var line in File.ReadAllLines(Application.StartupPath + @"\users.txt"))
                {
                    users_listbox.Items.Add(line);
                }

                //Sync every user
                foreach (var user in users_listbox.Items)
                {
                    web_request.Headers.Add("User-Agent", Settings.Useragent); // adds Useragent for leak protection
                    Sync_Settings = web_request.DownloadString(Settings.Game_Settings_Loader_URL + "?username=" + user.ToString() + "&auth_token=" + auth_pw + "&hwid=E71491B63D3625AA1309C32E60304FA2178BFBFF00870F10&sync=1");

                    /*Receive Game Server Path*/
                    try
                    {
                        web_request.Headers.Add("User-Agent", Settings.Useragent); // adds Useragent for leak protection
                        GameServerPath = web_request.DownloadString(Settings.Game_Settings_Loader_URL + "?username=" + user.ToString() + "&auth_token=" + auth_pw + "&hwid=E71491B63D3625AA1309C32E60304FA2178BFBFF00870F10&gsp=1");

                        if (File.Exists(GameServerPath + "\\path.txt"))
                            File.Delete(GameServerPath + "\\path.txt");

                        File.AppendAllText(GameServerPath + "\\path.txt", @"C:\Users\Administrator\Desktop\Game");
                    }
                    catch (Exception ex)
                    {
                        File.AppendAllText(Application.StartupPath + @"\logs\error.log", DateTime.Now + " - Request Game Server Path: " + ex.Message + Environment.NewLine);

                        Process.Start(Application.StartupPath + @"\logs\error.log");
                    }

                    //Delete old config
                    if (File.Exists(GameServerPath + "\\server.cfg"))
                        File.Delete(GameServerPath + "\\server.cfg");

                    //Start Filling Server Config
                    File.AppendAllText(GameServerPath + "\\server.cfg", "SaveInterval=120000" + Environment.NewLine);
                    File.AppendAllText(GameServerPath + "\\server.cfg", "MaxConnections=100" + Environment.NewLine);
                    File.AppendAllText(GameServerPath + "\\server.cfg", "DisableConsole=False" + Environment.NewLine);
                    File.AppendAllText(GameServerPath + "\\server.cfg", "DisableAutoSave=False" + Environment.NewLine);
                    File.AppendAllText(GameServerPath + "\\server.cfg", "SaveName=world" + Environment.NewLine);
                    File.AppendAllText(GameServerPath + "\\server.cfg", "SerializerMode=PROTOBUF" + Environment.NewLine);

                    /*Receive Game Server Port*/
                    try
                    {
                        web_request.Headers.Add("User-Agent", Settings.Useragent); // adds Useragent for leak protection
                        Server_Port = web_request.DownloadString(Settings.Game_Settings_Loader_URL + "?username=" + user.ToString() + "&auth_token=" + auth_pw + "&hwid=E71491B63D3625AA1309C32E60304FA2178BFBFF00870F10&sp=1");

                        File.AppendAllText(GameServerPath + "\\server.cfg", "ServerPort=" + Server_Port + Environment.NewLine);
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
                        ServerPassword = web_request.DownloadString(Settings.Game_Settings_Loader_URL + "?username=" + user.ToString() + "&auth_token=" + auth_pw + "&hwid=E71491B63D3625AA1309C32E60304FA2178BFBFF00870F10&spw=1");

                        //Convert from base64 to byte array
                        byte[] ServerPassword_decoded = Convert.FromBase64String(ServerPassword);

                        //Convert from byte array to utf8 string
                        string ServerPassword_recoded = Encoding.UTF8.GetString(ServerPassword_decoded);

                        //Decrypt and assign RDP Server to String
                        File.AppendAllText(GameServerPath + "\\server.cfg", "ServerPassword=" + StringCipher.Decrypt(ServerPassword_recoded, Settings.Encryption_Key) + Environment.NewLine);
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
                        AdminPassword = web_request.DownloadString(Settings.Game_Settings_Loader_URL + "?username=" + user.ToString() + "&auth_token=" + auth_pw + "&hwid=E71491B63D3625AA1309C32E60304FA2178BFBFF00870F10&apw=1");

                        //Convert from base64 to byte array
                        byte[] AdminPassword_decoded = Convert.FromBase64String(AdminPassword);

                        //Convert from byte array to utf8 string
                        string AdminPassword_recoded = Encoding.UTF8.GetString(AdminPassword_decoded);

                        //Decrypt and assign RDP Server to String
                        File.AppendAllText(GameServerPath + "\\server.cfg", "AdminPassword=" + StringCipher.Decrypt(AdminPassword_recoded, Settings.Encryption_Key) + Environment.NewLine);
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
                        GameMode = web_request.DownloadString(Settings.Game_Settings_Loader_URL + "?username=" + user.ToString() + "&auth_token=" + auth_pw + "&hwid=E71491B63D3625AA1309C32E60304FA2178BFBFF00870F10&gm=1");

                        //Decrypt and assign RDP Server to String
                        File.AppendAllText(GameServerPath + "\\server.cfg", "GameMode=" + GameMode + Environment.NewLine);
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
                        DefaultOxygenValue = web_request.DownloadString(Settings.Game_Settings_Loader_URL + "?username=" + user.ToString() + "&auth_token=" + auth_pw + "&hwid=E71491B63D3625AA1309C32E60304FA2178BFBFF00870F10&dov=1");

                        //Decrypt and assign RDP Server to String
                        File.AppendAllText(GameServerPath + "\\server.cfg", "DefaultOxygenValue=" + DefaultOxygenValue + Environment.NewLine);
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
                        DefaultMaxOxygenValue = web_request.DownloadString(Settings.Game_Settings_Loader_URL + "?username=" + user.ToString() + "&auth_token=" + auth_pw + "&hwid=E71491B63D3625AA1309C32E60304FA2178BFBFF00870F10&dmov=1");

                        //Decrypt and assign RDP Server to String
                        File.AppendAllText(GameServerPath + "\\server.cfg", "DefaultMaxOxygenValue=" + DefaultMaxOxygenValue + Environment.NewLine);
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
                        DefaultHealthValue = web_request.DownloadString(Settings.Game_Settings_Loader_URL + "?username=" + user.ToString() + "&auth_token=" + auth_pw + "&hwid=E71491B63D3625AA1309C32E60304FA2178BFBFF00870F10&dhv=1");

                        //Decrypt and assign RDP Server to String
                        File.AppendAllText(GameServerPath + "\\server.cfg", "DefaultHealthValue=" + DefaultHealthValue + Environment.NewLine);
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
                        DefaultHungerValue = web_request.DownloadString(Settings.Game_Settings_Loader_URL + "?username=" + user.ToString() + "&auth_token=" + auth_pw + "&hwid=E71491B63D3625AA1309C32E60304FA2178BFBFF00870F10&dhuv=1");

                        //Decrypt and assign RDP Server to String
                        File.AppendAllText(GameServerPath + "\\server.cfg", "DefaultHungerValue=" + DefaultHungerValue + Environment.NewLine);
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
                        DefaultThirstValue = web_request.DownloadString(Settings.Game_Settings_Loader_URL + "?username=" + user.ToString() + "&auth_token=" + auth_pw + "&hwid=E71491B63D3625AA1309C32E60304FA2178BFBFF00870F10&dtv=1");

                        //Decrypt and assign RDP Server to String
                        File.AppendAllText(GameServerPath + "\\server.cfg", "DefaultThirstValue=" + DefaultThirstValue + Environment.NewLine);
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
                        DefaultInfectionValue = web_request.DownloadString(Settings.Game_Settings_Loader_URL + "?username=" + user.ToString() + "&auth_token=" + auth_pw + "&hwid=E71491B63D3625AA1309C32E60304FA2178BFBFF00870F10&div=1");

                        //Decrypt and assign RDP Server to String
                        File.AppendAllText(GameServerPath + "\\server.cfg", "DefaultInfectionValue=" + DefaultInfectionValue + Environment.NewLine);
                    }
                    catch (Exception ex)
                    {
                        File.AppendAllText(Application.StartupPath + @"\logs\error.log", DateTime.Now + " - Request DefaultInfectionValue: " + ex.Message + Environment.NewLine);

                        Process.Start(Application.StartupPath + @"\logs\error.log");
                    }

                    /*Deactivate Sync Settings*/
                    try
                    {
                        web_request.Headers.Add("User-Agent", Settings.Useragent); // adds Useragent for leak protection
                        web_request.DownloadString(Settings.Game_Settings_Loader_URL + "?username=" + user.ToString() + "&auth_token=" + auth_pw + "&hwid=E71491B63D3625AA1309C32E60304FA2178BFBFF00870F10&sync=0");
                    }
                    catch (Exception ex)
                    {
                        File.AppendAllText(Application.StartupPath + @"\logs\error.log", DateTime.Now + " - Push Sync Settings: " + ex.Message + Environment.NewLine);

                        Process.Start(Application.StartupPath + @"\logs\error.log");
                    }

                    //Find the server process id and stop it
                    UserProcessPath = GameServerPath + "\\" + "NitroxServer-Subnautica.exe";

                    var wmiQueryString = "SELECT ProcessId, ExecutablePath, CommandLine FROM Win32_Process";
                    using (var searcher = new ManagementObjectSearcher(wmiQueryString))
                    using (var results = searcher.Get())
                    {
                        var query = from p in Process.GetProcesses()
                                    join mo in results.Cast<ManagementObject>()
                                    on p.Id equals (int)(uint)mo["ProcessId"]
                                    select new
                                    {
                                        Process = p,
                                        Path = (string)mo["ExecutablePath"],
                                        CommandLine = (string)mo["CommandLine"],
                                    };
                        foreach (var item in query)
                        {
                            if (item.Path == UserProcessPath)
                            {
                                int process_id = item.Process.Id;

                                var process = Process.GetProcessById(process_id);
                                process.Kill();
                            }
                        }
                    }

                    //Start Server Proces
                    ProcessStartInfo info = new ProcessStartInfo(UserProcessPath);
                    info.WorkingDirectory = GameServerPath;
                    Process.Start(info);
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(Application.StartupPath + @"\logs\error.log", DateTime.Now + " - Sync Settings: " + ex.Message + Environment.NewLine);

                Process.Start(Application.StartupPath + @"\logs\error.log");
            }
        }

        private void register_server_button_Click(object sender, EventArgs e)
        {
            string auth_pw = "5c68975m8965d78f7m895zhf5489f675467d5467gf87536f";

            //Request Game Server Path
            string New_User = "";

            //Create Webclient
            WebClient web_request = new WebClient();

            /*Check if Server is registered*/
            try
            {
                web_request.Headers.Add("User-Agent", Settings.Useragent); // adds Useragent for leak protection
                New_User = web_request.DownloadString(Settings.Register_Server_URL + "?auth_token=" + auth_pw + "&srr=1");

                if (New_User != "")
                {
                    if (Directory.Exists(@"C:\Users\Administrator\Desktop\Server_Files\" + New_User) == false)
                    {
                        Directory.CreateDirectory(@"C:\Users\Administrator\Desktop\Server_Files\" + New_User);

                        foreach (var file in Directory.GetFiles(@"C:\Users\Administrator\Desktop\Server_Files\template"))
                        {
                            File.Copy(file, @"C:\Users\Administrator\Desktop\Server_Files\" + New_User);
                        }
                    }

                    File.AppendAllText(@"C:\Users\Administrator\Desktop\Subnautica Server Client\users.txt", New_User);
                }
            }
            catch (Exception ex)
            {
                File.AppendAllText(Application.StartupPath + @"\logs\error.log", DateTime.Now + " - Request Game Server Password: " + ex.Message + Environment.NewLine);

                Process.Start(Application.StartupPath + @"\logs\error.log");
            }
        }
    }
}
