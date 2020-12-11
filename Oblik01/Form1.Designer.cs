
namespace Oblik01
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle73 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle74 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle75 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle76 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle77 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle78 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle79 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle80 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle81 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.workerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountDataSet = new Oblik01.AccountDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDAccountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDWorkerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aInvNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.workerTableAdapter = new Oblik01.AccountDataSetTableAdapters.WorkerTableAdapter();
            this.accountTableAdapter = new Oblik01.AccountDataSetTableAdapters.AccountTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDWorkerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wPositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.workerToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // workerToolStripMenuItem
            // 
            this.workerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.editToolStripMenuItem});
            this.workerToolStripMenuItem.Name = "workerToolStripMenuItem";
            this.workerToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.workerToolStripMenuItem.Text = "Worker";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addToolStripMenuItem.Text = "Add...";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "Edit...";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.deleteToolStripMenuItem1,
            this.editToolStripMenuItem1});
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.addToolStripMenuItem1.Text = "Add...";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem1.Text = "Edit...";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.editToolStripMenuItem1_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Worker";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Account";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(242, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Filter";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(283, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // workerBindingSource
            // 
            this.workerBindingSource.DataMember = "Worker";
            this.workerBindingSource.DataSource = this.accountDataSetBindingSource;
            // 
            // accountDataSetBindingSource
            // 
            this.accountDataSetBindingSource.DataSource = this.accountDataSet;
            this.accountDataSetBindingSource.Position = 0;
            // 
            // accountDataSet
            // 
            this.accountDataSet.DataSetName = "AccountDataSet";
            this.accountDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            dataGridViewCellStyle73.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle73.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle73.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle73.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle73.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle73.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle73.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle73;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDAccountDataGridViewTextBoxColumn,
            this.iDWorkerDataGridViewTextBoxColumn1,
            this.aNumDataGridViewTextBoxColumn,
            this.aDateDataGridViewTextBoxColumn,
            this.aInvNumDataGridViewTextBoxColumn,
            this.aCountDataGridViewTextBoxColumn,
            this.aPriceDataGridViewTextBoxColumn,
            this.Sum});
            this.dataGridView2.DataSource = this.accountBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 262);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(548, 217);
            this.dataGridView2.TabIndex = 6;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // iDAccountDataGridViewTextBoxColumn
            // 
            this.iDAccountDataGridViewTextBoxColumn.DataPropertyName = "ID_Account";
            dataGridViewCellStyle74.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.iDAccountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle74;
            this.iDAccountDataGridViewTextBoxColumn.HeaderText = "ID_Account";
            this.iDAccountDataGridViewTextBoxColumn.Name = "iDAccountDataGridViewTextBoxColumn";
            this.iDAccountDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDAccountDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDWorkerDataGridViewTextBoxColumn1
            // 
            this.iDWorkerDataGridViewTextBoxColumn1.DataPropertyName = "ID_Worker";
            this.iDWorkerDataGridViewTextBoxColumn1.HeaderText = "ID_Worker";
            this.iDWorkerDataGridViewTextBoxColumn1.Name = "iDWorkerDataGridViewTextBoxColumn1";
            this.iDWorkerDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDWorkerDataGridViewTextBoxColumn1.Visible = false;
            // 
            // aNumDataGridViewTextBoxColumn
            // 
            this.aNumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.aNumDataGridViewTextBoxColumn.DataPropertyName = "ANum";
            dataGridViewCellStyle75.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.aNumDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle75;
            this.aNumDataGridViewTextBoxColumn.HeaderText = "Number";
            this.aNumDataGridViewTextBoxColumn.Name = "aNumDataGridViewTextBoxColumn";
            this.aNumDataGridViewTextBoxColumn.ReadOnly = true;
            this.aNumDataGridViewTextBoxColumn.Width = 75;
            // 
            // aDateDataGridViewTextBoxColumn
            // 
            this.aDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.aDateDataGridViewTextBoxColumn.DataPropertyName = "ADate";
            dataGridViewCellStyle76.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.aDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle76;
            this.aDateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.aDateDataGridViewTextBoxColumn.Name = "aDateDataGridViewTextBoxColumn";
            this.aDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.aDateDataGridViewTextBoxColumn.Width = 59;
            // 
            // aInvNumDataGridViewTextBoxColumn
            // 
            this.aInvNumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.aInvNumDataGridViewTextBoxColumn.DataPropertyName = "AInvNum";
            dataGridViewCellStyle77.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.aInvNumDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle77;
            this.aInvNumDataGridViewTextBoxColumn.HeaderText = "Inv. Number";
            this.aInvNumDataGridViewTextBoxColumn.Name = "aInvNumDataGridViewTextBoxColumn";
            this.aInvNumDataGridViewTextBoxColumn.ReadOnly = true;
            this.aInvNumDataGridViewTextBoxColumn.Width = 101;
            // 
            // aCountDataGridViewTextBoxColumn
            // 
            this.aCountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.aCountDataGridViewTextBoxColumn.DataPropertyName = "ACount";
            dataGridViewCellStyle78.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.aCountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle78;
            this.aCountDataGridViewTextBoxColumn.HeaderText = "Count";
            this.aCountDataGridViewTextBoxColumn.Name = "aCountDataGridViewTextBoxColumn";
            this.aCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.aCountDataGridViewTextBoxColumn.Width = 65;
            // 
            // aPriceDataGridViewTextBoxColumn
            // 
            this.aPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.aPriceDataGridViewTextBoxColumn.DataPropertyName = "APrice";
            dataGridViewCellStyle79.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.aPriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle79;
            this.aPriceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.aPriceDataGridViewTextBoxColumn.Name = "aPriceDataGridViewTextBoxColumn";
            this.aPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.aPriceDataGridViewTextBoxColumn.Width = 61;
            // 
            // Sum
            // 
            this.Sum.DataPropertyName = "Sum";
            dataGridViewCellStyle80.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle80.Format = "N2";
            dataGridViewCellStyle80.NullValue = null;
            this.Sum.DefaultCellStyle = dataGridViewCellStyle80;
            this.Sum.HeaderText = "Sum";
            this.Sum.Name = "Sum";
            this.Sum.ReadOnly = true;
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataMember = "Account";
            this.accountBindingSource.DataSource = this.accountDataSetBindingSource;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(455, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 20);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(455, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 20);
            this.button2.TabIndex = 8;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(455, 123);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 20);
            this.button3.TabIndex = 9;
            this.button3.Text = "Edit...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(625, 314);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 20);
            this.button4.TabIndex = 12;
            this.button4.Text = "Edit record…";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.editToolStripMenuItem1_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(625, 288);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 20);
            this.button5.TabIndex = 11;
            this.button5.Text = "Delete record";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(625, 262);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(105, 20);
            this.button6.TabIndex = 10;
            this.button6.Text = "Add record…";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
            // 
            // workerTableAdapter
            // 
            this.workerTableAdapter.ClearBeforeFill = true;
            // 
            // accountTableAdapter
            // 
            this.accountTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = global::Oblik01.Properties.Settings.Default.Flase;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle81.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle81.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle81.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle81.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle81.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle81.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle81.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle81;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDWorkerDataGridViewTextBoxColumn,
            this.wNameDataGridViewTextBoxColumn,
            this.wPositionDataGridViewTextBoxColumn});
            this.dataGridView1.DataBindings.Add(new System.Windows.Forms.Binding("MultiSelect", global::Oblik01.Properties.Settings.Default, "MultiSelect", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dataGridView1.DataBindings.Add(new System.Windows.Forms.Binding("ReadOnly", global::Oblik01.Properties.Settings.Default, "True", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dataGridView1.DataBindings.Add(new System.Windows.Forms.Binding("AllowUserToDeleteRows", global::Oblik01.Properties.Settings.Default, "Flase", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dataGridView1.DataSource = this.workerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 72);
            this.dataGridView1.MultiSelect = global::Oblik01.Properties.Settings.Default.MultiSelect;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = global::Oblik01.Properties.Settings.Default.True;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(340, 150);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // iDWorkerDataGridViewTextBoxColumn
            // 
            this.iDWorkerDataGridViewTextBoxColumn.DataPropertyName = "ID_Worker";
            this.iDWorkerDataGridViewTextBoxColumn.HeaderText = "ID_Worker";
            this.iDWorkerDataGridViewTextBoxColumn.Name = "iDWorkerDataGridViewTextBoxColumn";
            this.iDWorkerDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDWorkerDataGridViewTextBoxColumn.Visible = false;
            // 
            // wNameDataGridViewTextBoxColumn
            // 
            this.wNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.wNameDataGridViewTextBoxColumn.DataPropertyName = "WName";
            this.wNameDataGridViewTextBoxColumn.HeaderText = "Name of worker";
            this.wNameDataGridViewTextBoxColumn.Name = "wNameDataGridViewTextBoxColumn";
            this.wNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.wNameDataGridViewTextBoxColumn.Width = 111;
            // 
            // wPositionDataGridViewTextBoxColumn
            // 
            this.wPositionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.wPositionDataGridViewTextBoxColumn.DataPropertyName = "WPosition";
            this.wPositionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.wPositionDataGridViewTextBoxColumn.Name = "wPositionDataGridViewTextBoxColumn";
            this.wPositionDataGridViewTextBoxColumn.ReadOnly = true;
            this.wPositionDataGridViewTextBoxColumn.Width = 77;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Inventory accounting";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem workerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.BindingSource accountDataSetBindingSource;
        private AccountDataSet accountDataSet;
        private System.Windows.Forms.BindingSource workerBindingSource;
        private AccountDataSetTableAdapters.WorkerTableAdapter workerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDWorkerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wPositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wSexDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private AccountDataSetTableAdapters.AccountTableAdapter accountTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aObjNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAccountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDWorkerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aInvNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sum;
    }
}

