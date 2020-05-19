using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Alpha.Custom_List_File
{
    public partial class cart_product_ls : UserControl
    {
        public cart_product_ls()
        {
            InitializeComponent();
        }


        #region Properties

        private String _gameName;
        private String _shopName;
        private String _rating;
        private String _currency;
        private String _platform;
        private Image _gamePic;



        [Category("Custom Props")]
        public String gameName
        {
            get { return _gameName; }
            set { _gameName = value; gameNamelbl.Text = value; }
        }


        [Category("Custom Props")]
        public String shopName
        {
            get { return _shopName; }
            set { _shopName = value; label2.Text = value; }
        }

        [Category("Custom Props")]
        public Image gamePic
        {
            get { return _gamePic; }
            set { _gamePic = value; pictureBox1.Image = value; }
        }

        [Category("Custom Props")]
        public String rating
        {
            get { return _rating; }
            set { _rating = value; label5.Text = value; }
        }

        [Category("Custom Props")]
        public String currency
        {
            get { return _currency; }
            set { _currency = value; label3.Text = value; }
        }

        [Category("Custom Props")]

        public String platform
        {
            get { return _platform; }
            set { _platform = value; label6.Text = value; }
        }



        #endregion


        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void gameNamelbl_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
