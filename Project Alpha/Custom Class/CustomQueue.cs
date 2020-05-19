using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Alpha.Custom_Class
{
    public class node
    {
        public double price = 0;
        public string name = "";
        public int id = 0;
        public string platform = "";
        public node next = null, pre = null;
    }
    public class CustomQueue
    {
        node head, tail;
        public double totalCost = 0;
        int count=0;

        public void Push(int id,string name,string platform,double price)
        {
            node temp = new node();
            temp.id = -id;
            temp.name = name;
            temp.platform = platform;
            temp.price = price;
            totalCost = totalCost + price;
            if (head == null)
            {
                head = temp;
                tail = temp;
            }
            else 
            {
                temp.pre = tail;
                tail.next = temp;
                tail = temp;
            }
            count++;
            MessageBox.Show("pushed item with id: "+id.ToString());
        }

        public node[] getItems()
        {
            node[] temp = new node[count];
            node temp1 = head;
            for (int i = 0; i < count; i++)
            {
                temp[i] = temp1;
                temp1 = temp1.next;
            }
            return temp;
        }

        public node Pop()
        {
            node temp = head;
            head = head.next;
            count--;
            return temp;
        }
        public void removeItem(int id)
        {
            if (count != 0)
            {
                node temp = null;
                if (id == head.id)
                {
                    totalCost -= head.price;
                    head = null;
                    tail = null;
                }
                else
                {
                    temp = head;
                    head = head.next;
                    totalCost -= temp.price;
                    temp = null;
                }
            }
            else if (tail.id == id)
            {
                
            }
        }
    }
}
