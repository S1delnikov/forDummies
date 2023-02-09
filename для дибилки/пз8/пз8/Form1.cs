using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace пз8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Xmin = double.Parse(textBoxMin.Text);
            double Xmax = double.Parse(textBoxMax.Text);
            double Step = double.Parse(textBoxStep.Text);

            int count = (int)Math.Ceiling((Xmax - Xmin) / Step)
                + 1;

            double[] x = new double[count];

            double[] y1 = new double[count];
            double b = double.Parse(textBoxb.Text);
            double[] y2 = new double[count];

            for (int i = 0; i < count; i++)
            {
                x[i] = Xmin + Step * i;

                y1[i] = Math.Pow(x[i], 2) + Math.Tan(5 * x[i] + b / x[i]);
                y2[i] = Math.Pow(x[i], 2);
            }

            chart1.ChartAreas[0].AxisX.Minimum = Xmin;
            chart1.ChartAreas[0].AxisX.Maximum = Xmax;

            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = Step;

            chart1.Series[0].Points.DataBindXY(x, y1);
            chart1.Series[1].Points.DataBindXY(x, y2);

        }

      

        
    }
}
