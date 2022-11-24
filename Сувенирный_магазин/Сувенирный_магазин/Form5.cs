using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сувенирный_магазин
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void покупкиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.покупкиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.сувенирный_магазинDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'сувенирный_магазинDataSet.Покупки' table. You can move, or remove it, as needed.
            this.покупкиTableAdapter.Fill(this.сувенирный_магазинDataSet.Покупки);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.покупкиBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.покупкиBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.покупкиBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.покупкиBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.покупкиBindingSource.MoveNext();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.покупкиBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.покупкиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.сувенирный_магазинDataSet);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double ant, bnt;
            ant = Convert.ToDouble(цена_за_единицуTextBox.Text);
            bnt = (118 * ant) / 100;
            textBox1.Text = bnt.ToString();
        }
    }
}
