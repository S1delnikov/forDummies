namespace Сувенирный_магазин
{
    partial class Form4
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
            System.Windows.Forms.Label код_покупателяLabel;
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label возрастLabel;
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label номер_телефонаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.сувенирный_магазинDataSet = new Сувенирный_магазин.сувенирный_магазинDataSet();
            this.покупателиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.покупателиTableAdapter = new Сувенирный_магазин.сувенирный_магазинDataSetTableAdapters.ПокупателиTableAdapter();
            this.tableAdapterManager = new Сувенирный_магазин.сувенирный_магазинDataSetTableAdapters.TableAdapterManager();
            this.покупателиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.покупателиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_покупателяTextBox = new System.Windows.Forms.TextBox();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.возрастTextBox = new System.Windows.Forms.TextBox();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            код_покупателяLabel = new System.Windows.Forms.Label();
            фИОLabel = new System.Windows.Forms.Label();
            возрастLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            номер_телефонаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.сувенирный_магазинDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.покупателиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.покупателиBindingNavigator)).BeginInit();
            this.покупателиBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // код_покупателяLabel
            // 
            код_покупателяLabel.AutoSize = true;
            код_покупателяLabel.Location = new System.Drawing.Point(99, 99);
            код_покупателяLabel.Name = "код_покупателяLabel";
            код_покупателяLabel.Size = new System.Drawing.Size(90, 13);
            код_покупателяLabel.TabIndex = 2;
            код_покупателяLabel.Text = "Код покупателя:";
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Location = new System.Drawing.Point(99, 155);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(37, 13);
            фИОLabel.TabIndex = 4;
            фИОLabel.Text = "ФИО:";
            // 
            // возрастLabel
            // 
            возрастLabel.AutoSize = true;
            возрастLabel.Location = new System.Drawing.Point(99, 204);
            возрастLabel.Name = "возрастLabel";
            возрастLabel.Size = new System.Drawing.Size(52, 13);
            возрастLabel.TabIndex = 6;
            возрастLabel.Text = "Возраст:";
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Location = new System.Drawing.Point(99, 257);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(41, 13);
            адресLabel.TabIndex = 8;
            адресLabel.Text = "Адрес:";
            // 
            // номер_телефонаLabel
            // 
            номер_телефонаLabel.AutoSize = true;
            номер_телефонаLabel.Location = new System.Drawing.Point(99, 304);
            номер_телефонаLabel.Name = "номер_телефонаLabel";
            номер_телефонаLabel.Size = new System.Drawing.Size(96, 13);
            номер_телефонаLabel.TabIndex = 10;
            номер_телефонаLabel.Text = "Номер телефона:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(167, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Покупатели";
            // 
            // сувенирный_магазинDataSet
            // 
            this.сувенирный_магазинDataSet.DataSetName = "сувенирный_магазинDataSet";
            this.сувенирный_магазинDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // покупателиBindingSource
            // 
            this.покупателиBindingSource.DataMember = "Покупатели";
            this.покупателиBindingSource.DataSource = this.сувенирный_магазинDataSet;
            // 
            // покупателиTableAdapter
            // 
            this.покупателиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Сувенирный_магазин.сувенирный_магазинDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Виды_товараTableAdapter = null;
            this.tableAdapterManager.Наименование_товараTableAdapter = null;
            this.tableAdapterManager.ПокупателиTableAdapter = this.покупателиTableAdapter;
            this.tableAdapterManager.ПокупкиTableAdapter = null;
            this.tableAdapterManager.ПоставщикиTableAdapter = null;
            // 
            // покупателиBindingNavigator
            // 
            this.покупателиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.покупателиBindingNavigator.BindingSource = this.покупателиBindingSource;
            this.покупателиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.покупателиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.покупателиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.покупателиBindingNavigatorSaveItem});
            this.покупателиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.покупателиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.покупателиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.покупателиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.покупателиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.покупателиBindingNavigator.Name = "покупателиBindingNavigator";
            this.покупателиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.покупателиBindingNavigator.Size = new System.Drawing.Size(469, 25);
            this.покупателиBindingNavigator.TabIndex = 1;
            this.покупателиBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // покупателиBindingNavigatorSaveItem
            // 
            this.покупателиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.покупателиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("покупателиBindingNavigatorSaveItem.Image")));
            this.покупателиBindingNavigatorSaveItem.Name = "покупателиBindingNavigatorSaveItem";
            this.покупателиBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.покупателиBindingNavigatorSaveItem.Text = "Save Data";
            this.покупателиBindingNavigatorSaveItem.Click += new System.EventHandler(this.покупателиBindingNavigatorSaveItem_Click);
            // 
            // код_покупателяTextBox
            // 
            this.код_покупателяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.покупателиBindingSource, "Код_покупателя", true));
            this.код_покупателяTextBox.Location = new System.Drawing.Point(216, 92);
            this.код_покупателяTextBox.Name = "код_покупателяTextBox";
            this.код_покупателяTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_покупателяTextBox.TabIndex = 3;
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.покупателиBindingSource, "ФИО", true));
            this.фИОTextBox.Location = new System.Drawing.Point(216, 148);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(241, 20);
            this.фИОTextBox.TabIndex = 5;
            // 
            // возрастTextBox
            // 
            this.возрастTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.покупателиBindingSource, "Возраст", true));
            this.возрастTextBox.Location = new System.Drawing.Point(216, 197);
            this.возрастTextBox.Name = "возрастTextBox";
            this.возрастTextBox.Size = new System.Drawing.Size(100, 20);
            this.возрастTextBox.TabIndex = 7;
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.покупателиBindingSource, "Адрес", true));
            this.адресTextBox.Location = new System.Drawing.Point(216, 250);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(241, 20);
            this.адресTextBox.TabIndex = 9;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(216, 297);
            this.maskedTextBox1.Mask = "7 (000)-000-00-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 11;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 421);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(номер_телефонаLabel);
            this.Controls.Add(адресLabel);
            this.Controls.Add(this.адресTextBox);
            this.Controls.Add(возрастLabel);
            this.Controls.Add(this.возрастTextBox);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(this.фИОTextBox);
            this.Controls.Add(код_покупателяLabel);
            this.Controls.Add(this.код_покупателяTextBox);
            this.Controls.Add(this.покупателиBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.сувенирный_магазинDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.покупателиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.покупателиBindingNavigator)).EndInit();
            this.покупателиBindingNavigator.ResumeLayout(false);
            this.покупателиBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private сувенирный_магазинDataSet сувенирный_магазинDataSet;
        private System.Windows.Forms.BindingSource покупателиBindingSource;
        private сувенирный_магазинDataSetTableAdapters.ПокупателиTableAdapter покупателиTableAdapter;
        private сувенирный_магазинDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator покупателиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton покупателиBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_покупателяTextBox;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.TextBox возрастTextBox;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}