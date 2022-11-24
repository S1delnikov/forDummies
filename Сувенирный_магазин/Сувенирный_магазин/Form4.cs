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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void покупателиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.покупателиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.сувенирный_магазинDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'сувенирный_магазинDataSet.Покупатели' table. You can move, or remove it, as needed.
            this.покупателиTableAdapter.Fill(this.сувенирный_магазинDataSet.Покупатели);

        }
    }
}
