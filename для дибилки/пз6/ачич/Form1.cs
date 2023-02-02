using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ачич
{
    public partial class Form1 : Form
    {
        int[] Mass = new int[30];
        int sum = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rand = new Random();
            for (int i = 0; i < 30; i++)
            {
                Mass[i] = rand.Next(-20, 20);
                listBox1.Items.Add("element[" + i.ToString()
                    + "] = " + Mass[i].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            for (int i =  0; i < 30; i++)
            {
                if (Mass[i] < 0)
                    sum = sum + Mass[i];
                else if (Mass[i] % 2 == 1)
                    sum = sum + Mass[i];
            }
            listBox2.Items.Add("Сумма:" + sum.ToString());
        }
    }
}
