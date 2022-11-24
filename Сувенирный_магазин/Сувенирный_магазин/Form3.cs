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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void наименование_товараBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.наименование_товараBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.сувенирный_магазинDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'сувенирный_магазинDataSet.Наименование_товара' table. You can move, or remove it, as needed.
            this.наименование_товараTableAdapter.Fill(this.сувенирный_магазинDataSet.Наименование_товара);

        }
    }
}
