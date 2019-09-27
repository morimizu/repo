namespace A1Rentals
{
    partial class frmReturns
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grpRevisedAmt = new System.Windows.Forms.GroupBox();
            this.txtRevTotal = new System.Windows.Forms.TextBox();
            this.txtRevTax = new System.Windows.Forms.TextBox();
            this.txtRevSubtotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblRevSubtotal = new System.Windows.Forms.Label();
            this.grpCustDtls = new System.Windows.Forms.GroupBox();
            this.txtCreditType = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtCreditLimit = new System.Windows.Forms.TextBox();
            this.rdoOther = new System.Windows.Forms.RadioButton();
            this.rdoAmEx = new System.Windows.Forms.RadioButton();
            this.rdoMaster = new System.Windows.Forms.RadioButton();
            this.rdoVisa = new System.Windows.Forms.RadioButton();
            this.txtCoName = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtExpDate = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.grpItemDtls = new System.Windows.Forms.GroupBox();
            this.chkReturned = new System.Windows.Forms.CheckBox();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.dtpReturned = new System.Windows.Forms.DateTimePicker();
            this.dtpDue = new System.Windows.Forms.DateTimePicker();
            this.dtpRent = new System.Windows.Forms.DateTimePicker();
            this.Label12 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.grpRentals = new System.Windows.Forms.GroupBox();
            this.dgvCurrentInvoices = new System.Windows.Forms.DataGridView();
            this.grpEquipList = new System.Windows.Forms.GroupBox();
            this.dgvEquipList = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpRevisedAmt.SuspendLayout();
            this.grpCustDtls.SuspendLayout();
            this.grpItemDtls.SuspendLayout();
            this.grpRentals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentInvoices)).BeginInit();
            this.grpEquipList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(407, 480);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(144, 23);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update Returned Item";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // grpRevisedAmt
            // 
            this.grpRevisedAmt.Controls.Add(this.txtRevTotal);
            this.grpRevisedAmt.Controls.Add(this.txtRevTax);
            this.grpRevisedAmt.Controls.Add(this.txtRevSubtotal);
            this.grpRevisedAmt.Controls.Add(this.lblTotal);
            this.grpRevisedAmt.Controls.Add(this.lblTax);
            this.grpRevisedAmt.Controls.Add(this.lblRevSubtotal);
            this.grpRevisedAmt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grpRevisedAmt.Location = new System.Drawing.Point(777, 298);
            this.grpRevisedAmt.Name = "grpRevisedAmt";
            this.grpRevisedAmt.Size = new System.Drawing.Size(175, 176);
            this.grpRevisedAmt.TabIndex = 12;
            this.grpRevisedAmt.TabStop = false;
            this.grpRevisedAmt.Text = "Revised Invoice Amount";
            // 
            // txtRevTotal
            // 
            this.txtRevTotal.Location = new System.Drawing.Point(70, 85);
            this.txtRevTotal.Name = "txtRevTotal";
            this.txtRevTotal.ReadOnly = true;
            this.txtRevTotal.Size = new System.Drawing.Size(94, 20);
            this.txtRevTotal.TabIndex = 5;
            // 
            // txtRevTax
            // 
            this.txtRevTax.Location = new System.Drawing.Point(70, 52);
            this.txtRevTax.Name = "txtRevTax";
            this.txtRevTax.ReadOnly = true;
            this.txtRevTax.Size = new System.Drawing.Size(94, 20);
            this.txtRevTax.TabIndex = 4;
            // 
            // txtRevSubtotal
            // 
            this.txtRevSubtotal.Location = new System.Drawing.Point(70, 22);
            this.txtRevSubtotal.Name = "txtRevSubtotal";
            this.txtRevSubtotal.ReadOnly = true;
            this.txtRevSubtotal.Size = new System.Drawing.Size(94, 20);
            this.txtRevSubtotal.TabIndex = 3;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTotal.Location = new System.Drawing.Point(15, 88);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTax.Location = new System.Drawing.Point(15, 55);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(28, 13);
            this.lblTax.TabIndex = 1;
            this.lblTax.Text = "Tax:";
            // 
            // lblRevSubtotal
            // 
            this.lblRevSubtotal.AutoSize = true;
            this.lblRevSubtotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRevSubtotal.Location = new System.Drawing.Point(15, 25);
            this.lblRevSubtotal.Name = "lblRevSubtotal";
            this.lblRevSubtotal.Size = new System.Drawing.Size(49, 13);
            this.lblRevSubtotal.TabIndex = 0;
            this.lblRevSubtotal.Text = "Subtotal:";
            // 
            // grpCustDtls
            // 
            this.grpCustDtls.Controls.Add(this.txtCreditType);
            this.grpCustDtls.Controls.Add(this.Label8);
            this.grpCustDtls.Controls.Add(this.txtCreditLimit);
            this.grpCustDtls.Controls.Add(this.rdoOther);
            this.grpCustDtls.Controls.Add(this.rdoAmEx);
            this.grpCustDtls.Controls.Add(this.rdoMaster);
            this.grpCustDtls.Controls.Add(this.rdoVisa);
            this.grpCustDtls.Controls.Add(this.txtCoName);
            this.grpCustDtls.Controls.Add(this.Label7);
            this.grpCustDtls.Controls.Add(this.txtExpDate);
            this.grpCustDtls.Controls.Add(this.Label6);
            this.grpCustDtls.Controls.Add(this.Label5);
            this.grpCustDtls.Controls.Add(this.txtCardNo);
            this.grpCustDtls.Controls.Add(this.txtContactName);
            this.grpCustDtls.Controls.Add(this.txtContactNo);
            this.grpCustDtls.Controls.Add(this.Label4);
            this.grpCustDtls.Controls.Add(this.Label3);
            this.grpCustDtls.Controls.Add(this.Label2);
            this.grpCustDtls.Controls.Add(this.Label1);
            this.grpCustDtls.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grpCustDtls.Location = new System.Drawing.Point(271, 298);
            this.grpCustDtls.Name = "grpCustDtls";
            this.grpCustDtls.Size = new System.Drawing.Size(500, 176);
            this.grpCustDtls.TabIndex = 11;
            this.grpCustDtls.TabStop = false;
            this.grpCustDtls.Text = "Customer Details";
            // 
            // txtCreditType
            // 
            this.txtCreditType.Location = new System.Drawing.Point(356, 139);
            this.txtCreditType.Name = "txtCreditType";
            this.txtCreditType.ReadOnly = true;
            this.txtCreditType.Size = new System.Drawing.Size(128, 20);
            this.txtCreditType.TabIndex = 18;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label8.Location = new System.Drawing.Point(255, 142);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(90, 13);
            this.Label8.TabIndex = 17;
            this.Label8.Text = "Other Credit Type";
            // 
            // txtCreditLimit
            // 
            this.txtCreditLimit.Location = new System.Drawing.Point(104, 139);
            this.txtCreditLimit.Name = "txtCreditLimit";
            this.txtCreditLimit.ReadOnly = true;
            this.txtCreditLimit.Size = new System.Drawing.Size(128, 20);
            this.txtCreditLimit.TabIndex = 7;
            // 
            // rdoOther
            // 
            this.rdoOther.AutoSize = true;
            this.rdoOther.Enabled = false;
            this.rdoOther.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdoOther.Location = new System.Drawing.Point(388, 113);
            this.rdoOther.Name = "rdoOther";
            this.rdoOther.Size = new System.Drawing.Size(95, 17);
            this.rdoOther.TabIndex = 16;
            this.rdoOther.TabStop = true;
            this.rdoOther.Text = "Other (Specify)";
            this.rdoOther.UseVisualStyleBackColor = true;
            // 
            // rdoAmEx
            // 
            this.rdoAmEx.AutoSize = true;
            this.rdoAmEx.Enabled = false;
            this.rdoAmEx.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdoAmEx.Location = new System.Drawing.Point(301, 113);
            this.rdoAmEx.Name = "rdoAmEx";
            this.rdoAmEx.Size = new System.Drawing.Size(52, 17);
            this.rdoAmEx.TabIndex = 15;
            this.rdoAmEx.TabStop = true;
            this.rdoAmEx.Text = "AmEx";
            this.rdoAmEx.UseVisualStyleBackColor = true;
            // 
            // rdoMaster
            // 
            this.rdoMaster.AutoSize = true;
            this.rdoMaster.Enabled = false;
            this.rdoMaster.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdoMaster.Location = new System.Drawing.Point(184, 113);
            this.rdoMaster.Name = "rdoMaster";
            this.rdoMaster.Size = new System.Drawing.Size(82, 17);
            this.rdoMaster.TabIndex = 14;
            this.rdoMaster.TabStop = true;
            this.rdoMaster.Text = "Master Card";
            this.rdoMaster.UseVisualStyleBackColor = true;
            // 
            // rdoVisa
            // 
            this.rdoVisa.AutoSize = true;
            this.rdoVisa.Enabled = false;
            this.rdoVisa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdoVisa.Location = new System.Drawing.Point(104, 113);
            this.rdoVisa.Name = "rdoVisa";
            this.rdoVisa.Size = new System.Drawing.Size(45, 17);
            this.rdoVisa.TabIndex = 13;
            this.rdoVisa.TabStop = true;
            this.rdoVisa.Text = "Visa";
            this.rdoVisa.UseVisualStyleBackColor = true;
            // 
            // txtCoName
            // 
            this.txtCoName.Location = new System.Drawing.Point(104, 22);
            this.txtCoName.Name = "txtCoName";
            this.txtCoName.ReadOnly = true;
            this.txtCoName.Size = new System.Drawing.Size(380, 20);
            this.txtCoName.TabIndex = 12;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label7.Location = new System.Drawing.Point(16, 55);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(75, 13);
            this.Label7.TabIndex = 11;
            this.Label7.Text = "Contact Name";
            // 
            // txtExpDate
            // 
            this.txtExpDate.Location = new System.Drawing.Point(356, 85);
            this.txtExpDate.Name = "txtExpDate";
            this.txtExpDate.ReadOnly = true;
            this.txtExpDate.Size = new System.Drawing.Size(70, 20);
            this.txtExpDate.TabIndex = 10;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label6.Location = new System.Drawing.Point(16, 115);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(59, 13);
            this.Label6.TabIndex = 9;
            this.Label6.Text = "Credit Card";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label5.Location = new System.Drawing.Point(288, 88);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(51, 13);
            this.Label5.TabIndex = 8;
            this.Label5.Text = "Exp Date";
            // 
            // txtCardNo
            // 
            this.txtCardNo.Location = new System.Drawing.Point(104, 82);
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.ReadOnly = true;
            this.txtCardNo.Size = new System.Drawing.Size(128, 20);
            this.txtCardNo.TabIndex = 6;
            // 
            // txtContactName
            // 
            this.txtContactName.Location = new System.Drawing.Point(104, 52);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.ReadOnly = true;
            this.txtContactName.Size = new System.Drawing.Size(128, 20);
            this.txtContactName.TabIndex = 5;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(356, 52);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.ReadOnly = true;
            this.txtContactNo.Size = new System.Drawing.Size(128, 20);
            this.txtContactNo.TabIndex = 4;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label4.Location = new System.Drawing.Point(16, 145);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(58, 13);
            this.Label4.TabIndex = 3;
            this.Label4.Text = "Credit Limit";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label3.Location = new System.Drawing.Point(16, 85);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(69, 13);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Card Number";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(255, 55);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(84, 13);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Contact Number";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(16, 25);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(82, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Company Name";
            // 
            // grpItemDtls
            // 
            this.grpItemDtls.Controls.Add(this.chkReturned);
            this.grpItemDtls.Controls.Add(this.txtInvoiceNo);
            this.grpItemDtls.Controls.Add(this.Label9);
            this.grpItemDtls.Controls.Add(this.dtpReturned);
            this.grpItemDtls.Controls.Add(this.dtpDue);
            this.grpItemDtls.Controls.Add(this.dtpRent);
            this.grpItemDtls.Controls.Add(this.Label12);
            this.grpItemDtls.Controls.Add(this.txtItemName);
            this.grpItemDtls.Controls.Add(this.Label14);
            this.grpItemDtls.Controls.Add(this.Label16);
            this.grpItemDtls.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grpItemDtls.Location = new System.Drawing.Point(12, 298);
            this.grpItemDtls.Name = "grpItemDtls";
            this.grpItemDtls.Size = new System.Drawing.Size(253, 176);
            this.grpItemDtls.TabIndex = 10;
            this.grpItemDtls.TabStop = false;
            this.grpItemDtls.Text = "Rental Item Details";
            // 
            // chkReturned
            // 
            this.chkReturned.AutoSize = true;
            this.chkReturned.BackColor = System.Drawing.SystemColors.Control;
            this.chkReturned.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkReturned.Location = new System.Drawing.Point(15, 144);
            this.chkReturned.Name = "chkReturned";
            this.chkReturned.Size = new System.Drawing.Size(70, 17);
            this.chkReturned.TabIndex = 44;
            this.chkReturned.Text = "Returned";
            this.chkReturned.UseVisualStyleBackColor = false;
            this.chkReturned.CheckedChanged += new System.EventHandler(this.chkReturned_CheckedChanged);
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Location = new System.Drawing.Point(101, 22);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.ReadOnly = true;
            this.txtInvoiceNo.Size = new System.Drawing.Size(130, 20);
            this.txtInvoiceNo.TabIndex = 43;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label9.Location = new System.Drawing.Point(16, 25);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(82, 13);
            this.Label9.TabIndex = 42;
            this.Label9.Text = "Invoice Number";
            // 
            // dtpReturned
            // 
            this.dtpReturned.Enabled = false;
            this.dtpReturned.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturned.Location = new System.Drawing.Point(101, 142);
            this.dtpReturned.Name = "dtpReturned";
            this.dtpReturned.Size = new System.Drawing.Size(130, 20);
            this.dtpReturned.TabIndex = 41;
            // 
            // dtpDue
            // 
            this.dtpDue.Enabled = false;
            this.dtpDue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDue.Location = new System.Drawing.Point(101, 112);
            this.dtpDue.Name = "dtpDue";
            this.dtpDue.Size = new System.Drawing.Size(130, 20);
            this.dtpDue.TabIndex = 39;
            // 
            // dtpRent
            // 
            this.dtpRent.Enabled = false;
            this.dtpRent.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRent.Location = new System.Drawing.Point(101, 82);
            this.dtpRent.Name = "dtpRent";
            this.dtpRent.Size = new System.Drawing.Size(130, 20);
            this.dtpRent.TabIndex = 38;
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label12.Location = new System.Drawing.Point(16, 115);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(53, 13);
            this.Label12.TabIndex = 27;
            this.Label12.Text = "Due Date";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(101, 52);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.ReadOnly = true;
            this.txtItemName.Size = new System.Drawing.Size(130, 20);
            this.txtItemName.TabIndex = 24;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label14.Location = new System.Drawing.Point(16, 85);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(64, 13);
            this.Label14.TabIndex = 21;
            this.Label14.Text = "Rental Date";
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label16.Location = new System.Drawing.Point(16, 55);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(58, 13);
            this.Label16.TabIndex = 19;
            this.Label16.Text = "Item Name";
            // 
            // grpRentals
            // 
            this.grpRentals.Controls.Add(this.dgvCurrentInvoices);
            this.grpRentals.Location = new System.Drawing.Point(12, 56);
            this.grpRentals.Name = "grpRentals";
            this.grpRentals.Size = new System.Drawing.Size(940, 119);
            this.grpRentals.TabIndex = 9;
            this.grpRentals.TabStop = false;
            this.grpRentals.Text = "Current Invoices";
            // 
            // dgvCurrentInvoices
            // 
            this.dgvCurrentInvoices.AllowUserToAddRows = false;
            this.dgvCurrentInvoices.AllowUserToDeleteRows = false;
            this.dgvCurrentInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrentInvoices.Location = new System.Drawing.Point(6, 20);
            this.dgvCurrentInvoices.MultiSelect = false;
            this.dgvCurrentInvoices.Name = "dgvCurrentInvoices";
            this.dgvCurrentInvoices.ReadOnly = true;
            this.dgvCurrentInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCurrentInvoices.Size = new System.Drawing.Size(928, 93);
            this.dgvCurrentInvoices.TabIndex = 0;
            this.dgvCurrentInvoices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCurrentRentals_CellClick);
            this.dgvCurrentInvoices.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCurrentInvoices_CellMouseClick);
            // 
            // grpEquipList
            // 
            this.grpEquipList.Controls.Add(this.dgvEquipList);
            this.grpEquipList.Location = new System.Drawing.Point(12, 181);
            this.grpEquipList.Name = "grpEquipList";
            this.grpEquipList.Size = new System.Drawing.Size(940, 111);
            this.grpEquipList.TabIndex = 10;
            this.grpEquipList.TabStop = false;
            this.grpEquipList.Text = "Equipment Rented";
            // 
            // dgvEquipList
            // 
            this.dgvEquipList.AllowUserToAddRows = false;
            this.dgvEquipList.AllowUserToDeleteRows = false;
            this.dgvEquipList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipList.Location = new System.Drawing.Point(6, 20);
            this.dgvEquipList.MultiSelect = false;
            this.dgvEquipList.Name = "dgvEquipList";
            this.dgvEquipList.ReadOnly = true;
            this.dgvEquipList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEquipList.Size = new System.Drawing.Size(928, 85);
            this.dgvEquipList.TabIndex = 0;
            this.dgvEquipList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEquipList_CellMouseClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Customer Name";
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.Location = new System.Drawing.Point(113, 19);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(121, 21);
            this.cmbCustomers.TabIndex = 15;
            this.cmbCustomers.DropDown += new System.EventHandler(this.cmbCustomers_DropDown);
            this.cmbCustomers.SelectionChangeCommitted += new System.EventHandler(this.cmbCustomers_SelectionChangeCommitted);
            this.cmbCustomers.TextUpdate += new System.EventHandler(this.cmbCustomers_TextUpdate);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(596, 480);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear Item";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmReturns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 516);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cmbCustomers);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.grpEquipList);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.grpRevisedAmt);
            this.Controls.Add(this.grpCustDtls);
            this.Controls.Add(this.grpItemDtls);
            this.Controls.Add(this.grpRentals);
            this.Name = "frmReturns";
            this.Text = "Returns";
            this.Load += new System.EventHandler(this.frmReturns_Load);
            this.grpRevisedAmt.ResumeLayout(false);
            this.grpRevisedAmt.PerformLayout();
            this.grpCustDtls.ResumeLayout(false);
            this.grpCustDtls.PerformLayout();
            this.grpItemDtls.ResumeLayout(false);
            this.grpItemDtls.PerformLayout();
            this.grpRentals.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentInvoices)).EndInit();
            this.grpEquipList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnUpdate;
        internal System.Windows.Forms.GroupBox grpRevisedAmt;
        internal System.Windows.Forms.GroupBox grpCustDtls;
        internal System.Windows.Forms.TextBox txtCreditType;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox txtCreditLimit;
        internal System.Windows.Forms.RadioButton rdoOther;
        internal System.Windows.Forms.RadioButton rdoAmEx;
        internal System.Windows.Forms.RadioButton rdoMaster;
        internal System.Windows.Forms.RadioButton rdoVisa;
        internal System.Windows.Forms.TextBox txtCoName;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtExpDate;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtCardNo;
        internal System.Windows.Forms.TextBox txtContactName;
        internal System.Windows.Forms.TextBox txtContactNo;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.GroupBox grpItemDtls;
        internal System.Windows.Forms.TextBox txtInvoiceNo;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.DateTimePicker dtpReturned;
        internal System.Windows.Forms.DateTimePicker dtpDue;
        internal System.Windows.Forms.DateTimePicker dtpRent;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.TextBox txtItemName;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.GroupBox grpRentals;
        private System.Windows.Forms.DataGridView dgvCurrentInvoices;
        private System.Windows.Forms.TextBox txtRevTotal;
        private System.Windows.Forms.TextBox txtRevTax;
        private System.Windows.Forms.TextBox txtRevSubtotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblRevSubtotal;
        internal System.Windows.Forms.GroupBox grpEquipList;
        private System.Windows.Forms.DataGridView dgvEquipList;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbCustomers;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox chkReturned;
    }
}