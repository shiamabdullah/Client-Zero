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
using Project_Alpha.message_box;

namespace Project_Alpha.Header
{
    public partial class Cart : UserControl
    {
        cart_product_ls[] userCart;
        node[] cartNode;
        int size = 0;
       
        public Cart()
        {
            cartNode = Form1.queue.getItems();
            size = cartNode.Length;
            userCart = new cart_product_ls[size];
            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
            this.label1.Text = Form1.queue.totalCost.ToString();
            populate();
        }

        private void populate()
        {
            while (flowLayoutPanel1.Controls.Count > 0) { flowLayoutPanel1.Controls.RemoveAt(0); }
            for (int i = 0; i < size; i++)
            {
                userCart[i] = new cart_product_ls();
                userCart[i].gameName = cartNode[i].name;
                userCart[i].rating = cartNode[i].id.ToString();
                userCart[i].platform = cartNode[i].platform;
                userCart[i].currency = cartNode[i].price.ToString();

                if (flowLayoutPanel1.Controls.Count < 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                else
                {
                    this.flowLayoutPanel1.SuspendLayout();
                    flowLayoutPanel1.Controls.Add(userCart[i]);
                    this.flowLayoutPanel1.ResumeLayout();
                    this.flowLayoutPanel1.PerformLayout();
                    this.flowLayoutPanel1.Refresh();
                }
            }
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void purchased_SIngle_Item1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            messagebox messagebox = new messagebox();
            messagebox.ShowDialog();
            
               
        }
    }
}
