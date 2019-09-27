namespace A1Rentals
{
    partial class frmReports
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
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.grpFilters = new System.Windows.Forms.GroupBox();
            this.btnGetOverdue = new System.Windows.Forms.Button();
            this.Label13 = new System.Windows.Forms.Label();
            this.cmbEquipment = new System.Windows.Forms.ComboBox();
            this.txtDaysOver = new System.Windows.Forms.TextBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.Label9 = new System.Windows.Forms.Label();
            this.cmbCompanyName = new System.Windows.Forms.ComboBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.dgvOverdue = new System.Windows.Forms.DataGridView();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGetCustomer = new System.Windows.Forms.Button();
            this.txtCustRevenue = new System.Windows.Forms.TextBox();
            this.dtpCustEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpCustStart = new System.Windows.Forms.DateTimePicker();
            this.Label1 = new System.Windows.Forms.Label();
            this.cmbCoNameHST = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGetEquipment = new System.Windows.Forms.Button();
            this.txtEquipRevenue = new System.Windows.Forms.TextBox();
            this.dtpEquipEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpEquipStart = new System.Windows.Forms.DateTimePicker();
            this.Label5 = new System.Windows.Forms.Label();
            this.cmbEquipHST = new System.Windows.Forms.ComboBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.dgvEquipment = new System.Windows.Forms.DataGridView();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.grpFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverdue)).BeginInit();
            this.TabPage2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.TabPage3.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipment)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Location = new System.Drawing.Point(2, 2);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(934, 468);
            this.TabControl1.TabIndex = 1;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.grpFilters);
            this.TabPage1.Controls.Add(this.dgvOverdue);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(926, 442);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Rentals Due";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // grpFilters
            // 
            this.grpFilters.Controls.Add(this.btnGetOverdue);
            this.grpFilters.Controls.Add(this.Label13);
            this.grpFilters.Controls.Add(this.cmbEquipment);
            this.grpFilters.Controls.Add(this.txtDaysOver);
            this.grpFilters.Controls.Add(this.dtpEnd);
            this.grpFilters.Controls.Add(this.dtpStart);
            this.grpFilters.Controls.Add(this.Label9);
            this.grpFilters.Controls.Add(this.cmbCompanyName);
            this.grpFilters.Controls.Add(this.Label10);
            this.grpFilters.Controls.Add(this.Label11);
            this.grpFilters.Controls.Add(this.Label12);
            this.grpFilters.Location = new System.Drawing.Point(7, 6);
            this.grpFilters.Name = "grpFilters";
            this.grpFilters.Size = new System.Drawing.Size(911, 86);
            this.grpFilters.TabIndex = 3;
            this.grpFilters.TabStop = false;
            this.grpFilters.Text = "Overdue Search Filters";
            // 
            // btnGetOverdue
            // 
            this.btnGetOverdue.Location = new System.Drawing.Point(739, 32);
            this.btnGetOverdue.Name = "btnGetOverdue";
            this.btnGetOverdue.Size = new System.Drawing.Size(102, 23);
            this.btnGetOverdue.TabIndex = 13;
            this.btnGetOverdue.Text = "Get Report";
            this.btnGetOverdue.UseVisualStyleBackColor = true;
            this.btnGetOverdue.Click += new System.EventHandler(this.btnGetOverdue_Click);
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(6, 51);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(57, 13);
            this.Label13.TabIndex = 12;
            this.Label13.Text = "Equipment";
            // 
            // cmbEquipment
            // 
            this.cmbEquipment.FormattingEnabled = true;
            this.cmbEquipment.Location = new System.Drawing.Point(94, 47);
            this.cmbEquipment.Name = "cmbEquipment";
            this.cmbEquipment.Size = new System.Drawing.Size(193, 21);
            this.cmbEquipment.TabIndex = 11;
            // 
            // txtDaysOver
            // 
            this.txtDaysOver.Location = new System.Drawing.Point(599, 20);
            this.txtDaysOver.Name = "txtDaysOver";
            this.txtDaysOver.Size = new System.Drawing.Size(36, 20);
            this.txtDaysOver.TabIndex = 10;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(366, 48);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(126, 20);
            this.dtpEnd.TabIndex = 9;
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(366, 21);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(126, 20);
            this.dtpStart.TabIndex = 8;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(6, 24);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(82, 13);
            this.Label9.TabIndex = 7;
            this.Label9.Text = "Company Name";
            // 
            // cmbCompanyName
            // 
            this.cmbCompanyName.FormattingEnabled = true;
            this.cmbCompanyName.Location = new System.Drawing.Point(94, 20);
            this.cmbCompanyName.Name = "cmbCompanyName";
            this.cmbCompanyName.Size = new System.Drawing.Size(193, 21);
            this.cmbCompanyName.TabIndex = 6;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(518, 23);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(75, 13);
            this.Label10.TabIndex = 5;
            this.Label10.Text = "Days Overdue";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(309, 51);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(52, 13);
            this.Label11.TabIndex = 4;
            this.Label11.Text = "End Date";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(309, 24);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(55, 13);
            this.Label12.TabIndex = 3;
            this.Label12.Text = "Start Date";
            // 
            // dgvOverdue
            // 
            this.dgvOverdue.AllowUserToAddRows = false;
            this.dgvOverdue.AllowUserToDeleteRows = false;
            this.dgvOverdue.AllowUserToOrderColumns = true;
            this.dgvOverdue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOverdue.Location = new System.Drawing.Point(7, 98);
            this.dgvOverdue.Name = "dgvOverdue";
            this.dgvOverdue.ReadOnly = true;
            this.dgvOverdue.RowHeadersVisible = false;
            this.dgvOverdue.Size = new System.Drawing.Size(912, 338);
            this.dgvOverdue.TabIndex = 0;
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.GroupBox1);
            this.TabPage2.Controls.Add(this.dgvCustomer);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(926, 442);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Customer History";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btnGetCustomer);
            this.GroupBox1.Controls.Add(this.txtCustRevenue);
            this.GroupBox1.Controls.Add(this.dtpCustEnd);
            this.GroupBox1.Controls.Add(this.dtpCustStart);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.cmbCoNameHST);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Location = new System.Drawing.Point(6, 7);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(911, 86);
            this.GroupBox1.TabIndex = 2;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Customer Search Criteria";
            // 
            // btnGetCustomer
            // 
            this.btnGetCustomer.Location = new System.Drawing.Point(770, 32);
            this.btnGetCustomer.Name = "btnGetCustomer";
            this.btnGetCustomer.Size = new System.Drawing.Size(94, 23);
            this.btnGetCustomer.TabIndex = 11;
            this.btnGetCustomer.Text = "Get Report";
            this.btnGetCustomer.UseVisualStyleBackColor = true;
            this.btnGetCustomer.Click += new System.EventHandler(this.btnGetCustomer_Click);
            // 
            // txtCustRevenue
            // 
            this.txtCustRevenue.Location = new System.Drawing.Point(606, 20);
            this.txtCustRevenue.Name = "txtCustRevenue";
            this.txtCustRevenue.Size = new System.Drawing.Size(100, 20);
            this.txtCustRevenue.TabIndex = 10;
            // 
            // dtpCustEnd
            // 
            this.dtpCustEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCustEnd.Location = new System.Drawing.Point(366, 48);
            this.dtpCustEnd.Name = "dtpCustEnd";
            this.dtpCustEnd.Size = new System.Drawing.Size(126, 20);
            this.dtpCustEnd.TabIndex = 9;
            // 
            // dtpCustStart
            // 
            this.dtpCustStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCustStart.Location = new System.Drawing.Point(366, 20);
            this.dtpCustStart.Name = "dtpCustStart";
            this.dtpCustStart.Size = new System.Drawing.Size(126, 20);
            this.dtpCustStart.TabIndex = 8;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(6, 24);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(82, 13);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Company Name";
            // 
            // cmbCoNameHST
            // 
            this.cmbCoNameHST.FormattingEnabled = true;
            this.cmbCoNameHST.Location = new System.Drawing.Point(94, 21);
            this.cmbCoNameHST.Name = "cmbCoNameHST";
            this.cmbCoNameHST.Size = new System.Drawing.Size(193, 21);
            this.cmbCoNameHST.TabIndex = 6;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(523, 24);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(78, 13);
            this.Label4.TabIndex = 5;
            this.Label4.Text = "Total Revenue";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(309, 51);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(52, 13);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "End Date";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(309, 24);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(55, 13);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Start Date";
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.AllowUserToOrderColumns = true;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Location = new System.Drawing.Point(7, 99);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.RowHeadersVisible = false;
            this.dgvCustomer.Size = new System.Drawing.Size(912, 336);
            this.dgvCustomer.TabIndex = 0;
            // 
            // TabPage3
            // 
            this.TabPage3.Controls.Add(this.GroupBox2);
            this.TabPage3.Controls.Add(this.dgvEquipment);
            this.TabPage3.Location = new System.Drawing.Point(4, 22);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage3.Size = new System.Drawing.Size(926, 442);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "Equipment History";
            this.TabPage3.UseVisualStyleBackColor = true;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.btnGetEquipment);
            this.GroupBox2.Controls.Add(this.txtEquipRevenue);
            this.GroupBox2.Controls.Add(this.dtpEquipEnd);
            this.GroupBox2.Controls.Add(this.dtpEquipStart);
            this.GroupBox2.Controls.Add(this.Label5);
            this.GroupBox2.Controls.Add(this.cmbEquipHST);
            this.GroupBox2.Controls.Add(this.Label6);
            this.GroupBox2.Controls.Add(this.Label7);
            this.GroupBox2.Controls.Add(this.Label8);
            this.GroupBox2.Location = new System.Drawing.Point(7, 7);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(911, 86);
            this.GroupBox2.TabIndex = 3;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Equipment Search Criteria";
            // 
            // btnGetEquipment
            // 
            this.btnGetEquipment.Location = new System.Drawing.Point(765, 32);
            this.btnGetEquipment.Name = "btnGetEquipment";
            this.btnGetEquipment.Size = new System.Drawing.Size(99, 23);
            this.btnGetEquipment.TabIndex = 11;
            this.btnGetEquipment.Text = "Get Report";
            this.btnGetEquipment.UseVisualStyleBackColor = true;
            this.btnGetEquipment.Click += new System.EventHandler(this.btnGetEquipment_Click);
            // 
            // txtEquipRevenue
            // 
            this.txtEquipRevenue.Location = new System.Drawing.Point(599, 16);
            this.txtEquipRevenue.Name = "txtEquipRevenue";
            this.txtEquipRevenue.Size = new System.Drawing.Size(100, 20);
            this.txtEquipRevenue.TabIndex = 10;
            // 
            // dtpEquipEnd
            // 
            this.dtpEquipEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEquipEnd.Location = new System.Drawing.Point(368, 45);
            this.dtpEquipEnd.Name = "dtpEquipEnd";
            this.dtpEquipEnd.Size = new System.Drawing.Size(126, 20);
            this.dtpEquipEnd.TabIndex = 9;
            // 
            // dtpEquipStart
            // 
            this.dtpEquipStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEquipStart.Location = new System.Drawing.Point(368, 19);
            this.dtpEquipStart.Name = "dtpEquipStart";
            this.dtpEquipStart.Size = new System.Drawing.Size(126, 20);
            this.dtpEquipStart.TabIndex = 8;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(17, 23);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(58, 13);
            this.Label5.TabIndex = 7;
            this.Label5.Text = "Item Name";
            // 
            // cmbEquipHST
            // 
            this.cmbEquipHST.FormattingEnabled = true;
            this.cmbEquipHST.Location = new System.Drawing.Point(97, 20);
            this.cmbEquipHST.Name = "cmbEquipHST";
            this.cmbEquipHST.Size = new System.Drawing.Size(193, 21);
            this.cmbEquipHST.TabIndex = 6;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(516, 20);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(78, 13);
            this.Label6.TabIndex = 5;
            this.Label6.Text = "Total Revenue";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(314, 49);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(52, 13);
            this.Label7.TabIndex = 4;
            this.Label7.Text = "End Date";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(311, 23);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(55, 13);
            this.Label8.TabIndex = 3;
            this.Label8.Text = "Start Date";
            // 
            // dgvEquipment
            // 
            this.dgvEquipment.AllowUserToAddRows = false;
            this.dgvEquipment.AllowUserToDeleteRows = false;
            this.dgvEquipment.AllowUserToOrderColumns = true;
            this.dgvEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipment.Location = new System.Drawing.Point(7, 99);
            this.dgvEquipment.Name = "dgvEquipment";
            this.dgvEquipment.ReadOnly = true;
            this.dgvEquipment.RowHeadersVisible = false;
            this.dgvEquipment.Size = new System.Drawing.Size(912, 336);
            this.dgvEquipment.TabIndex = 1;
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 472);
            this.Controls.Add(this.TabControl1);
            this.Name = "frmReports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.frmReports_Load);
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.grpFilters.ResumeLayout(false);
            this.grpFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverdue)).EndInit();
            this.TabPage2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.TabPage3.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.GroupBox grpFilters;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.ComboBox cmbEquipment;
        internal System.Windows.Forms.TextBox txtDaysOver;
        internal System.Windows.Forms.DateTimePicker dtpEnd;
        internal System.Windows.Forms.DateTimePicker dtpStart;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.ComboBox cmbCompanyName;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.DataGridView dgvOverdue;
        internal System.Windows.Forms.TabPage TabPage2;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox txtCustRevenue;
        internal System.Windows.Forms.DateTimePicker dtpCustEnd;
        internal System.Windows.Forms.DateTimePicker dtpCustStart;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox cmbCoNameHST;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.DataGridView dgvCustomer;
        internal System.Windows.Forms.TabPage TabPage3;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.TextBox txtEquipRevenue;
        internal System.Windows.Forms.DateTimePicker dtpEquipEnd;
        internal System.Windows.Forms.DateTimePicker dtpEquipStart;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.ComboBox cmbEquipHST;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.DataGridView dgvEquipment;
        private System.Windows.Forms.Button btnGetOverdue;
        private System.Windows.Forms.Button btnGetCustomer;
        private System.Windows.Forms.Button btnGetEquipment;
    }
}

