using Project_Alpha.Properties;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Alpha.Database_Access;
using System.Text;
using System.IO;

namespace Project_Alpha.Custom_Class
{
    public class GameInfo
    {
        LoadGameData ld = new LoadGameData();
        public int gameCount = LoadGameData.gameCount;
        public void LoadInfo(int i)
        {
            this.GameName= ld.getGameName(i);
            this.GamePlatform= ld.getGamePlatform(i);
            this.GamePrice= ld.getGamePrice(i);
            this.GameRating = ld.getGameRating(i);
            MemoryStream ms = new MemoryStream(Convert.ToInt32(ld.getGamePicture(i)));
           
           

        }
        public String GameName { set; get; }
        public String GameRating { set; get; }
        public String GamePlatform { set; get; }
        public String GamePrice { set; get; }
        public System.Drawing.Bitmap GamePicture { set; get; }
        public String ShopName { set; get; } = "Xero Game Shop";
    }
}
