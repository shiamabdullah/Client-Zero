using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Alpha.Custom_List_File;
using Project_Alpha.Custom_Class;
using Project_Alpha.Properties;

namespace Project_Alpha
{
    public partial class Games : UserControl
    {
        public Games()
        {
           
            InitializeComponent();
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            populateItems();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void populateItems()
        {
            
            personal_game_ls[] personal_Game_Ls = new personal_game_ls[5];

            for (int i = 0; i < 5; i++)
            {
              personal_Game_Ls[i] = new personal_game_ls();
              personal_Game_Ls[i].Visible = true;
              personal_Game_Ls[i].gamePic = Resources.dota;
              personal_Game_Ls[i].gameName = "DOTA";


                if (flowLayoutPanel1.Controls.Count < 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                else
                {
                    this.flowLayoutPanel1.SuspendLayout();
                    flowLayoutPanel1.Controls.Add(personal_Game_Ls[i]);
                    this.flowLayoutPanel1.ResumeLayout();
                    this.flowLayoutPanel1.PerformLayout();
                    this.flowLayoutPanel1.Refresh();
                }
            }


        }

                private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
