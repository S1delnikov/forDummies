namespace Сувенирный_магазин
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            System.Windows.Forms.Label код_поставщикаLabel;
            System.Windows.Forms.Label наименованиеLabel;
            System.Windows.Forms.Label срок_сотрудничестваLabel;
            System.Windows.Forms.Label контактыLabel;
            System.Windows.Forms.Label последняя_доставкаLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.сувенирный_магазинDataSet = new Сувенирный_магазин.сувенирный_магазинDataSet();
            this.поставщикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поставщикиTableAdapter = new Сувенирный_магазин.сувенирный_магазинDataSetTableAdapters.ПоставщикиTableAdapter();
            this.tableAdapterManager = new Сувенирный_магазин.сувенирный_магазинDataSetTableAdapters.TableAdapterManager();
            this.поставщикиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.поставщикиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_поставщикаTextBox = new System.Windows.Forms.TextBox();
            this.наименованиеTextBox = new System.Windows.Forms.TextBox();
            this.срок_сотрудничестваTextBox = new System.Windows.Forms.TextBox();
            this.контактыTextBox = new System.Windows.Forms.TextBox();
            this.последняя_доставкаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            код_поставщикаLabel = new System.Windows.Forms.Label();
            наименованиеLabel = new System.Windows.Forms.Label();
            срок_сотрудничестваLabel = new System.Windows.Forms.Label();
            контактыLabel = new System.Windows.Forms.Label();
            последняя_доставкаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.сувенирный_магазинDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingNavigator)).BeginInit();
            this.поставщикиBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(173, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поставщики";
            // 
            // сувенирный_магазинDataSet
            // 
            this.сувенирный_магазинDataSet.DataSetName = "сувенирный_магазинDataSet";
            this.сувенирный_магазинDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // поставщикиBindingSource
            // 
            this.поставщикиBindingSource.DataMember = "Поставщики";
            this.поставщикиBindingSource.DataSource = this.сувенирный_магазинDataSet;
            // 
            // поставщикиTableAdapter
            // 
            this.поставщикиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Сувенирный_магазин.сувенирный_магазинDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Виды_товараTableAdapter = null;
            this.tableAdapterManager.Наименование_товараTableAdapter = null;
            this.tableAdapterManager.ПокупателиTableAdapter = null;
            this.tableAdapterManager.ПокупкиTableAdapter = null;
            this.tableAdapterManager.ПоставщикиTableAdapter = this.поставщикиTableAdapter;
            // 
            // поставщикиBindingNavigator
            // 
            this.поставщикиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.поставщикиBindingNavigator.BindingSource = this.поставщикиBindingSource;
            this.поставщикиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.поставщикиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.поставщикиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.поставщикиBindingNavigatorSaveItem});
            this.поставщикиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.поставщикиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.поставщикиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.поставщикиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.поставщикиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.поставщикиBindingNavigator.Name = "поставщикиBindingNavigator";
            this.поставщикиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.поставщикиBindingNavigator.Size = new System.Drawing.Size(509, 25);
            this.поставщикиBindingNavigator.TabIndex = 1;
            this.поставщикиBindingNavigator.Text = "bindingNavigator1";
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
            // поставщикиBindingNavigatorSaveItem
            // 
            this.поставщикиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.поставщикиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("поставщикиBindingNavigatorSaveItem.Image")));
            this.поставщикиBindingNavigatorSaveItem.Name = "поставщикиBindingNavigatorSaveItem";
            this.поставщикиBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.поставщикиBindingNavigatorSaveItem.Text = "Save Data";
            this.поставщикиBindingNavigatorSaveItem.Click += new System.EventHandler(this.поставщикиBindingNavigatorSaveItem_Click);
            // 
            // код_поставщикаLabel
            // 
            код_поставщикаLabel.AutoSize = true;
            код_поставщикаLabel.Location = new System.Drawing.Point(93, 108);
            код_поставщикаLabel.Name = "код_поставщикаLabel";
            код_поставщикаLabel.Size = new System.Drawing.Size(94, 13);
            код_поставщикаLabel.TabIndex = 2;
            код_поставщикаLabel.Text = "Код поставщика:";
            // 
            // код_поставщикаTextBox
            // 
            this.код_поставщикаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикиBindingSource, "Код_поставщика", true));
            this.код_поставщикаTextBox.Location = new System.Drawing.Point(257, 101);
            this.код_поставщикаTextBox.Name = "код_поставщикаTextBox";
            this.код_поставщикаTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_поставщикаTextBox.TabIndex = 3;
            // 
            // наименованиеLabel
            // 
            наименованиеLabel.AutoSize = true;
            наименованиеLabel.Location = new System.Drawing.Point(93, 154);
            наименованиеLabel.Name = "наименованиеLabel";
            наименованиеLabel.Size = new System.Drawing.Size(86, 13);
            наименованиеLabel.TabIndex = 4;
            наименованиеLabel.Text = "Наименование:";
            // 
            // наименованиеTextBox
            // 
            this.наименованиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикиBindingSource, "Наименование", true));
            this.наименованиеTextBox.Location = new System.Drawing.Point(257, 147);
            this.наименованиеTextBox.Name = "наименованиеTextBox";
            this.наименованиеTextBox.Size = new System.Drawing.Size(100, 20);
            this.наименованиеTextBox.TabIndex = 5;
            // 
            // срок_сотрудничестваLabel
            // 
            срок_сотрудничестваLabel.AutoSize = true;
            срок_сотрудничестваLabel.Location = new System.Drawing.Point(93, 197);
            срок_сотрудничестваLabel.Name = "срок_сотрудничестваLabel";
            срок_сотрудничестваLabel.Size = new System.Drawing.Size(118, 13);
            срок_сотрудничестваLabel.TabIndex = 6;
            срок_сотрудничестваLabel.Text = "Срок сотрудничества:";
            // 
            // срок_сотрудничестваTextBox
            // 
            this.срок_сотрудничестваTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикиBindingSource, "Срок_сотрудничества", true));
            this.срок_сотрудничестваTextBox.Location = new System.Drawing.Point(257, 190);
            this.срок_сотрудничестваTextBox.Name = "срок_сотрудничестваTextBox";
            this.срок_сотрудничестваTextBox.Size = new System.Drawing.Size(100, 20);
            this.срок_сотрудничестваTextBox.TabIndex = 7;
            // 
            // контактыLabel
            // 
            контактыLabel.AutoSize = true;
            контактыLabel.Location = new System.Drawing.Point(93, 243);
            контактыLabel.Name = "контактыLabel";
            контактыLabel.Size = new System.Drawing.Size(59, 13);
            контактыLabel.TabIndex = 8;
            контактыLabel.Text = "Контакты:";
            // 
            // контактыTextBox
            // 
            this.контактыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.поставщикиBindingSource, "Контакты", true));
            this.контактыTextBox.Location = new System.Drawing.Point(257, 236);
            this.контактыTextBox.Name = "контактыTextBox";
            this.контактыTextBox.Size = new System.Drawing.Size(100, 20);
            this.контактыTextBox.TabIndex = 9;
            // 
            // последняя_доставкаLabel
            // 
            последняя_доставкаLabel.AutoSize = true;
            последняя_доставкаLabel.Location = new System.Drawing.Point(93, 287);
            последняя_доставкаLabel.Name = "последняя_доставкаLabel";
            последняя_доставкаLabel.Size = new System.Drawing.Size(116, 13);
            последняя_доставкаLabel.TabIndex = 10;
            последняя_доставкаLabel.Text = "Последняя доставка:";
            // 
            // последняя_доставкаDateTimePicker
            // 
            this.последняя_доставкаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.поставщикиBindingSource, "Последняя_доставка", true));
            this.последняя_доставкаDateTimePicker.Location = new System.Drawing.Point(257, 280);
            this.последняя_доставкаDateTimePicker.Name = "последняя_доставкаDateTimePicker";
            this.последняя_доставкаDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.последняя_доставкаDateTimePicker.TabIndex = 11;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 411);
            this.Controls.Add(последняя_доставкаLabel);
            this.Controls.Add(this.последняя_доставкаDateTimePicker);
            this.Controls.Add(контактыLabel);
            this.Controls.Add(this.контактыTextBox);
            this.Controls.Add(срок_сотрудничестваLabel);
            this.Controls.Add(this.срок_сотрудничестваTextBox);
            this.Controls.Add(наименованиеLabel);
            this.Controls.Add(this.наименованиеTextBox);
            this.Controls.Add(код_поставщикаLabel);
            this.Controls.Add(this.код_поставщикаTextBox);
            this.Controls.Add(this.поставщикиBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.сувенирный_магазинDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingNavigator)).EndInit();
            this.поставщикиBindingNavigator.ResumeLayout(false);
            this.поставщикиBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private сувенирный_магазинDataSet сувенирный_магазинDataSet;
        private System.Windows.Forms.BindingSource поставщикиBindingSource;
        private сувенирный_магазинDataSetTableAdapters.ПоставщикиTableAdapter поставщикиTableAdapter;
        private сувенирный_магазинDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator поставщикиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton поставщикиBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_поставщикаTextBox;
        private System.Windows.Forms.TextBox наименованиеTextBox;
        private System.Windows.Forms.TextBox срок_сотрудничестваTextBox;
        private System.Windows.Forms.TextBox контактыTextBox;
        private System.Windows.Forms.DateTimePicker последняя_доставкаDateTimePicker;
    }
}