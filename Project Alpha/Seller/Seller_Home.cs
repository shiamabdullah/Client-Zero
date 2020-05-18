using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Alpha.Seller
{
    public partial class Seller_Home : UserControl
    {
        public Seller_Home()
        {
            InitializeComponent();
        }

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
            //browse for picture 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //upload picture
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //post game
        }
    }
}
