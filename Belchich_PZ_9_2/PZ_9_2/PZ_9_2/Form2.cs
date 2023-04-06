using System;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PZ_9_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public HatchStyle Style
        {
            get
            {
                if (radioButton1.Checked)
                    return HatchStyle.DashedDownwardDiagonal;
                if (radioButton2.Checked)
                    return HatchStyle.DashedHorizontal;
                if (radioButton3.Checked)
                    return HatchStyle.Cross;
                if (radioButton4.Checked)
                    return HatchStyle.DarkVertical;
                if (radioButton5.Checked)
                    return HatchStyle.DiagonalCross;
                return HatchStyle.DottedGrid;
            }
            set
            {
                if (value == HatchStyle.DashedDownwardDiagonal)
                    radioButton1.Checked = true;
                if (value == HatchStyle.DashedHorizontal)
                    radioButton2.Checked = true;
                if (value == HatchStyle.Cross)
                    radioButton3.Checked = true;
                if (value == HatchStyle.DarkVertical)
                    radioButton4.Checked = true;
                if (value == HatchStyle.DiagonalCross)
                    radioButton5.Checked = true;
                if (value == HatchStyle.DottedGrid)
                    radioButton6.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
