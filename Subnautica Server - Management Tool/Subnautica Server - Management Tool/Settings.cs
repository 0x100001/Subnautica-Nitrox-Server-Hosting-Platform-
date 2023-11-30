using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subnautica_Server___Management_Tool
{
    internal class Settings
    {
        //useragent aka it tells the site/server what web browser your using. (Id rather you NOT touch it if you dont know what your doing)
        public static string Useragent = "assange"; // make up a random useragent like 2XYpsKltVv for leak protection, and add it to your .htaccess

        //Version of current loader, increment this number here and in the version.txt file each time you wish to push out a update
        public static string Version = "1";

        //The link to where you store your version.txt on your site
        public static string Check_Version = "https://auth.101.wtf/subnautica_server/version";

        public static string Update_Url = "https://subnautica-servers.101.wtf";

        public static string Auth = "https://auth.101.wtf/subnautica_server/auth.php";

        public static string Game_Settings_Loader_URL = "https://auth.101.wtf/subnautica_server/game_settings_loader.php";

        public static string Game_Settings_Push_URL = "https://auth.101.wtf/subnautica_server/game_settings_push.php";

        public static string Register_User_URL = "https://auth.101.wtf/subnautica_server/register_user.php";

        public static string Absolutely_Not_Safe_Key= "475c43895c435c9m48957m7m3x6378x864x736x477x64893x63578v73c63c7";
    }
}
