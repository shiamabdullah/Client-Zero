using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Alpha
{
    public partial class Notification_ls : UserControl
    {


        
        public Notification_ls()
        {

           

            InitializeComponent();
        }



        #region Properties


        private String _name;
        private String _message;
        private Image _propic;




        [Category("Custom Props")]
        public String name
        {
            get { return _name; }
            set { _name = value; label1.Text = value; }
        }


        [Category("Custom Props")]
        public String message
        {
            get { return _message; }
            set { _message = value; label2.Text = value; }
        }

        [Category("Custom Props")]
        public Image propic
        {
            get { return _propic; }
            set { _propic = value; ovalPictureBox1.Image = value; }
        }



        #endregion

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void ovalPictureBox1_Click(object sender, EventArgs e)
        {
           //profile picture of buyer
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // profile name of buyer
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //notification of buyer
        }
    }
}
