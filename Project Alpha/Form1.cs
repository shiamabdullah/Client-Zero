using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Project_Alpha.Custom_Class;
using Project_Alpha.Seller;
using Project_Alpha.Header;

namespace Project_Alpha
{
    public partial class Form1 : Form 
    {

        static Form1 _obj1;
    

        public static Form1 Instance
        {
            get
            {
                if(_obj1 == null)
                {
                    _obj1 = new Form1();
                }
                return _obj1;
            }
        }

        public Panel panel
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }

        public Form1()
        {

          
            InitializeComponent();
            //doubleClickButton1.DoubleClick += new EventHandler(doubleClickButton1_DoubleClick);
            Login uc = new Login();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
            panelContainer.Controls.Add(uc);
            panelContainer.Controls["Login"].BringToFront();
            label3.Text = StaticInfo.getUserName();
        }

        public class PanelDoubleBuffered : System.Windows.Forms.Panel
        {
            public PanelDoubleBuffered()
                : base()
            {
                this.DoubleBuffered = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            _obj1 = this;
                                
        }

        private void Dashboard_btn_Click(object sender, EventArgs e)
        {
            if (AuthenticationCheck.logedin) {
                if (AuthenticationCheck.feature)

                { label5.Text = "DASHBOARD";
                    Dashboard dashboard = new Dashboard();
                    dashboard.Dock = DockStyle.Fill;
                    panelContainer.Controls.Add(dashboard);
                    panelContainer.Controls["Dashboard"].BringToFront();
                    
                }
                else 
                {
                    label5.Text = "Seller Home";
                    Seller_Home seller_home = new Seller_Home();
                    seller_home.Dock = DockStyle.Fill;
                    panelContainer.Controls.Add(seller_home);
                    panelContainer.Controls["Seller_Home"].BringToFront();
                }
            }

            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {


        }
        
        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
            {
                pictureBox7.Visible = false;
            }

            else
            {
                pictureBox7.Visible = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AuthenticationCheck.logedin)
            {
                label5.Text = "VENDORS";
                Vendors vendors = new Vendors();
                vendors.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(vendors);//can all be added before hand???
                panelContainer.Controls["Vendors"].BringToFront();
            }

        }

        private void dashboard2_Load(object sender, EventArgs e)
        {

     
        }

        private void Games_Click(object sender, EventArgs e)
        {if (AuthenticationCheck.logedin)
            {
                label5.Text = "GAMES";
                Games games = new Games();
                games.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(games);
                panelContainer.Controls["games"].BringToFront();
            }
        }

        private void Wallet_Click(object sender, EventArgs e)
        {
            if (AuthenticationCheck.logedin)
            {
                label5.Text = "WALLET";

                Wallet wallet = new Wallet();
                wallet.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(wallet);
                panelContainer.Controls["Wallet"].BringToFront();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (AuthenticationCheck.logedin)
            {
                Settings settings = new Settings();
                settings.Dock = DockStyle.Fill;
                panelContainer.Controls.Add(settings);
                panelContainer.Controls["Settings"].BringToFront();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(login);
            panelContainer.Controls["Login"].BringToFront();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            notification notification = new notification();
            notification.Dock = DockStyle.Right;
            panelContainer.Controls.Add(notification);
            panelContainer.Controls["Notification"].BringToFront();

        }
        

        private void button10_MouseHover(object sender, EventArgs e)
        {

            

        }

        private void button10_MouseEnter(object sender, EventArgs e)
        {
            //Util.Animate(notification1, Util.Effect.Slide, 100, 150);
            //notification1.Show();
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            //Util.Animate(notification1, Util.Effect.Slide, 150, 100);
            //notification1.Hide();
        }

        private void notification1_Load(object sender, EventArgs e)
        {

        }

        private void Contact_us_Paint(object sender, PaintEventArgs e)
        {

        }

        private void round1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Dashboard_btn_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void ovalPictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";

            if (opnfd.ShowDialog() == DialogResult.OK)
            {
              

            }
        
        }
        
        private void label6_Click(object sender, EventArgs e)
        {
            
            label5.Text = "ABOUT US";
            About about = new About();
            about.Dock = DockStyle.Right;
            panelContainer.Controls.Add(about);
            panelContainer.Controls["About"].BringToFront();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (AuthenticationCheck.logedin)
            {
                if (AuthenticationCheck.feature) {
                    label5.Text = "CART";
                    Cart Cart = new Cart();
                    Cart.Dock = DockStyle.Right;
                    panelContainer.Controls.Add(Cart);
                    panelContainer.Controls["Cart"].BringToFront();
                }
                else
                {
                    
                    MessageBox.Show("NO cart for user");

                }
            }

    }
}
    

}
