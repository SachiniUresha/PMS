namespace PMS
{
    partial class Medicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medicine));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.medIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expireDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retailPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addMedicinetable1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pMSDataSet = new PMS.PMSDataSet();
            this.addMedicinetable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addMedicinetableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pMSDataSet1 = new PMS.PMSDataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Sup_ID = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Unit = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Expire_Date = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.Purchase_Price = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.Retail_Price = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.add_Medicine_table1TableAdapter = new PMS.PMSDataSetTableAdapters.Add_Medicine_table1TableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.pMSDataSet2 = new PMS.PMSDataSet2();
            this.add_Medicine_table1TableAdapter1 = new PMS.PMSDataSet2TableAdapters.Add_Medicine_table1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addMedicinetable1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addMedicinetable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addMedicinetableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMSDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 5;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(299, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Medicine";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 5;
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(585, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(218, 37);
            this.button2.TabIndex = 0;
            this.button2.Text = "Update Medicine";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 5;
            this.button3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(892, 238);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(197, 37);
            this.button3.TabIndex = 0;
            this.button3.Text = "Delete Medicine";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 5;
            this.button4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(42, 238);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(197, 37);
            this.button4.TabIndex = 0;
            this.button4.Text = "Search Medicine";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(340, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medIDDataGridViewTextBoxColumn,
            this.medNameDataGridViewTextBoxColumn,
            this.supIDDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.expireDateDataGridViewTextBoxColumn,
            this.retailPriceDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.addMedicinetable1BindingSource1;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(146, 292);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(845, 426);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // medIDDataGridViewTextBoxColumn
            // 
            this.medIDDataGridViewTextBoxColumn.DataPropertyName = "Med_ID";
            this.medIDDataGridViewTextBoxColumn.HeaderText = "Med_ID";
            this.medIDDataGridViewTextBoxColumn.Name = "medIDDataGridViewTextBoxColumn";
            // 
            // medNameDataGridViewTextBoxColumn
            // 
            this.medNameDataGridViewTextBoxColumn.DataPropertyName = "Med_Name";
            this.medNameDataGridViewTextBoxColumn.HeaderText = "Med_Name";
            this.medNameDataGridViewTextBoxColumn.Name = "medNameDataGridViewTextBoxColumn";
            // 
            // supIDDataGridViewTextBoxColumn
            // 
            this.supIDDataGridViewTextBoxColumn.DataPropertyName = "Sup_ID";
            this.supIDDataGridViewTextBoxColumn.HeaderText = "Sup_ID";
            this.supIDDataGridViewTextBoxColumn.Name = "supIDDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            // 
            // expireDateDataGridViewTextBoxColumn
            // 
            this.expireDateDataGridViewTextBoxColumn.DataPropertyName = "Expire Date";
            this.expireDateDataGridViewTextBoxColumn.HeaderText = "Expire Date";
            this.expireDateDataGridViewTextBoxColumn.Name = "expireDateDataGridViewTextBoxColumn";
            // 
            // retailPriceDataGridViewTextBoxColumn
            // 
            this.retailPriceDataGridViewTextBoxColumn.DataPropertyName = "Retail Price";
            this.retailPriceDataGridViewTextBoxColumn.HeaderText = "Retail Price";
            this.retailPriceDataGridViewTextBoxColumn.Name = "retailPriceDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // addMedicinetable1BindingSource1
            // 
            this.addMedicinetable1BindingSource1.DataMember = "Add_Medicine_table1";
            this.addMedicinetable1BindingSource1.DataSource = this.pMSDataSet;
            // 
            // pMSDataSet
            // 
            this.pMSDataSet.DataSetName = "PMSDataSet";
            this.pMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addMedicinetable1BindingSource
            // 
            this.addMedicinetable1BindingSource.DataMember = "Add_Medicine_table1";
            this.addMedicinetable1BindingSource.DataSource = this.pMSDataSet;
            // 
            // addMedicinetableBindingSource
            // 
            this.addMedicinetableBindingSource.DataMember = "Add_Medicine_table";
            this.addMedicinetableBindingSource.DataSource = this.pMSDataSet1;
            // 
            // pMSDataSet1
            // 
            this.pMSDataSet1.DataSetName = "PMSDataSet1";
            this.pMSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Med_ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lime;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(653, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Med_Name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(816, 24);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(363, 26);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Sup_ID
            // 
            this.Sup_ID.AutoSize = true;
            this.Sup_ID.BackColor = System.Drawing.Color.Lime;
            this.Sup_ID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Sup_ID.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sup_ID.ForeColor = System.Drawing.Color.Black;
            this.Sup_ID.Location = new System.Drawing.Point(22, 61);
            this.Sup_ID.Name = "Sup_ID";
            this.Sup_ID.Size = new System.Drawing.Size(71, 20);
            this.Sup_ID.TabIndex = 6;
            this.Sup_ID.Text = "Sup_ID";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(163, 62);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(340, 27);
            this.textBox3.TabIndex = 7;
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.BackColor = System.Drawing.Color.Lime;
            this.Quantity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Quantity.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.ForeColor = System.Drawing.Color.Black;
            this.Quantity.Location = new System.Drawing.Point(670, 61);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(74, 20);
            this.Quantity.TabIndex = 8;
            this.Quantity.Text = "Quantity";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(816, 61);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(363, 27);
            this.textBox4.TabIndex = 9;
            // 
            // Unit
            // 
            this.Unit.AutoSize = true;
            this.Unit.BackColor = System.Drawing.Color.Lime;
            this.Unit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Unit.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unit.ForeColor = System.Drawing.Color.Black;
            this.Unit.Location = new System.Drawing.Point(22, 100);
            this.Unit.Name = "Unit";
            this.Unit.Size = new System.Drawing.Size(44, 20);
            this.Unit.TabIndex = 10;
            this.Unit.Text = "Unit";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(163, 98);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(340, 27);
            this.textBox5.TabIndex = 11;
            // 
            // Expire_Date
            // 
            this.Expire_Date.AutoSize = true;
            this.Expire_Date.BackColor = System.Drawing.Color.Lime;
            this.Expire_Date.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Expire_Date.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expire_Date.ForeColor = System.Drawing.Color.Black;
            this.Expire_Date.Location = new System.Drawing.Point(645, 105);
            this.Expire_Date.Name = "Expire_Date";
            this.Expire_Date.Size = new System.Drawing.Size(100, 20);
            this.Expire_Date.TabIndex = 12;
            this.Expire_Date.Text = "Expire Date";
            this.Expire_Date.Click += new System.EventHandler(this.Expire_Date_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(816, 105);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(363, 25);
            this.dateTimePicker2.TabIndex = 13;
            // 
            // Purchase_Price
            // 
            this.Purchase_Price.AutoSize = true;
            this.Purchase_Price.BackColor = System.Drawing.Color.Lime;
            this.Purchase_Price.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Purchase_Price.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Purchase_Price.ForeColor = System.Drawing.Color.Black;
            this.Purchase_Price.Location = new System.Drawing.Point(22, 140);
            this.Purchase_Price.Name = "Purchase_Price";
            this.Purchase_Price.Size = new System.Drawing.Size(120, 20);
            this.Purchase_Price.TabIndex = 14;
            this.Purchase_Price.Text = "Purchase Price";
            this.Purchase_Price.Click += new System.EventHandler(this.Purchase_Price_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(163, 140);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(340, 27);
            this.textBox6.TabIndex = 15;
            // 
            // Retail_Price
            // 
            this.Retail_Price.AutoSize = true;
            this.Retail_Price.BackColor = System.Drawing.Color.Lime;
            this.Retail_Price.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Retail_Price.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Retail_Price.ForeColor = System.Drawing.Color.Black;
            this.Retail_Price.Location = new System.Drawing.Point(645, 147);
            this.Retail_Price.Name = "Retail_Price";
            this.Retail_Price.Size = new System.Drawing.Size(99, 20);
            this.Retail_Price.TabIndex = 16;
            this.Retail_Price.Text = "Retail Price";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(816, 147);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(363, 27);
            this.textBox8.TabIndex = 17;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.BackColor = System.Drawing.Color.Lime;
            this.Description.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Description.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.ForeColor = System.Drawing.Color.Black;
            this.Description.Location = new System.Drawing.Point(22, 182);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(96, 20);
            this.Description.TabIndex = 18;
            this.Description.Text = "Description";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(163, 183);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(340, 30);
            this.textBox7.TabIndex = 19;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // add_Medicine_table1TableAdapter
            // 
            this.add_Medicine_table1TableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.FlatAppearance.BorderSize = 5;
            this.button5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(1215, 682);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 36);
            this.button5.TabIndex = 20;
            this.button5.Text = "Back";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Red;
            this.button6.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(1215, 616);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(104, 36);
            this.button6.TabIndex = 21;
            this.button6.Text = "Clear";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // pMSDataSet2
            // 
            this.pMSDataSet2.DataSetName = "PMSDataSet2";
            this.pMSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // add_Medicine_table1TableAdapter1
            // 
            this.add_Medicine_table1TableAdapter1.ClearBeforeFill = true;
            // 
            // Medicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Lime;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.Retail_Price);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.Purchase_Price);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.Expire_Date);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.Unit);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Sup_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Medicine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medicine";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Medicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addMedicinetable1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addMedicinetable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addMedicinetableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMSDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Sup_ID;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label Unit;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label Expire_Date;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label Purchase_Price;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label Retail_Price;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.TextBox textBox7;
        private PMSDataSet1 pMSDataSet1;
        private System.Windows.Forms.BindingSource addMedicinetableBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn medIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expireDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn retailPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private PMSDataSet pMSDataSet;
        private System.Windows.Forms.BindingSource addMedicinetable1BindingSource;
        private PMSDataSetTableAdapters.Add_Medicine_table1TableAdapter add_Medicine_table1TableAdapter;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.BindingSource addMedicinetable1BindingSource1;
        private PMSDataSet2 pMSDataSet2;
        private PMSDataSet2TableAdapters.Add_Medicine_table1TableAdapter add_Medicine_table1TableAdapter1;
    }
}