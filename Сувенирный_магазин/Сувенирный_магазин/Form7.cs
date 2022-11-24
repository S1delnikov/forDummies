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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void покупкиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.покупкиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.сувенирный_магазинDataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'сувенирный_магазинDataSet.Покупки' table. You can move, or remove it, as needed.
            this.покупкиTableAdapter.Fill(this.сувенирный_магазинDataSet.Покупки);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DataGridViewColumn Col =  default(System.Windows.Forms.DataGridViewColumn);
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    Col = dataGridViewTextBoxColumn1;
                    break;
                case 1:
                    Col = dataGridViewTextBoxColumn2;
                    break;
                case 2:
                    Col = dataGridViewTextBoxColumn3;
                    break;
                case 3:
                    Col = dataGridViewTextBoxColumn4;
                    break;
                case 4:
                    Col = dataGridViewTextBoxColumn5;
                    break;
                case 5:
                    Col = dataGridViewTextBoxColumn6;
                    break;
            }
            if (radioButton1.Checked)
            {
                покупкиDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending);
            }
            else 
            {
                покупкиDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            покупкиBindingSource.Filter = string.Format(" [Дата_заказа] = '{0:dd.MM.yyyy}'", dateTimePicker1.Value.ToShortDateString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            покупкиBindingSource.Filter = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = 0;
            int j = 0;
            for (i = 0; i < покупкиDataGridView.ColumnCount - 1; i++) 
            {
                for (j = 0; j < покупкиDataGridView.RowCount - 1; j++) 
                {
                    покупкиDataGridView.Rows[j].Cells[i].Style.BackColor = Color.White;
                    покупкиDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Black;
                }
            }
            for (i = 0; i < покупкиDataGridView.ColumnCount; i++) 
            {
                for (j = 0; j < покупкиDataGridView.RowCount; j++) 
                {
                    var value = покупкиDataGridView.Rows[j].Cells[i].Value;
                    if (value != null)
                    {
                        string baseStr = value.ToString();
                        if (baseStr.IndexOf(textBox1.Text) > -1) 
                        {
                            покупкиDataGridView.Rows[j].Cells[i].Style.BackColor = Color.Aqua;
                            покупкиDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Blue;
                        }
                    }
                }
            }
        }
    }
}
