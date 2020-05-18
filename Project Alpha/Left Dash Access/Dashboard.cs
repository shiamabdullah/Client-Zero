using System;
using System.Windows.Forms;

namespace Project_Alpha
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
            

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Padding = new Padding(0);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            //redirects you to vendors but category will be pc
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundedButton7_Click(object sender, EventArgs e)
        {

        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            //redirects you to vendors but category will be playstation
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            //redirects you to vendors but category will be xbox

        }

    }
}
