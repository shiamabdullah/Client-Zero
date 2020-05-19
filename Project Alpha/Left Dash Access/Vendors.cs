using Project_Alpha.Properties;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Alpha.Custom_Class;

namespace Project_Alpha
{
    public partial class Vendors : UserControl {

        GameInfo gameInfo;
        vendor_product_ls[] vendor_Product_Ls;
        protected static int n = 0;
        protected static int page = 1;
        protected int maxItem=10;
        protected int x = 0;
        protected int maxPage = 1;


        public Vendors()
        {
            gameInfo = new GameInfo();
            n = gameInfo.gameCount;
            vendor_Product_Ls = new vendor_product_ls[n];
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            InitializeComponent();

            if (n % maxItem == 0)
            {
                maxPage = n / maxItem;
            }
            else
            {
                maxPage = (n / maxItem) + 1;
            }

            if (n <= maxItem)
            {
                x = n;
                populateItems();
            }
            else if (page <= maxPage)
            {
                x = maxItem;
                populateItems();
            }
        }






        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {

        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void populateItems()
        {



            for (int i = 0; i < x; i++)
            {
                gameInfo.LoadInfo(((page - 1) * 10) + (i + 1));
                vendor_Product_Ls[i] = new vendor_product_ls();
                vendor_Product_Ls[i].setInfo(i, gameInfo.GameName, gameInfo.GamePrice, gameInfo.GamePlatform);
                vendor_Product_Ls[i].Visible = true;
                vendor_Product_Ls[i].gameName = gameInfo.GameName;
                vendor_Product_Ls[i].shopName = gameInfo.ShopName;
                vendor_Product_Ls[i].gamePic = gameInfo.GamePicture;
                vendor_Product_Ls[i].rating = gameInfo.GameRating;
                vendor_Product_Ls[i].currency = gameInfo.GamePrice;
                vendor_Product_Ls[i].platform = gameInfo.GamePlatform;



                if (flowLayoutPanel1.Controls.Count < 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                else
                {
                    this.flowLayoutPanel1.SuspendLayout();
                    flowLayoutPanel1.Controls.Add(vendor_Product_Ls[i]);
                    this.flowLayoutPanel1.ResumeLayout();
                    this.flowLayoutPanel1.PerformLayout();
                    this.flowLayoutPanel1.Refresh();
                }

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //nxt btn
            //while (flowLayoutPanel1.Controls.Count > 0) { flowLayoutPanel1.Controls.RemoveAt(0); }
            if (page + 1 <= maxPage)
            {
                page++;
                label1.Text = "" + page;
                while (flowLayoutPanel1.Controls.Count > 0) { flowLayoutPanel1.Controls.RemoveAt(0); }
                if (page == maxPage)
                {
                    if ((n - (maxItem * page)) <= maxItem)
                    {
                        x = (n - (maxItem * (page-1)));
                        populateItems();
                    }
                }
                else
                {
                    x= maxItem;
                    populateItems();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //pre btn
            if (page != 1)
            {
                page--;
                label1.Text = page + "";
                while (flowLayoutPanel1.Controls.Count > 0) { flowLayoutPanel1.Controls.RemoveAt(0); }
                x = maxItem;
                populateItems();
            }
        }
    }        
}

