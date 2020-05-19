using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Alpha.Database_Access
{
    class UpdateGameData
    {
        private static int qid = 10;
        private string connectionString;
        private SqlConnection connection;

        public UpdateGameData()
        {
            qid++;
            connectionString = ConfigurationManager.ConnectionStrings["Project_Alpha.Properties.Settings.UserCardinalitiesConnectionString"].ConnectionString;
        }
        internal void addGameQuantity(int gameCount, int gameID)
        {
            throw new NotImplementedException();
        }

        internal void addNewGame(string gameName, int gameID, double gamePrice, int gameCount, string platform, string userId,string rating,byte[] gameimg )
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            string sql = "INSERT INTO Games (GameID,GameName, Price,Rating,Picture,Platform) VALUES(" + gameID.ToString() + ",'" + gameName + "','" + gamePrice.ToString() + "','" + rating + "','"+ gameimg + "','" + platform + "'); ";
            SqlCommand command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();
            MessageBox.Show(command.CommandText);
            command.Dispose();
            connection.Close();


            connection = new SqlConnection(connectionString);
            connection.Open();
            sql = "INSERT INTO Quantity (UserID,GameID,Quantity) VALUES("+"'" + userId + "','" + gameID.ToString() + "','" + gameCount.ToString() + "'); ";
            SqlCommand command1 = new SqlCommand(sql, connection);
            command1.ExecuteNonQuery();
            MessageBox.Show(command1.CommandText);
            command1.Dispose();
            connection.Close();
        }
    }
}
