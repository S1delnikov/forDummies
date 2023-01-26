using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace пз5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "-1,5";
            textBox2.Text = "-2,5";
            textBox3.Text = "-0,5";
            textBox4.Text = "-0,8";
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            double x0 = Convert.ToDouble(textBox1.Text);
            double xk = Convert.ToDouble(textBox2.Text);
            double dx = Convert.ToDouble(textBox3.Text);
            double b = Convert.ToDouble(textBox4.Text);
            textBox5.Text = "Решение: " + Environment.NewLine;

            while (x0 >= xk)
            {
                double y = Math.Pow(x0, 2) + Math.Tan(5 * x0 + b / x0);
                textBox5.Text += "x = " + Convert.ToString(x0) + "; y = " + Convert.ToString(y) +
                    Environment.NewLine;
                x0 = x0 + (dx);

            }
        }
    }
}
