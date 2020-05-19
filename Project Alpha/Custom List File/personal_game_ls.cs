using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Alpha.Custom_List_File
{
    public partial class personal_game_ls : UserControl
    {
        public personal_game_ls()
        {
            InitializeComponent();
        }


        #region Properties


        private Image _gamePic;
        private String _gameName;



        [Category("Custom Props")]
        public Image gamePic
        {
            get { return _gamePic; }
            set { _gamePic = value; pictureBox1.Image = value; }
        }

        [Category("Custom Props")]
        public String gameName
        {
            get { return _gameName; }
            set { _gameName = value; gameNamelbl.Text = value; }
        }


        #endregion

    }
}
