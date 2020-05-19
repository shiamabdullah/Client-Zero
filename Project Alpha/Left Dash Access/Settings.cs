using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Alpha.Database_Access;
using Project_Alpha.Custom_Class;

namespace Project_Alpha
{
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
            label2.Text = LoadUserData.userName;
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            AuthenticationCheck.logedin = false;
            if (!Form1.Instance.panel.Controls.ContainsKey("Login"))
            {
                Login login = new Login();
                login.Dock = DockStyle.Fill;
                Form1.Instance.panel.Controls.Add(login);
            }
            Form1.Instance.panel.Controls["Login"].BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
