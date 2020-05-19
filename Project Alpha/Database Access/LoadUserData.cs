using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Alpha.Database_Access
{
    class LoadUserData
    {
        private string feature = null;
        private string connectionString;
        private SqlConnection connection;
        private DataTable userTable=new DataTable();
        public static string userEmail=" ";
        public static string userName = " ";
        public static string userID = " ";
        private static int totalUser = 0;
        public string getPassword(string email)
        {
            string password = null;
            for (int i = 0; i < userTable.Rows.Count; i++)
            {
                if (email.Equals(userTable.Rows[i][1].ToString()))
                {
                    userEmail = email;
                    userName= userTable.Rows[i][2].ToString();
                    userID = userTable.Rows[i][0].ToString();
                    feature = userTable.Rows[i][4].ToString();
                    password = userTable.Rows[i][3].ToString(); 
                }
            }
            return password;
        }

        public bool getFeature()
        {
            if (feature.Equals("True"))
            {
                return true;
            }
            return false;
        }

        public bool ifExists(string email)
        {
            totalUser = userTable.Rows.Count;
            for (int i = 0; i < userTable.Rows.Count; i++)
            {
                if (email.Equals(userTable.Rows[i][1].ToString()))
                {
                    return true;
                }
            }
            return false;
        }

        internal void createNewUser(string email, string pass, string name, bool ifBuyer)
        {
            string sql = "INSERT INTO Users (UserID, Email, UserName, Password,feature) VALUES(" + (1001 + totalUser).ToString() + ",'" + email + "','" + name + "','" + pass + "','" + ifBuyer.ToString() + "'); ";
            connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            //using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            command.ExecuteNonQuery();
            MessageBox.Show(command.CommandText);
            //adapter.Fill(userTable);
            command.Dispose();
            connection.Close();
            fillDataTable();

        }
        public LoadUserData()
        {
            fillDataTable();
        }
        public void fillDataTable()
        {
            connectionString = ConfigurationManager.ConnectionStrings["Project_Alpha.Properties.Settings.UserCardinalitiesConnectionString"].ConnectionString;
            string query = "select * from Users";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                adapter.Fill(userTable);
                totalUser = userTable.Rows.Count;
            }
        }
    }
}
