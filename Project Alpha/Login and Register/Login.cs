using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Project_Alpha.Custom_Class;
using Project_Alpha.Database_Access;

namespace Project_Alpha
{
    public partial class Login : UserControl
    {
        AuthenticationCheck ac;
        public Login()
        {
            InitializeComponent();
            ac = new AuthenticationCheck();
        }

        private void label6_Click(object sender, EventArgs e)
        {
           if(!Form1.Instance.panel.Controls.ContainsKey("Register"))
            {
                Register register = new Register();
                register.Dock = DockStyle.Fill;
                Form1.Instance.panel.Controls.Add(register);
            }
            Form1.Instance.panel.Controls["Register"].BringToFront();
           
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            label6.ForeColor = Color.DarkGoldenrod;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Gold;
        }

        private void round1_TextChanged(object sender, EventArgs e)
        {
            //email of user
        }

        private void round2_TextChanged(object sender, EventArgs e)
        {
            //pass of user
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email, pass;
            email = round1.Text;
            pass = round2.Text;
            if (ac.checkUser(email, pass))
            {
                Form1.Instance.SetLabel(LoadUserData.userName);
                //Form1.Instance.SetLabel(LoadUserData.);

                if (ac.featureCheck())
                {
                    MessageBox.Show("Login as Customer Successful");
                    
                    Refresh();
                    if (!Form1.Instance.panel.Controls.ContainsKey("Vendors"))
                    {
                        Vendors vendors = new Vendors();
                        vendors.Dock = DockStyle.Fill;
                        Form1.Instance.panel.Controls.Add(vendors);
                    }
                    Form1.Instance.panel.Controls["Vendors"].BringToFront();
                }
                else
                {
                    MessageBox.Show("Login as Vendor Successful");
                    //Refresh();
                    if (!Form1.Instance.panel.Controls.ContainsKey("Vendors"))
                    {
                        Vendors vendors = new Vendors();
                        vendors.Dock = DockStyle.Fill;
                        Form1.Instance.panel.Controls.Add(vendors);
                    }
                    Form1.Instance.panel.Controls["Vendors"].BringToFront();

                }               
            }
            else MessageBox.Show("Could Not Login");
        }
    }
}
