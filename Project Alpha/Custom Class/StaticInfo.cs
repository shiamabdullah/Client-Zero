using Project_Alpha.Database_Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Alpha.Custom_Class
{
    public class StaticInfo
    {
        private static int gameCount;

        public static void setGameCount(int count)
        {
            gameCount = count;
        }
        public static int GameCount() 
        {
            return gameCount;
        }
        public static string getUserName()
        {
            return LoadUserData.userName;
        }
    }
}
