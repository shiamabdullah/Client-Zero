using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using Project_Alpha.Custom_Class;

namespace Project_Alpha
{
    public partial class Register : UserControl
    {
        AuthenticationCheck au;
        public Register()
        {
            InitializeComponent();
            au = new AuthenticationCheck();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((round1.Text.Length == 0) || (round2.Text.Length == 0) || (round3.Text.Length == 0) || (round4.Text.Length == 0) || ((!radioButton1.Checked) && (!radioButton2.Checked)))
            {
                MessageBox.Show("Please Fill All The Informations");
            }
            else if (au.ifExists(round1.Text))
            {
                MessageBox.Show("Email Already Exists");
            }
            else if (!(round2.Text.Equals(round3.Text)))
            {
                MessageBox.Show("Password And Confirm Password Do Not Match");
            }
            else if (round1.Text.Contains(" "))
            {
                MessageBox.Show("Password Can Not Contain Space");
            }
            else
            {
                au.createNewUser(round1.Text, round2.Text, round4.Text, radioButton2.Checked);
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void round1_TextChanged(object sender, EventArgs e)
        {
            //email_address for user
        }

        private void round4_TextChanged(object sender, EventArgs e)
        {
            //username for user
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //if seller tick this
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //if buyer tick this
        }

        private void round2_TextChanged(object sender, EventArgs e)
        {
            //password for user
        }

        private void round3_TextChanged(object sender, EventArgs e)
        {
            //confirm password for user
        }
    }
}
