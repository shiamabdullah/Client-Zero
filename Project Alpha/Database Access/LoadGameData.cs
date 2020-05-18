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
    class LoadGameData
    {
        private string connectionString;
        private SqlConnection connection;
        private DataTable gameTable = new DataTable();
        public static int gameCount;
        public string gameName { set; get; }
        public string getGameName(int index) 
        {
            gameName = gameTable.Rows[index-1][1].ToString();
            return this.gameName;
        }
        public string getGamePrice(int index)
        {
            gameName = gameTable.Rows[index - 1][2].ToString();
            return this.gameName;
        }
        public string getGameRating(int index)
        {
            gameName = gameTable.Rows[index - 1][3].ToString();
            return this.gameName;
        }
        public string getGamePlatform(int index)
        {
            gameName = gameTable.Rows[index - 1][5].ToString();
            return this.gameName;
        }
        public LoadGameData()
        {
            connectionString = ConfigurationManager.ConnectionStrings["Project_Alpha.Properties.Settings.UserCardinalitiesConnectionString"].ConnectionString;
            string query = "select * from Games";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                adapter.Fill(gameTable);
                gameCount = gameTable.Rows.Count;
            }
        }
    }
}
