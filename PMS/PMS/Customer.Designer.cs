namespace PMS
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addCustomertableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pMSDataSet1 = new PMS.PMSDataSet1();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.addCustomertableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addCustomertableBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.pMSDataSet = new PMS.PMSDataSet();
            this.addCustomertableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.add_Customer_tableTableAdapter = new PMS.PMSDataSet1TableAdapters.Add_Customer_tableTableAdapter();
            this.Gender = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Birthday = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Address = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Telephone = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Prescription = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.add_Customer_tableTableAdapter1 = new PMS.PMSDataSetTableAdapters.Add_Customer_tableTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.addCustomertableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addCustomertableBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addCustomertableBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addCustomertableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(35, 154);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Search Customer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(325, 150);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 40);
            this.button2.TabIndex = 0;
            this.button2.Text = "Update Customer";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(917, 154);
            this.button3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(215, 40);
            this.button3.TabIndex = 0;
            this.button3.Text = "Delete Customer";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(623, 150);
            this.button4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(215, 40);
            this.button4.TabIndex = 0;
            this.button4.Text = "Add Customer";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "First_Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Aqua;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(657, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last_Name";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addCustomertableBindingSource1, "First Name", true));
            this.textBox1.Location = new System.Drawing.Point(164, 22);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(342, 20);
            this.textBox1.TabIndex = 3;
            // 
            // addCustomertableBindingSource1
            // 
            this.addCustomertableBindingSource1.DataMember = "Add_Customer_table";
            this.addCustomertableBindingSource1.DataSource = this.pMSDataSet1;
            // 
            // pMSDataSet1
            // 
            this.pMSDataSet1.DataSetName = "PMSDataSet1";
            this.pMSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addCustomertableBindingSource2, "Last Name", true));
            this.textBox2.Location = new System.Drawing.Point(822, 19);
            this.textBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(361, 20);
            this.textBox2.TabIndex = 3;
            // 
            // addCustomertableBindingSource2
            // 
            this.addCustomertableBindingSource2.DataMember = "Add_Customer_table";
            this.addCustomertableBindingSource2.DataSource = this.pMSDataSet1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn,
            this.prescriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.addCustomertableBindingSource3;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(180, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(846, 512);
            this.dataGridView1.TabIndex = 4;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "E-mail";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.HeaderText = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            // 
            // prescriptionDataGridViewTextBoxColumn
            // 
            this.prescriptionDataGridViewTextBoxColumn.DataPropertyName = "Prescription";
            this.prescriptionDataGridViewTextBoxColumn.HeaderText = "Prescription";
            this.prescriptionDataGridViewTextBoxColumn.Name = "prescriptionDataGridViewTextBoxColumn";
            // 
            // addCustomertableBindingSource3
            // 
            this.addCustomertableBindingSource3.DataMember = "Add_Customer_table";
            this.addCustomertableBindingSource3.DataSource = this.pMSDataSet;
            // 
            // pMSDataSet
            // 
            this.pMSDataSet.DataSetName = "PMSDataSet";
            this.pMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addCustomertableBindingSource
            // 
            this.addCustomertableBindingSource.DataMember = "Add_Customer_table";
            this.addCustomertableBindingSource.DataSource = this.pMSDataSet1;
            // 
            // add_Customer_tableTableAdapter
            // 
            this.add_Customer_tableTableAdapter.ClearBeforeFill = true;
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.BackColor = System.Drawing.Color.Aqua;
            this.Gender.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Gender.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.Location = new System.Drawing.Point(35, 53);
            this.Gender.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(62, 20);
            this.Gender.TabIndex = 5;
            this.Gender.Text = "Gender";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox1.Location = new System.Drawing.Point(164, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(342, 26);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Birthday
            // 
            this.Birthday.AutoSize = true;
            this.Birthday.BackColor = System.Drawing.Color.Aqua;
            this.Birthday.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Birthday.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Birthday.Location = new System.Drawing.Point(675, 52);
            this.Birthday.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(76, 20);
            this.Birthday.TabIndex = 7;
            this.Birthday.Text = "Birthday";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(822, 53);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(361, 25);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.BackColor = System.Drawing.Color.Aqua;
            this.Address.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Address.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(35, 84);
            this.Address.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(68, 20);
            this.Address.TabIndex = 9;
            this.Address.Text = "Address";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(164, 81);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(342, 23);
            this.textBox3.TabIndex = 10;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.BackColor = System.Drawing.Color.Aqua;
            this.Email.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Email.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(690, 84);
            this.Email.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(61, 20);
            this.Email.TabIndex = 11;
            this.Email.Text = "E-mail";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(822, 91);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(361, 20);
            this.textBox4.TabIndex = 12;
            // 
            // Telephone
            // 
            this.Telephone.AutoSize = true;
            this.Telephone.BackColor = System.Drawing.Color.Aqua;
            this.Telephone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Telephone.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telephone.Location = new System.Drawing.Point(35, 116);
            this.Telephone.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.Telephone.Name = "Telephone";
            this.Telephone.Size = new System.Drawing.Size(85, 20);
            this.Telephone.TabIndex = 13;
            this.Telephone.Text = "Telephone";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(164, 113);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(342, 23);
            this.textBox5.TabIndex = 14;
            // 
            // Prescription
            // 
            this.Prescription.AutoSize = true;
            this.Prescription.BackColor = System.Drawing.Color.Aqua;
            this.Prescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Prescription.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prescription.Location = new System.Drawing.Point(650, 126);
            this.Prescription.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.Prescription.Name = "Prescription";
            this.Prescription.Size = new System.Drawing.Size(101, 20);
            this.Prescription.TabIndex = 15;
            this.Prescription.Text = "Prescription";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(822, 123);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(361, 24);
            this.textBox6.TabIndex = 16;
            this.textBox6.Text = "\r\n";
            // 
            // add_Customer_tableTableAdapter1
            // 
            this.add_Customer_tableTableAdapter1.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.FlatAppearance.BorderSize = 5;
            this.button5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(1210, 677);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 36);
            this.button5.TabIndex = 17;
            this.button5.Text = "Back";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Red;
            this.button6.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(1210, 607);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(104, 36);
            this.button6.TabIndex = 22;
            this.button6.Text = "Clear";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.Prescription);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.Telephone);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Birthday);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addCustomertableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addCustomertableBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addCustomertableBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addCustomertableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PMSDataSet1 pMSDataSet1;
        private System.Windows.Forms.BindingSource addCustomertableBindingSource;
        private PMSDataSet1TableAdapters.Add_Customer_tableTableAdapter add_Customer_tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource addCustomertableBindingSource1;
        private System.Windows.Forms.BindingSource addCustomertableBindingSource2;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Birthday;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label Telephone;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label Prescription;
        private System.Windows.Forms.TextBox textBox6;
        private PMSDataSet pMSDataSet;
        private System.Windows.Forms.BindingSource addCustomertableBindingSource3;
        private PMSDataSetTableAdapters.Add_Customer_tableTableAdapter add_Customer_tableTableAdapter1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}