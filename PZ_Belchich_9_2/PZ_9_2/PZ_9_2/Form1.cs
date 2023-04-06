using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PZ_9_2
{
    public partial class Form1 : Form
    {
        GraphicsPath path;
        public Form1()
        {
            InitializeComponent();
            path = new GraphicsPath();
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            gr.Clear(Color.White);
            //Создаём штриховую кисть жёлтого цвета
            HatchBrush brush = new HatchBrush(myBrush, myColor);
            //gr.FillEllipse(brush, x0 - radius, y0 - radius, 2 * radius, 2 * radius);
            Point[] pointer = new Point[]
            {
                new Point (x0, y0),
                new Point (x0 + 50, y0),
                new Point (x0 + 50, y0 - 10),
                new Point (x0 + 75, y0 + 8),
                new Point (x0 + 50, y0 + 25),
                new Point (x0 + 50, y0 + 15),
                new Point (x0, y0 + 15),
                new Point (x0, y0 + 25),
                new Point (x0 - 25, y0 + 8),
                new Point (x0, y0 - 10),
                new Point (x0, y0)
            };
            gr.DrawLines(new Pen(Color.Black, 2), pointer);
            gr.FillPolygon(brush, pointer);

            // Очищаем фигуру
            path.Reset();
            // Начинаем формирование фигуры
            path.StartFigure();
            // Добавляем круг в фигуру
            path.AddLines(pointer);
            // Завершаем формирование фигуры
            path.CloseFigure();
        }
        int x0, y0, xDir, yDir;

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = trackBar1.Value;
        }

        HatchStyle myBrush;
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point pt = new Point(e.X, e.Y);
                if (path.IsVisible(pt))
                {
                    ColorDialog clrDlg = new ColorDialog();
                    if (clrDlg.ShowDialog() == DialogResult.OK)
                        myColor = clrDlg.Color;
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                Point pt = new Point(e.X, e.Y);
                if (path.IsVisible(pt))
                {
                    Form2 styleDialog = new Form2();
                    if (styleDialog.ShowDialog() == DialogResult.OK)
                        myBrush = styleDialog.Style;
                }
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        bool left = false, right = false, top = false, bottom = false, center = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (x0 - 25 < 0)
            //    xDir = 1;
            //if (x0 + 75 > pictureBox1.Width)
            //    xDir = -1;
            //if (y0 - 10 < 0)
            //    yDir = 1;
            //if (y0 + 25 > pictureBox1.Height)
            //    yDir = -1;

            if (left == false)
            {
                bottom = false;
                if (x0 + 1 == centerX && y0 + 1 == centerY)
                    left = true;
                if (x0 - 25 < 0)
                    left = true;
                else
                {
                    xDir = -1;
                    yDir = 0;
                }
            }
            else if (top == false)
            {
                if (x0 + 1 == centerX && y0 + 1 == centerY)
                    top = true;
                if (y0 - 10 < 0)
                    top = true;
                else
                {
                    xDir = 0;
                    yDir = -1;
                }
            }
            else if (right == false)
            {
                if (x0 + 1 == centerX && y0+1 == centerY)
                    right = true;
                if (x0 + 75 > pictureBox1.Width)
                    right = true;
                else
                {
                    xDir = 1;
                    yDir = 0;
                }
            }
            else if (bottom == false)
            {
                if (x0+1 == centerX && y0+1 == centerY)
                {
                    bottom = true;
                    right = false;
                    top = false;
                    left = false;
                }
                if (x0 + 75 > pictureBox1.Width)
                    bottom = true;
                else
                {
                    xDir = 0;
                    yDir = 1;
                }
            }


            x0 += xDir;
            y0 += yDir;

            pictureBox1.Invalidate();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        Color myColor;
        int centerX, centerY;
        private void Form1_Load(object sender, EventArgs e)
        {
            centerX = pictureBox1.Width / 2 - 50;
            centerY =pictureBox1.Height / 2;
            x0 = pictureBox1.Width / 2 - 50;
            y0 = pictureBox1.Height / 2;
            xDir = 1;
            yDir = -1;
            myColor = Color.Yellow;
        }
    }
}
