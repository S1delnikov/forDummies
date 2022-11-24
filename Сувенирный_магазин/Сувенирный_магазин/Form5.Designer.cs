namespace Сувенирный_магазин
{
    partial class Form5
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
            System.Windows.Forms.Label цена_за_единицуLabel;
            System.Windows.Forms.Label количествоLabel;
            System.Windows.Forms.Label дата_заказаLabel;
            System.Windows.Forms.Label код_покупателяLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            System.Windows.Forms.Label код_покупкиLabel;
            System.Windows.Forms.Label код_наименвоания_товараLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.сувенирный_магазинDataSet = new Сувенирный_магазин.сувенирный_магазинDataSet();
            this.покупкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.покупкиTableAdapter = new Сувенирный_магазин.сувенирный_магазинDataSetTableAdapters.ПокупкиTableAdapter();
            this.tableAdapterManager = new Сувенирный_магазин.сувенирный_магазинDataSetTableAdapters.TableAdapterManager();
            this.покупкиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.покупкиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.цена_за_единицуTextBox = new System.Windows.Forms.TextBox();
            this.количествоTextBox = new System.Windows.Forms.TextBox();
            this.дата_заказаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.код_покупателяTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.код_покупкиTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.код_наименвоания_товараTextBox = new System.Windows.Forms.TextBox();
            цена_за_единицуLabel = new System.Windows.Forms.Label();
            количествоLabel = new System.Windows.Forms.Label();
            дата_заказаLabel = new System.Windows.Forms.Label();
            код_покупателяLabel = new System.Windows.Forms.Label();
            код_покупкиLabel = new System.Windows.Forms.Label();
            код_наименвоания_товараLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.сувенирный_магазинDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.покупкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.покупкиBindingNavigator)).BeginInit();
            this.покупкиBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // цена_за_единицуLabel
            // 
            цена_за_единицуLabel.AutoSize = true;
            цена_за_единицуLabel.Location = new System.Drawing.Point(112, 197);
            цена_за_единицуLabel.Name = "цена_за_единицуLabel";
            цена_за_единицуLabel.Size = new System.Drawing.Size(95, 13);
            цена_за_единицуLabel.TabIndex = 6;
            цена_за_единицуLabel.Text = "Цена за единицу:";
            // 
            // количествоLabel
            // 
            количествоLabel.AutoSize = true;
            количествоLabel.Location = new System.Drawing.Point(112, 263);
            количествоLabel.Name = "количествоLabel";
            количествоLabel.Size = new System.Drawing.Size(69, 13);
            количествоLabel.TabIndex = 8;
            количествоLabel.Text = "Количество:";
            // 
            // дата_заказаLabel
            // 
            дата_заказаLabel.AutoSize = true;
            дата_заказаLabel.Location = new System.Drawing.Point(112, 305);
            дата_заказаLabel.Name = "дата_заказаLabel";
            дата_заказаLabel.Size = new System.Drawing.Size(75, 13);
            дата_заказаLabel.TabIndex = 10;
            дата_заказаLabel.Text = "Дата заказа:";
            // 
            // код_покупателяLabel
            // 
            код_покупателяLabel.AutoSize = true;
            код_покупателяLabel.Location = new System.Drawing.Point(112, 346);
            код_покупателяLabel.Name = "код_покупателяLabel";
            код_покупателяLabel.Size = new System.Drawing.Size(90, 13);
            код_покупателяLabel.TabIndex = 12;
            код_покупателяLabel.Text = "Код покупателя:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(195, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Покупки";
            // 
            // сувенирный_магазинDataSet
            // 
            this.сувенирный_магазинDataSet.DataSetName = "сувенирный_магазинDataSet";
            this.сувенирный_магазинDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // покупкиBindingSource
            // 
            this.покупкиBindingSource.DataMember = "Покупки";
            this.покупкиBindingSource.DataSource = this.сувенирный_магазинDataSet;
            // 
            // покупкиTableAdapter
            // 
            this.покупкиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Сувенирный_магазин.сувенирный_магазинDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Виды_товараTableAdapter = null;
            this.tableAdapterManager.Наименование_товараTableAdapter = null;
            this.tableAdapterManager.ПокупателиTableAdapter = null;
            this.tableAdapterManager.ПокупкиTableAdapter = this.покупкиTableAdapter;
            this.tableAdapterManager.ПоставщикиTableAdapter = null;
            // 
            // покупкиBindingNavigator
            // 
            this.покупкиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.покупкиBindingNavigator.BindingSource = this.покупкиBindingSource;
            this.покупкиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.покупкиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.покупкиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.покупкиBindingNavigatorSaveItem});
            this.покупкиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.покупкиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.покупкиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.покупкиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.покупкиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.покупкиBindingNavigator.Name = "покупкиBindingNavigator";
            this.покупкиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.покупкиBindingNavigator.Size = new System.Drawing.Size(491, 25);
            this.покупкиBindingNavigator.TabIndex = 1;
            this.покупкиBindingNavigator.Text = "bindingNavigator1";
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
            // покупкиBindingNavigatorSaveItem
            // 
            this.покупкиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.покупкиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("покупкиBindingNavigatorSaveItem.Image")));
            this.покупкиBindingNavigatorSaveItem.Name = "покупкиBindingNavigatorSaveItem";
            this.покупкиBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.покупкиBindingNavigatorSaveItem.Text = "Save Data";
            this.покупкиBindingNavigatorSaveItem.Click += new System.EventHandler(this.покупкиBindingNavigatorSaveItem_Click);
            // 
            // цена_за_единицуTextBox
            // 
            this.цена_за_единицуTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.покупкиBindingSource, "Цена_за_единицу", true));
            this.цена_за_единицуTextBox.Location = new System.Drawing.Point(271, 190);
            this.цена_за_единицуTextBox.Name = "цена_за_единицуTextBox";
            this.цена_за_единицуTextBox.Size = new System.Drawing.Size(100, 20);
            this.цена_за_единицуTextBox.TabIndex = 7;
            // 
            // количествоTextBox
            // 
            this.количествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.покупкиBindingSource, "Количество", true));
            this.количествоTextBox.Location = new System.Drawing.Point(271, 256);
            this.количествоTextBox.Name = "количествоTextBox";
            this.количествоTextBox.Size = new System.Drawing.Size(100, 20);
            this.количествоTextBox.TabIndex = 9;
            // 
            // дата_заказаDateTimePicker
            // 
            this.дата_заказаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.покупкиBindingSource, "Дата_заказа", true));
            this.дата_заказаDateTimePicker.Location = new System.Drawing.Point(271, 298);
            this.дата_заказаDateTimePicker.Name = "дата_заказаDateTimePicker";
            this.дата_заказаDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_заказаDateTimePicker.TabIndex = 11;
            // 
            // код_покупателяTextBox
            // 
            this.код_покупателяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.покупкиBindingSource, "Код_покупателя", true));
            this.код_покупателяTextBox.Location = new System.Drawing.Point(271, 339);
            this.код_покупателяTextBox.Name = "код_покупателяTextBox";
            this.код_покупателяTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_покупателяTextBox.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(203, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(327, 388);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(80, 436);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Последняя";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(203, 436);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 23);
            this.button5.TabIndex = 18;
            this.button5.Text = "Следующая";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(327, 436);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 19;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(203, 482);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 20;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Цена с НДС";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(271, 219);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 23;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(396, 219);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 20);
            this.button8.TabIndex = 24;
            this.button8.Text = "Итог";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // код_покупкиTextBox
            // 
            this.код_покупкиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.покупкиBindingSource, "Код_покупки", true));
            this.код_покупкиTextBox.Location = new System.Drawing.Point(271, 98);
            this.код_покупкиTextBox.Name = "код_покупкиTextBox";
            this.код_покупкиTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_покупкиTextBox.TabIndex = 3;
            // 
            // код_покупкиLabel
            // 
            код_покупкиLabel.AutoSize = true;
            код_покупкиLabel.Location = new System.Drawing.Point(112, 105);
            код_покупкиLabel.Name = "код_покупкиLabel";
            код_покупкиLabel.Size = new System.Drawing.Size(73, 13);
            код_покупкиLabel.TabIndex = 2;
            код_покупкиLabel.Text = "Код покупки:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // код_наименвоания_товараLabel
            // 
            код_наименвоания_товараLabel.AutoSize = true;
            код_наименвоания_товараLabel.Location = new System.Drawing.Point(121, 148);
            код_наименвоания_товараLabel.Name = "код_наименвоания_товараLabel";
            код_наименвоания_товараLabel.Size = new System.Drawing.Size(144, 13);
            код_наименвоания_товараLabel.TabIndex = 26;
            код_наименвоания_товараLabel.Text = "Код наименвоания товара:";
            // 
            // код_наименвоания_товараTextBox
            // 
            this.код_наименвоания_товараTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.покупкиBindingSource, "Код_наименвоания_товара", true));
            this.код_наименвоания_товараTextBox.Location = new System.Drawing.Point(271, 145);
            this.код_наименвоания_товараTextBox.Name = "код_наименвоания_товараTextBox";
            this.код_наименвоания_товараTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_наименвоания_товараTextBox.TabIndex = 27;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 536);
            this.Controls.Add(код_наименвоания_товараLabel);
            this.Controls.Add(this.код_наименвоания_товараTextBox);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(код_покупателяLabel);
            this.Controls.Add(this.код_покупателяTextBox);
            this.Controls.Add(дата_заказаLabel);
            this.Controls.Add(this.дата_заказаDateTimePicker);
            this.Controls.Add(количествоLabel);
            this.Controls.Add(this.количествоTextBox);
            this.Controls.Add(цена_за_единицуLabel);
            this.Controls.Add(this.цена_за_единицуTextBox);
            this.Controls.Add(код_покупкиLabel);
            this.Controls.Add(this.код_покупкиTextBox);
            this.Controls.Add(this.покупкиBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.сувенирный_магазинDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.покупкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.покупкиBindingNavigator)).EndInit();
            this.покупкиBindingNavigator.ResumeLayout(false);
            this.покупкиBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private сувенирный_магазинDataSet сувенирный_магазинDataSet;
        private System.Windows.Forms.BindingSource покупкиBindingSource;
        private сувенирный_магазинDataSetTableAdapters.ПокупкиTableAdapter покупкиTableAdapter;
        private сувенирный_магазинDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator покупкиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton покупкиBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox цена_за_единицуTextBox;
        private System.Windows.Forms.TextBox количествоTextBox;
        private System.Windows.Forms.DateTimePicker дата_заказаDateTimePicker;
        private System.Windows.Forms.TextBox код_покупателяTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox код_покупкиTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox код_наименвоания_товараTextBox;
    }
}