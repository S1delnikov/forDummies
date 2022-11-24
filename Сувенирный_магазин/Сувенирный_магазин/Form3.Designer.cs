namespace Сувенирный_магазин
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            System.Windows.Forms.Label код_наименования_товараLabel;
            System.Windows.Forms.Label наименованиеLabel;
            System.Windows.Forms.Label весLabel;
            System.Windows.Forms.Label ценаLabel;
            System.Windows.Forms.Label есть_в_наличииLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.сувенирный_магазинDataSet = new Сувенирный_магазин.сувенирный_магазинDataSet();
            this.наименование_товараBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.наименование_товараTableAdapter = new Сувенирный_магазин.сувенирный_магазинDataSetTableAdapters.Наименование_товараTableAdapter();
            this.tableAdapterManager = new Сувенирный_магазин.сувенирный_магазинDataSetTableAdapters.TableAdapterManager();
            this.наименование_товараBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.наименование_товараBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_наименования_товараTextBox = new System.Windows.Forms.TextBox();
            this.наименованиеTextBox = new System.Windows.Forms.TextBox();
            this.весTextBox = new System.Windows.Forms.TextBox();
            this.ценаTextBox = new System.Windows.Forms.TextBox();
            this.есть_в_наличииCheckBox = new System.Windows.Forms.CheckBox();
            код_наименования_товараLabel = new System.Windows.Forms.Label();
            наименованиеLabel = new System.Windows.Forms.Label();
            весLabel = new System.Windows.Forms.Label();
            ценаLabel = new System.Windows.Forms.Label();
            есть_в_наличииLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.сувенирный_магазинDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.наименование_товараBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.наименование_товараBindingNavigator)).BeginInit();
            this.наименование_товараBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(149, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование_товара";
            // 
            // сувенирный_магазинDataSet
            // 
            this.сувенирный_магазинDataSet.DataSetName = "сувенирный_магазинDataSet";
            this.сувенирный_магазинDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // наименование_товараBindingSource
            // 
            this.наименование_товараBindingSource.DataMember = "Наименование_товара";
            this.наименование_товараBindingSource.DataSource = this.сувенирный_магазинDataSet;
            // 
            // наименование_товараTableAdapter
            // 
            this.наименование_товараTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Сувенирный_магазин.сувенирный_магазинDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Виды_товараTableAdapter = null;
            this.tableAdapterManager.Наименование_товараTableAdapter = this.наименование_товараTableAdapter;
            this.tableAdapterManager.ПокупателиTableAdapter = null;
            this.tableAdapterManager.ПокупкиTableAdapter = null;
            this.tableAdapterManager.ПоставщикиTableAdapter = null;
            // 
            // наименование_товараBindingNavigator
            // 
            this.наименование_товараBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.наименование_товараBindingNavigator.BindingSource = this.наименование_товараBindingSource;
            this.наименование_товараBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.наименование_товараBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.наименование_товараBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.наименование_товараBindingNavigatorSaveItem});
            this.наименование_товараBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.наименование_товараBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.наименование_товараBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.наименование_товараBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.наименование_товараBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.наименование_товараBindingNavigator.Name = "наименование_товараBindingNavigator";
            this.наименование_товараBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.наименование_товараBindingNavigator.Size = new System.Drawing.Size(500, 25);
            this.наименование_товараBindingNavigator.TabIndex = 1;
            this.наименование_товараBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // наименование_товараBindingNavigatorSaveItem
            // 
            this.наименование_товараBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.наименование_товараBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("наименование_товараBindingNavigatorSaveItem.Image")));
            this.наименование_товараBindingNavigatorSaveItem.Name = "наименование_товараBindingNavigatorSaveItem";
            this.наименование_товараBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.наименование_товараBindingNavigatorSaveItem.Text = "Save Data";
            this.наименование_товараBindingNavigatorSaveItem.Click += new System.EventHandler(this.наименование_товараBindingNavigatorSaveItem_Click);
            // 
            // код_наименования_товараLabel
            // 
            код_наименования_товараLabel.AutoSize = true;
            код_наименования_товараLabel.Location = new System.Drawing.Point(95, 106);
            код_наименования_товараLabel.Name = "код_наименования_товараLabel";
            код_наименования_товараLabel.Size = new System.Drawing.Size(144, 13);
            код_наименования_товараLabel.TabIndex = 2;
            код_наименования_товараLabel.Text = "Код наименования товара:";
            // 
            // код_наименования_товараTextBox
            // 
            this.код_наименования_товараTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.наименование_товараBindingSource, "Код_наименования_товара", true));
            this.код_наименования_товараTextBox.Location = new System.Drawing.Point(277, 99);
            this.код_наименования_товараTextBox.Name = "код_наименования_товараTextBox";
            this.код_наименования_товараTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_наименования_товараTextBox.TabIndex = 3;
            // 
            // наименованиеLabel
            // 
            наименованиеLabel.AutoSize = true;
            наименованиеLabel.Location = new System.Drawing.Point(95, 141);
            наименованиеLabel.Name = "наименованиеLabel";
            наименованиеLabel.Size = new System.Drawing.Size(86, 13);
            наименованиеLabel.TabIndex = 4;
            наименованиеLabel.Text = "Наименование:";
            // 
            // наименованиеTextBox
            // 
            this.наименованиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.наименование_товараBindingSource, "Наименование", true));
            this.наименованиеTextBox.Location = new System.Drawing.Point(277, 134);
            this.наименованиеTextBox.Name = "наименованиеTextBox";
            this.наименованиеTextBox.Size = new System.Drawing.Size(100, 20);
            this.наименованиеTextBox.TabIndex = 5;
            // 
            // весLabel
            // 
            весLabel.AutoSize = true;
            весLabel.Location = new System.Drawing.Point(95, 182);
            весLabel.Name = "весLabel";
            весLabel.Size = new System.Drawing.Size(29, 13);
            весLabel.TabIndex = 6;
            весLabel.Text = "Вес:";
            // 
            // весTextBox
            // 
            this.весTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.наименование_товараBindingSource, "Вес", true));
            this.весTextBox.Location = new System.Drawing.Point(277, 175);
            this.весTextBox.Name = "весTextBox";
            this.весTextBox.Size = new System.Drawing.Size(100, 20);
            this.весTextBox.TabIndex = 7;
            // 
            // ценаLabel
            // 
            ценаLabel.AutoSize = true;
            ценаLabel.Location = new System.Drawing.Point(95, 227);
            ценаLabel.Name = "ценаLabel";
            ценаLabel.Size = new System.Drawing.Size(36, 13);
            ценаLabel.TabIndex = 8;
            ценаLabel.Text = "Цена:";
            // 
            // ценаTextBox
            // 
            this.ценаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.наименование_товараBindingSource, "Цена", true));
            this.ценаTextBox.Location = new System.Drawing.Point(277, 220);
            this.ценаTextBox.Name = "ценаTextBox";
            this.ценаTextBox.Size = new System.Drawing.Size(100, 20);
            this.ценаTextBox.TabIndex = 9;
            // 
            // есть_в_наличииLabel
            // 
            есть_в_наличииLabel.AutoSize = true;
            есть_в_наличииLabel.Location = new System.Drawing.Point(95, 271);
            есть_в_наличииLabel.Name = "есть_в_наличииLabel";
            есть_в_наличииLabel.Size = new System.Drawing.Size(87, 13);
            есть_в_наличииLabel.TabIndex = 10;
            есть_в_наличииLabel.Text = "Есть в наличии:";
            // 
            // есть_в_наличииCheckBox
            // 
            this.есть_в_наличииCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.наименование_товараBindingSource, "Есть_в_наличии", true));
            this.есть_в_наличииCheckBox.Location = new System.Drawing.Point(277, 260);
            this.есть_в_наличииCheckBox.Name = "есть_в_наличииCheckBox";
            this.есть_в_наличииCheckBox.Size = new System.Drawing.Size(104, 24);
            this.есть_в_наличииCheckBox.TabIndex = 11;
            this.есть_в_наличииCheckBox.Text = "checkBox1";
            this.есть_в_наличииCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(есть_в_наличииLabel);
            this.Controls.Add(this.есть_в_наличииCheckBox);
            this.Controls.Add(ценаLabel);
            this.Controls.Add(this.ценаTextBox);
            this.Controls.Add(весLabel);
            this.Controls.Add(this.весTextBox);
            this.Controls.Add(наименованиеLabel);
            this.Controls.Add(this.наименованиеTextBox);
            this.Controls.Add(код_наименования_товараLabel);
            this.Controls.Add(this.код_наименования_товараTextBox);
            this.Controls.Add(this.наименование_товараBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.сувенирный_магазинDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.наименование_товараBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.наименование_товараBindingNavigator)).EndInit();
            this.наименование_товараBindingNavigator.ResumeLayout(false);
            this.наименование_товараBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private сувенирный_магазинDataSet сувенирный_магазинDataSet;
        private System.Windows.Forms.BindingSource наименование_товараBindingSource;
        private сувенирный_магазинDataSetTableAdapters.Наименование_товараTableAdapter наименование_товараTableAdapter;
        private сувенирный_магазинDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator наименование_товараBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton наименование_товараBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_наименования_товараTextBox;
        private System.Windows.Forms.TextBox наименованиеTextBox;
        private System.Windows.Forms.TextBox весTextBox;
        private System.Windows.Forms.TextBox ценаTextBox;
        private System.Windows.Forms.CheckBox есть_в_наличииCheckBox;
    }
}