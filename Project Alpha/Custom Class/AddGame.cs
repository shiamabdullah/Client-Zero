using Project_Alpha.Database_Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Alpha.Custom_Class
{
    class AddGame
    {
        LoadGameData gameData;
        UpdateGameData updateGameData;
        public AddGame()
        {
            gameData = new LoadGameData();
            updateGameData = new UpdateGameData();
        }
        public void addGame(string gameName,double gamePrice,int gameCount,string platform,string rating,byte[] gameImage) 
        {
            string userId = LoadUserData.userID;
            int gameID= gameData.ifExists(gameName);
            if (gameID != -1)
            {
                gameID = 3001 + gameID;
                updateGameData.addGameQuantity(gameCount,gameID);
            }
            else
            {
                gameID = 3001 + LoadGameData.gameCount;
                updateGameData.addNewGame(gameName, gameID, gamePrice, gameCount, platform,userId,rating,gameImage);
            }

        }
    }
}
