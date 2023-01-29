using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Холодов_лаба_14_2
{
    public partial class Form1 : Form
    {
        public enum DateTimeFormat
        {
            ShowTime,
            ShowDate
        }

        DateTimeFormat dtFormat;
        ToolStripMenuItem currentCheckedItem;
        ToolStripMenuItem currentCheckedEquation;

        public Form1()
        {
            InitializeComponent();
            Text = "Пример строки состояния";
            CenterToScreen();
            BackColor = Color.CadetBlue;
            currentCheckedItem = toolStripMenuItemTime;
            currentCheckedItem.Checked = true;
        }

        private void timerDateTimeUpdate_Tick(object sender, EventArgs e)
        {
            string info = "";
            if (dtFormat == DateTimeFormat.ShowTime)
                info = DateTime.Now.ToLongTimeString();
            else
                info = DateTime.Now.ToLongDateString();
            toolStripStatusLabelClock.Text = info;
        }

        private void ToolStripMenuItemDate_Click(object sender, EventArgs e)
        {
            //устанвока даты
            currentCheckedItem.Checked = false;
            dtFormat = DateTimeFormat.ShowDate;
            currentCheckedItem = ToolStripMenuItemDate;
            currentCheckedItem.Checked = true;
        }

        private void toolStripMenuItemTime_Click(object sender, EventArgs e)
        {
            //установка времени
            currentCheckedItem.Checked = false;
            dtFormat = DateTimeFormat.ShowTime;
            currentCheckedItem = toolStripMenuItemTime;
            currentCheckedItem.Checked = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabelState.Text = $"Координаты курсора мыши: {e.X}; {e.Y}";
            if (currentCheckedEquation == ThirdEquation)
                ResultToolStripStatusLabel.Text = (Math.Sqrt(e.X / (e.Y + 1)) + e.Y).ToString();
            else if (currentCheckedEquation == SecondEquation)
                ResultToolStripStatusLabel.Text = (Math.Sqrt(Math.Pow(e.Y, 3))).ToString();
            else if (currentCheckedEquation == FirstEquation)
                ResultToolStripStatusLabel.Text = ((Math.Pow(e.X, 3) + e.Y) / (Math.Pow(e.Y, 2) + 1)).ToString();
            else
                ResultToolStripStatusLabel.Text = "Уравнение не выбрано";

        }

        private void CalculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Если поле в главном меню не получило значения, то
                // берётся значение для этого поля из контекстного меню
                // (синхронизация главного и контекстного меню)

                double a, b, x, y, z;
                try
                {
                     a = double.Parse(aComboBox.Text);
                    aContextComboBox.Text = a.ToString();
                } catch {  a = double.Parse(aContextComboBox.Text); }
                try
                {
                    b = double.Parse(bComboBox.Text);
                    bContextComboBox.Text = b.ToString();
                } catch { b = double.Parse(bContextComboBox.Text); }
                try
                {
                    x = double.Parse(xTextBox.Text);
                    xContextTextBox.Text = x.ToString();
                } catch { x = double.Parse(xContextTextBox.Text); }
                try
                {
                    y = double.Parse(yTextBox.Text);
                    yContextTextBox.Text = y.ToString();
                } catch { y = double.Parse(yContextTextBox.Text); }
                try
                {
                    z = double.Parse(zTextBox.Text);
                    zContextTextBox.Text = z.ToString();
                } catch { z = double.Parse(zContextTextBox.Text); }

                resultTextBox.Text = Math.Round(Math.Pow(a, 2) * x + (b - a) * y + Math.Sin(z), 4).ToString();
            } catch { MessageBox.Show("Убедитесь, что все данные введены корректно"); }
        }

        private void ContextCalculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Если поле в контекстном меню не получило значения, то
                // берётся значение для этого поля из главного меню
                // (синхронизация главного и контекстного меню)

                double a, b, x, y, z;

                try
                {
                    a = double.Parse(aContextComboBox.Text);
                    aComboBox.Text = a.ToString();
                } catch { a = double.Parse(aComboBox.Text); }
                try
                {
                    b = double.Parse(bContextComboBox.Text);
                    bComboBox.Text = b.ToString();
                } catch { b = double.Parse(bComboBox.Text); }
                try
                {
                    x = double.Parse(xContextTextBox.Text);
                    xTextBox.Text = x.ToString();
                } catch { x = double.Parse(xTextBox.Text);  }
                try
                {
                    y = double.Parse(yContextTextBox.Text);
                    yTextBox.Text = y.ToString();
                } catch { y = double.Parse(yTextBox.Text); }
                try
                {
                    z = double.Parse(zContextTextBox.Text);
                    zTextBox.Text = z.ToString();
                } catch { z = double.Parse(zTextBox.Text); }

                resultTextBox.Text = Math.Round(Math.Pow(a, 2) * x + (b - a) * y + Math.Sin(z), 4).ToString();
            }
            catch { MessageBox.Show("Убедитесь, что все данные введены корректно"); }
        }

        private void ThirdEquation_Click(object sender, EventArgs e)
        {
            currentCheckedEquation = ThirdEquation;
        }

        private void SecondEquation_Click(object sender, EventArgs e)
        {
            currentCheckedEquation = SecondEquation;
        }

        private void FirstEquation_Click(object sender, EventArgs e)
        {
            currentCheckedEquation = FirstEquation;
        }
    }


}
