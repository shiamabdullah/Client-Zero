using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Alpha.Custom_Class;
using System.IO;

namespace Project_Alpha.Seller
{
    public partial class Seller_Home : UserControl
    {
        public Seller_Home()
        {
            InitializeComponent();
        }
        string imgLocation = "";

        private void Seller_Home_Load(object sender, EventArgs e)
        {

        }

        private void round1_TextChanged(object sender, EventArgs e)
        {
            //gamename set from buyer point of view
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           //check this if platform is pc
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //check this if platform is playstation
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //check this if platform is xbox
        }

        private void round2_TextChanged(object sender, EventArgs e)
        {
            //per game stock
        }

        private void round3_TextChanged(object sender, EventArgs e)
        {
            //per game price
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = " png files(*.png) | *.png | jpg files(*.jpg) | *. jpg| All files(*.*) | *.*";

            if (dialog.ShowDialog()== DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                ovalPictureBox1.ImageLocation = imgLocation;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //upload picture
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string gameName = round1.Text;
            int gameCount = Int16.Parse(round2.Text);
            double gamePrice= Double.Parse(round3.Text);
            string platform="";
            byte[] gameimages = null;
            
            
            FileStream stream = new FileStream(imgLocation , FileMode.Open , FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            gameimages = brs.ReadBytes((int)stream.Length);




            if (radioButton1.Checked) { platform = "PC"; }
            else if (radioButton2.Checked) { platform = "PS4"; }
            else if (radioButton3.Checked) { platform = "XBOX"; }
            else 
            {
                MessageBox.Show("Enter Game Platform");
            }
            string rating = round4.Text;
            AddGame addGame = new AddGame();
            addGame.addGame(gameName, gamePrice, gameCount, platform, rating,gameimages);
        }
    }
}
