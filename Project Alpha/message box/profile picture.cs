using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project_Alpha.message_box
{
    public partial class profile_picture : Form
    {
        public profile_picture()
        {
            InitializeComponent();
        }

        string imgLocation = "";

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = " png files(*.png) | *.png | jpg files(*.jpg) | *. jpg| All files(*.*) | *.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                ovalPictureBox1.ImageLocation = imgLocation;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] profileimages = null;
            

            FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            profileimages = brs.ReadBytes((int)stream.Length);

            MessageBox.Show("Upcoming Feature");
      

        }
    }
}
