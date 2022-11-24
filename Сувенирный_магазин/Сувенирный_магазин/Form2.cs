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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void виды_товараBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.виды_товараBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.сувенирный_магазинDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'сувенирный_магазинDataSet.Виды_товара' table. You can move, or remove it, as needed.
            this.виды_товараTableAdapter.Fill(this.сувенирный_магазинDataSet.Виды_товара);

        }
    }
}
