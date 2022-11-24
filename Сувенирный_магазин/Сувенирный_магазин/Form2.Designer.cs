namespace Сувенирный_магазин
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.Label код_видаLabel;
            System.Windows.Forms.Label вид_товараLabel;
            System.Windows.Forms.Label код_поставщикаLabel;
            System.Windows.Forms.Label материалLabel;
            System.Windows.Forms.Label код_наименованияLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.сувенирный_магазинDataSet = new Сувенирный_магазин.сувенирный_магазинDataSet();
            this.виды_товараBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.виды_товараTableAdapter = new Сувенирный_магазин.сувенирный_магазинDataSetTableAdapters.Виды_товараTableAdapter();
            this.tableAdapterManager = new Сувенирный_магазин.сувенирный_магазинDataSetTableAdapters.TableAdapterManager();
            this.виды_товараBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.виды_товараBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_видаTextBox = new System.Windows.Forms.TextBox();
            this.вид_товараTextBox = new System.Windows.Forms.TextBox();
            this.код_поставщикаTextBox = new System.Windows.Forms.TextBox();
            this.материалTextBox = new System.Windows.Forms.TextBox();
            this.код_наименованияTextBox = new System.Windows.Forms.TextBox();
            код_видаLabel = new System.Windows.Forms.Label();
            вид_товараLabel = new System.Windows.Forms.Label();
            код_поставщикаLabel = new System.Windows.Forms.Label();
            материалLabel = new System.Windows.Forms.Label();
            код_наименованияLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.сувенирный_магазинDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.виды_товараBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.виды_товараBindingNavigator)).BeginInit();
            this.виды_товараBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(164, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Виды_товара";
            // 
            // сувенирный_магазинDataSet
            // 
            this.сувенирный_магазинDataSet.DataSetName = "сувенирный_магазинDataSet";
            this.сувенирный_магазинDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // виды_товараBindingSource
            // 
            this.виды_товараBindingSource.DataMember = "Виды_товара";
            this.виды_товараBindingSource.DataSource = this.сувенирный_магазинDataSet;
            // 
            // виды_товараTableAdapter
            // 
            this.виды_товараTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Сувенирный_магазин.сувенирный_магазинDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Виды_товараTableAdapter = this.виды_товараTableAdapter;
            this.tableAdapterManager.Наименование_товараTableAdapter = null;
            this.tableAdapterManager.ПокупателиTableAdapter = null;
            this.tableAdapterManager.ПокупкиTableAdapter = null;
            this.tableAdapterManager.ПоставщикиTableAdapter = null;
            // 
            // виды_товараBindingNavigator
            // 
            this.виды_товараBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.виды_товараBindingNavigator.BindingSource = this.виды_товараBindingSource;
            this.виды_товараBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.виды_товараBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.виды_товараBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.виды_товараBindingNavigatorSaveItem});
            this.виды_товараBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.виды_товараBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.виды_товараBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.виды_товараBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.виды_товараBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.виды_товараBindingNavigator.Name = "виды_товараBindingNavigator";
            this.виды_товараBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.виды_товараBindingNavigator.Size = new System.Drawing.Size(464, 25);
            this.виды_товараBindingNavigator.TabIndex = 1;
            this.виды_товараBindingNavigator.Text = "bindingNavigator1";
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
            // виды_товараBindingNavigatorSaveItem
            // 
            this.виды_товараBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.виды_товараBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("виды_товараBindingNavigatorSaveItem.Image")));
            this.виды_товараBindingNavigatorSaveItem.Name = "виды_товараBindingNavigatorSaveItem";
            this.виды_товараBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.виды_товараBindingNavigatorSaveItem.Text = "Save Data";
            this.виды_товараBindingNavigatorSaveItem.Click += new System.EventHandler(this.виды_товараBindingNavigatorSaveItem_Click);
            // 
            // код_видаLabel
            // 
            код_видаLabel.AutoSize = true;
            код_видаLabel.Location = new System.Drawing.Point(101, 95);
            код_видаLabel.Name = "код_видаLabel";
            код_видаLabel.Size = new System.Drawing.Size(56, 13);
            код_видаLabel.TabIndex = 2;
            код_видаLabel.Text = "Код вида:";
            // 
            // код_видаTextBox
            // 
            this.код_видаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.виды_товараBindingSource, "Код_вида", true));
            this.код_видаTextBox.Location = new System.Drawing.Point(233, 92);
            this.код_видаTextBox.Name = "код_видаTextBox";
            this.код_видаTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_видаTextBox.TabIndex = 3;
            // 
            // вид_товараLabel
            // 
            вид_товараLabel.AutoSize = true;
            вид_товараLabel.Location = new System.Drawing.Point(101, 133);
            вид_товараLabel.Name = "вид_товараLabel";
            вид_товараLabel.Size = new System.Drawing.Size(67, 13);
            вид_товараLabel.TabIndex = 4;
            вид_товараLabel.Text = "Вид товара:";
            // 
            // вид_товараTextBox
            // 
            this.вид_товараTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.виды_товараBindingSource, "Вид_товара", true));
            this.вид_товараTextBox.Location = new System.Drawing.Point(233, 126);
            this.вид_товараTextBox.Name = "вид_товараTextBox";
            this.вид_товараTextBox.Size = new System.Drawing.Size(100, 20);
            this.вид_товараTextBox.TabIndex = 5;
            // 
            // код_поставщикаLabel
            // 
            код_поставщикаLabel.AutoSize = true;
            код_поставщикаLabel.Location = new System.Drawing.Point(101, 181);
            код_поставщикаLabel.Name = "код_поставщикаLabel";
            код_поставщикаLabel.Size = new System.Drawing.Size(94, 13);
            код_поставщикаLabel.TabIndex = 6;
            код_поставщикаLabel.Text = "Код поставщика:";
            // 
            // код_поставщикаTextBox
            // 
            this.код_поставщикаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.виды_товараBindingSource, "Код_поставщика", true));
            this.код_поставщикаTextBox.Location = new System.Drawing.Point(233, 174);
            this.код_поставщикаTextBox.Name = "код_поставщикаTextBox";
            this.код_поставщикаTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_поставщикаTextBox.TabIndex = 7;
            // 
            // материалLabel
            // 
            материалLabel.AutoSize = true;
            материалLabel.Location = new System.Drawing.Point(101, 220);
            материалLabel.Name = "материалLabel";
            материалLabel.Size = new System.Drawing.Size(60, 13);
            материалLabel.TabIndex = 8;
            материалLabel.Text = "Материал:";
            // 
            // материалTextBox
            // 
            this.материалTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.виды_товараBindingSource, "Материал", true));
            this.материалTextBox.Location = new System.Drawing.Point(233, 213);
            this.материалTextBox.Name = "материалTextBox";
            this.материалTextBox.Size = new System.Drawing.Size(100, 20);
            this.материалTextBox.TabIndex = 9;
            // 
            // код_наименованияLabel
            // 
            код_наименованияLabel.AutoSize = true;
            код_наименованияLabel.Location = new System.Drawing.Point(101, 259);
            код_наименованияLabel.Name = "код_наименованияLabel";
            код_наименованияLabel.Size = new System.Drawing.Size(106, 13);
            код_наименованияLabel.TabIndex = 10;
            код_наименованияLabel.Text = "Код наименования:";
            // 
            // код_наименованияTextBox
            // 
            this.код_наименованияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.виды_товараBindingSource, "Код_наименования", true));
            this.код_наименованияTextBox.Location = new System.Drawing.Point(233, 252);
            this.код_наименованияTextBox.Name = "код_наименованияTextBox";
            this.код_наименованияTextBox.Size = new System.Drawing.Size(100, 20);
            this.код_наименованияTextBox.TabIndex = 11;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 383);
            this.Controls.Add(код_наименованияLabel);
            this.Controls.Add(this.код_наименованияTextBox);
            this.Controls.Add(материалLabel);
            this.Controls.Add(this.материалTextBox);
            this.Controls.Add(код_поставщикаLabel);
            this.Controls.Add(this.код_поставщикаTextBox);
            this.Controls.Add(вид_товараLabel);
            this.Controls.Add(this.вид_товараTextBox);
            this.Controls.Add(код_видаLabel);
            this.Controls.Add(this.код_видаTextBox);
            this.Controls.Add(this.виды_товараBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.сувенирный_магазинDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.виды_товараBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.виды_товараBindingNavigator)).EndInit();
            this.виды_товараBindingNavigator.ResumeLayout(false);
            this.виды_товараBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private сувенирный_магазинDataSet сувенирный_магазинDataSet;
        private System.Windows.Forms.BindingSource виды_товараBindingSource;
        private сувенирный_магазинDataSetTableAdapters.Виды_товараTableAdapter виды_товараTableAdapter;
        private сувенирный_магазинDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator виды_товараBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton виды_товараBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox код_видаTextBox;
        private System.Windows.Forms.TextBox вид_товараTextBox;
        private System.Windows.Forms.TextBox код_поставщикаTextBox;
        private System.Windows.Forms.TextBox материалTextBox;
        private System.Windows.Forms.TextBox код_наименованияTextBox;
    }
}