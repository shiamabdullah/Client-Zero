using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Alpha.Properties;

namespace Project_Alpha
{


    public partial class notification : UserControl
    {
        public notification()
        {

            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            InitializeComponent();          
            populateItems();
            
        }


        Notification_ls[] Notification_Ls = new Notification_ls[4];



        private void populateItems()
        {
            for (int i = 0; i < 4; i++)
            {

                Notification_Ls[i] = new Notification_ls();
                Notification_Ls[i].Visible=true;
                Notification_Ls[i].name = "XERO GAMING";
                Notification_Ls[i].message = "Your Order Delivered.Here is the key XXXX-XXXX -XXXX- XXXX";
                Notification_Ls[i].propic = Resources.vector1;


                if (flowLayoutPanel1.Controls.Count < 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                else
                {
                    this.flowLayoutPanel1.SuspendLayout();
                    flowLayoutPanel1.Controls.Add(Notification_Ls[i]);
                    this.flowLayoutPanel1.ResumeLayout();
                    this.flowLayoutPanel1.PerformLayout();
                    this.flowLayoutPanel1.Refresh();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}