using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Alpha
{
    public class CustomCheckBox : CheckBox
    {
        public CustomCheckBox()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            if (this.Checked)
            {
                pevent.Graphics.FillRectangle(brush: new SolidBrush(Color.Green), new Rectangle(0, 0, 16, 16));
            }
            else
            {
                pevent.Graphics.FillRectangle(brush: new SolidBrush(Color.Red), new Rectangle(0, 0, 16, 16));
            }
        }
    }
}
