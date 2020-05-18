using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Alpha.Database_Access;

namespace Project_Alpha.Custom_Class
{
    class AuthenticationCheck
    {
        public static bool logedin = false;
        public static bool feature = false;
        LoadUserData loadUser;
        public AuthenticationCheck()
        {
            loadUser = new LoadUserData();
        }
        public bool checkUser(string email,string pass)
        {
            loadUser = new LoadUserData();
            bool result=false;
            string passCheck = loadUser.getPassword(email);
            if (string.IsNullOrEmpty(passCheck))
            {
                MessageBox.Show("Email Does Not Exist");
            }
            else
            {
                passCheck = passCheck.Replace(" ", "");
                //MessageBox.Show(passCheck.Length.ToString());
                if (pass.Equals(passCheck))
                {
                    result = true;
                    logedin = true;
                }
                else
                {
                    result = false;
                }
            }
            return result;
        }
        public bool featureCheck()
        {
            feature = loadUser.getFeature();
            return loadUser.getFeature();
        }

        public bool ifExists(string email)
        {
            return loadUser.ifExists(email);
        }

        internal void createNewUser(string email, string pass, string name, bool ifBuyer)
        {
            loadUser.createNewUser(email,pass,name, ifBuyer);
        }
    }
}
