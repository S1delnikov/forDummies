using System;
using System.Drawing;
using System.Drawing.Drawing2D;
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

        int loop = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (loop == 0)
            {
                if (x0 != 25)
                    x0--;
                else loop++;
            }
            if (loop == 1)
            {
                if (x0 != centerX)
                    x0++;
                else loop++;
            }
            if (loop == 2)
            {
                if (y0 != 10)
                    y0--;
                else loop++;
            }
            if (loop == 3)
            {
                if (y0 != centerY)
                    y0++;
                else loop++;
            }
            if (loop == 4)
            {
                if (x0 != pictureBox1.Width - 75)
                    x0++;
                else loop++;
            }
            if (loop == 5)
            {
                if (x0 != centerX)
                    x0--;
                else loop++;
            }
            if (loop == 6)
            {
                if (y0 != pictureBox1.Height - 25)
                    y0++;
                else loop++;
            }
            if (loop == 7)
            {
                if (y0 != centerY)
                    y0--;
                else loop = 0;
            }

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
            myColor = Color.Yellow;
        }
    }
}
