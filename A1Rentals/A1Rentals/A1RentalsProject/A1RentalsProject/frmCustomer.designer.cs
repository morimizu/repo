namespace A1Rentals
{
    partial class frmCustomer
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
            this.grpCustomerList = new System.Windows.Forms.GroupBox();
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.grpCustomerDetails = new System.Windows.Forms.GroupBox();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.chkCreditcheck = new System.Windows.Forms.CheckBox();
            this.rdoOther = new System.Windows.Forms.RadioButton();
            this.txtAddresss = new System.Windows.Forms.TextBox();
            this.rdoAmEx = new System.Windows.Forms.RadioButton();
            this.lblAddress = new System.Windows.Forms.Label();
            this.rdomasterCard = new System.Windows.Forms.RadioButton();
            this.rdoVisa = new System.Windows.Forms.RadioButton();
            this.dtpExpDate = new System.Windows.Forms.DateTimePicker();
            this.txtCreditType = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtCreditLimit = new System.Windows.Forms.TextBox();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCreditType = new System.Windows.Forms.Label();
            this.lblExpDate = new System.Windows.Forms.Label();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.lblCreditLimit = new System.Windows.Forms.Label();
            this.lblCreditCard = new System.Windows.Forms.Label();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.lblContactName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grpBankDetails = new System.Windows.Forms.GroupBox();
            this.txtBankAddress = new System.Windows.Forms.TextBox();
            this.txtBankContactNumber = new System.Windows.Forms.TextBox();
            this.txtBankContactName = new System.Windows.Forms.TextBox();
            this.txtBranch = new System.Windows.Forms.TextBox();
            this.txtBank = new System.Windows.Forms.TextBox();
            this.lblBankContactNumber = new System.Windows.Forms.Label();
            this.lblBankContactName = new System.Windows.Forms.Label();
            this.lblBranch = new System.Windows.Forms.Label();
            this.lblBankAddress = new System.Windows.Forms.Label();
            this.lblBank = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpCustomerList.SuspendLayout();
            this.grpCustomerDetails.SuspendLayout();
            this.grpBankDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCustomerList
            // 
            this.grpCustomerList.Controls.Add(this.lstCustomers);
            this.grpCustomerList.Location = new System.Drawing.Point(13, 13);
            this.grpCustomerList.Name = "grpCustomerList";
            this.grpCustomerList.Size = new System.Drawing.Size(200, 459);
            this.grpCustomerList.TabIndex = 0;
            this.grpCustomerList.TabStop = false;
            this.grpCustomerList.Text = "Customers";
            // 
            // lstCustomers
            // 
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.Location = new System.Drawing.Point(10, 18);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(178, 433);
            this.lstCustomers.TabIndex = 0;
            this.lstCustomers.SelectedIndexChanged += new System.EventHandler(this.lstCustomers_SelectedIndexChanged);
            // 
            // grpCustomerDetails
            // 
            this.grpCustomerDetails.Controls.Add(this.txtCardNumber);
            this.grpCustomerDetails.Controls.Add(this.chkCreditcheck);
            this.grpCustomerDetails.Controls.Add(this.rdoOther);
            this.grpCustomerDetails.Controls.Add(this.txtAddresss);
            this.grpCustomerDetails.Controls.Add(this.rdoAmEx);
            this.grpCustomerDetails.Controls.Add(this.lblAddress);
            this.grpCustomerDetails.Controls.Add(this.rdomasterCard);
            this.grpCustomerDetails.Controls.Add(this.rdoVisa);
            this.grpCustomerDetails.Controls.Add(this.dtpExpDate);
            this.grpCustomerDetails.Controls.Add(this.txtCreditType);
            this.grpCustomerDetails.Controls.Add(this.txtContactNumber);
            this.grpCustomerDetails.Controls.Add(this.txtCreditLimit);
            this.grpCustomerDetails.Controls.Add(this.txtContactName);
            this.grpCustomerDetails.Controls.Add(this.txtName);
            this.grpCustomerDetails.Controls.Add(this.lblCreditType);
            this.grpCustomerDetails.Controls.Add(this.lblExpDate);
            this.grpCustomerDetails.Controls.Add(this.lblContactNumber);
            this.grpCustomerDetails.Controls.Add(this.lblCreditLimit);
            this.grpCustomerDetails.Controls.Add(this.lblCreditCard);
            this.grpCustomerDetails.Controls.Add(this.lblCardNumber);
            this.grpCustomerDetails.Controls.Add(this.lblContactName);
            this.grpCustomerDetails.Controls.Add(this.lblName);
            this.grpCustomerDetails.Location = new System.Drawing.Point(219, 13);
            this.grpCustomerDetails.Name = "grpCustomerDetails";
            this.grpCustomerDetails.Size = new System.Drawing.Size(682, 259);
            this.grpCustomerDetails.TabIndex = 1;
            this.grpCustomerDetails.TabStop = false;
            this.grpCustomerDetails.Text = "Customer Details";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtCardNumber.Location = new System.Drawing.Point(449, 122);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(204, 20);
            this.txtCardNumber.TabIndex = 14;
            // 
            // chkCreditcheck
            // 
            this.chkCreditcheck.AutoSize = true;
            this.chkCreditcheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkCreditcheck.Location = new System.Drawing.Point(566, 230);
            this.chkCreditcheck.Name = "chkCreditcheck";
            this.chkCreditcheck.Size = new System.Drawing.Size(87, 17);
            this.chkCreditcheck.TabIndex = 21;
            this.chkCreditcheck.Text = "Credit Check";
            this.chkCreditcheck.UseVisualStyleBackColor = true;
            this.chkCreditcheck.CheckedChanged += new System.EventHandler(this.chkCreditcheck_CheckedChanged);
            // 
            // rdoOther
            // 
            this.rdoOther.AutoSize = true;
            this.rdoOther.Location = new System.Drawing.Point(558, 88);
            this.rdoOther.Name = "rdoOther";
            this.rdoOther.Size = new System.Drawing.Size(95, 17);
            this.rdoOther.TabIndex = 12;
            this.rdoOther.TabStop = true;
            this.rdoOther.Text = "Other (Specify)";
            this.rdoOther.UseVisualStyleBackColor = true;
            this.rdoOther.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // txtAddresss
            // 
            this.txtAddresss.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtAddresss.Location = new System.Drawing.Point(113, 125);
            this.txtAddresss.Multiline = true;
            this.txtAddresss.Name = "txtAddresss";
            this.txtAddresss.Size = new System.Drawing.Size(185, 87);
            this.txtAddresss.TabIndex = 7;
            // 
            // rdoAmEx
            // 
            this.rdoAmEx.AutoSize = true;
            this.rdoAmEx.Location = new System.Drawing.Point(449, 90);
            this.rdoAmEx.Name = "rdoAmEx";
            this.rdoAmEx.Size = new System.Drawing.Size(52, 17);
            this.rdoAmEx.TabIndex = 11;
            this.rdoAmEx.TabStop = true;
            this.rdoAmEx.Text = "AmEx";
            this.rdoAmEx.UseVisualStyleBackColor = true;
            this.rdoAmEx.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(7, 125);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Address";
            // 
            // rdomasterCard
            // 
            this.rdomasterCard.AutoSize = true;
            this.rdomasterCard.Location = new System.Drawing.Point(558, 55);
            this.rdomasterCard.Name = "rdomasterCard";
            this.rdomasterCard.Size = new System.Drawing.Size(82, 17);
            this.rdomasterCard.TabIndex = 10;
            this.rdomasterCard.TabStop = true;
            this.rdomasterCard.Text = "Master Card";
            this.rdomasterCard.UseVisualStyleBackColor = true;
            this.rdomasterCard.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // rdoVisa
            // 
            this.rdoVisa.AutoSize = true;
            this.rdoVisa.Location = new System.Drawing.Point(449, 55);
            this.rdoVisa.Name = "rdoVisa";
            this.rdoVisa.Size = new System.Drawing.Size(45, 17);
            this.rdoVisa.TabIndex = 9;
            this.rdoVisa.TabStop = true;
            this.rdoVisa.Text = "Visa";
            this.rdoVisa.UseVisualStyleBackColor = true;
            this.rdoVisa.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // dtpExpDate
            // 
            this.dtpExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpDate.Location = new System.Drawing.Point(449, 228);
            this.dtpExpDate.Name = "dtpExpDate";
            this.dtpExpDate.Size = new System.Drawing.Size(78, 20);
            this.dtpExpDate.TabIndex = 20;
            // 
            // txtCreditType
            // 
            this.txtCreditType.Enabled = false;
            this.txtCreditType.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtCreditType.Location = new System.Drawing.Point(449, 157);
            this.txtCreditType.Name = "txtCreditType";
            this.txtCreditType.Size = new System.Drawing.Size(204, 20);
            this.txtCreditType.TabIndex = 16;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtContactNumber.Location = new System.Drawing.Point(113, 87);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(185, 20);
            this.txtContactNumber.TabIndex = 5;
            // 
            // txtCreditLimit
            // 
            this.txtCreditLimit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtCreditLimit.Location = new System.Drawing.Point(449, 192);
            this.txtCreditLimit.Name = "txtCreditLimit";
            this.txtCreditLimit.Size = new System.Drawing.Size(204, 20);
            this.txtCreditLimit.TabIndex = 18;
            // 
            // txtContactName
            // 
            this.txtContactName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtContactName.Location = new System.Drawing.Point(113, 52);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(185, 20);
            this.txtContactName.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtName.Location = new System.Drawing.Point(113, 17);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(527, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblCreditType
            // 
            this.lblCreditType.AutoSize = true;
            this.lblCreditType.Location = new System.Drawing.Point(327, 160);
            this.lblCreditType.Name = "lblCreditType";
            this.lblCreditType.Size = new System.Drawing.Size(90, 13);
            this.lblCreditType.TabIndex = 15;
            this.lblCreditType.Text = "Other Credit Type";
            // 
            // lblExpDate
            // 
            this.lblExpDate.AutoSize = true;
            this.lblExpDate.Location = new System.Drawing.Point(327, 234);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(51, 13);
            this.lblExpDate.TabIndex = 19;
            this.lblExpDate.Text = "Exp Date";
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Location = new System.Drawing.Point(7, 90);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(84, 13);
            this.lblContactNumber.TabIndex = 4;
            this.lblContactNumber.Text = "Contact Number";
            // 
            // lblCreditLimit
            // 
            this.lblCreditLimit.AutoSize = true;
            this.lblCreditLimit.Location = new System.Drawing.Point(328, 195);
            this.lblCreditLimit.Name = "lblCreditLimit";
            this.lblCreditLimit.Size = new System.Drawing.Size(58, 13);
            this.lblCreditLimit.TabIndex = 17;
            this.lblCreditLimit.Text = "Credit Limit";
            // 
            // lblCreditCard
            // 
            this.lblCreditCard.AutoSize = true;
            this.lblCreditCard.Location = new System.Drawing.Point(327, 55);
            this.lblCreditCard.Name = "lblCreditCard";
            this.lblCreditCard.Size = new System.Drawing.Size(59, 13);
            this.lblCreditCard.TabIndex = 8;
            this.lblCreditCard.Text = "Credit Card";
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Location = new System.Drawing.Point(327, 125);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(99, 13);
            this.lblCardNumber.TabIndex = 13;
            this.lblCardNumber.Text = "Credit Card Number";
            // 
            // lblContactName
            // 
            this.lblContactName.AutoSize = true;
            this.lblContactName.Location = new System.Drawing.Point(7, 55);
            this.lblContactName.Name = "lblContactName";
            this.lblContactName.Size = new System.Drawing.Size(75, 13);
            this.lblContactName.TabIndex = 2;
            this.lblContactName.Text = "Contact Name";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Company Name";
            // 
            // grpBankDetails
            // 
            this.grpBankDetails.Controls.Add(this.txtBankAddress);
            this.grpBankDetails.Controls.Add(this.txtBankContactNumber);
            this.grpBankDetails.Controls.Add(this.txtBankContactName);
            this.grpBankDetails.Controls.Add(this.txtBranch);
            this.grpBankDetails.Controls.Add(this.txtBank);
            this.grpBankDetails.Controls.Add(this.lblBankContactNumber);
            this.grpBankDetails.Controls.Add(this.lblBankContactName);
            this.grpBankDetails.Controls.Add(this.lblBranch);
            this.grpBankDetails.Controls.Add(this.lblBankAddress);
            this.grpBankDetails.Controls.Add(this.lblBank);
            this.grpBankDetails.Enabled = false;
            this.grpBankDetails.Location = new System.Drawing.Point(219, 286);
            this.grpBankDetails.Name = "grpBankDetails";
            this.grpBankDetails.Size = new System.Drawing.Size(682, 146);
            this.grpBankDetails.TabIndex = 2;
            this.grpBankDetails.TabStop = false;
            this.grpBankDetails.Text = "Financial Institution";
            // 
            // txtBankAddress
            // 
            this.txtBankAddress.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtBankAddress.Location = new System.Drawing.Point(113, 49);
            this.txtBankAddress.Multiline = true;
            this.txtBankAddress.Name = "txtBankAddress";
            this.txtBankAddress.Size = new System.Drawing.Size(185, 80);
            this.txtBankAddress.TabIndex = 3;
            // 
            // txtBankContactNumber
            // 
            this.txtBankContactNumber.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtBankContactNumber.Location = new System.Drawing.Point(449, 78);
            this.txtBankContactNumber.Name = "txtBankContactNumber";
            this.txtBankContactNumber.Size = new System.Drawing.Size(204, 20);
            this.txtBankContactNumber.TabIndex = 9;
            // 
            // txtBankContactName
            // 
            this.txtBankContactName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtBankContactName.Location = new System.Drawing.Point(449, 49);
            this.txtBankContactName.Name = "txtBankContactName";
            this.txtBankContactName.Size = new System.Drawing.Size(204, 20);
            this.txtBankContactName.TabIndex = 7;
            // 
            // txtBranch
            // 
            this.txtBranch.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtBranch.Location = new System.Drawing.Point(449, 19);
            this.txtBranch.Name = "txtBranch";
            this.txtBranch.Size = new System.Drawing.Size(204, 20);
            this.txtBranch.TabIndex = 5;
            // 
            // txtBank
            // 
            this.txtBank.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtBank.Location = new System.Drawing.Point(113, 19);
            this.txtBank.Name = "txtBank";
            this.txtBank.Size = new System.Drawing.Size(185, 20);
            this.txtBank.TabIndex = 1;
            // 
            // lblBankContactNumber
            // 
            this.lblBankContactNumber.AutoSize = true;
            this.lblBankContactNumber.Location = new System.Drawing.Point(327, 81);
            this.lblBankContactNumber.Name = "lblBankContactNumber";
            this.lblBankContactNumber.Size = new System.Drawing.Size(84, 13);
            this.lblBankContactNumber.TabIndex = 8;
            this.lblBankContactNumber.Text = "Contact Number";
            // 
            // lblBankContactName
            // 
            this.lblBankContactName.AutoSize = true;
            this.lblBankContactName.Location = new System.Drawing.Point(327, 52);
            this.lblBankContactName.Name = "lblBankContactName";
            this.lblBankContactName.Size = new System.Drawing.Size(75, 13);
            this.lblBankContactName.TabIndex = 6;
            this.lblBankContactName.Text = "Contact Name";
            // 
            // lblBranch
            // 
            this.lblBranch.AutoSize = true;
            this.lblBranch.Location = new System.Drawing.Point(327, 22);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(61, 13);
            this.lblBranch.TabIndex = 4;
            this.lblBranch.Text = "Branch No.";
            // 
            // lblBankAddress
            // 
            this.lblBankAddress.AutoSize = true;
            this.lblBankAddress.Location = new System.Drawing.Point(7, 52);
            this.lblBankAddress.Name = "lblBankAddress";
            this.lblBankAddress.Size = new System.Drawing.Size(45, 13);
            this.lblBankAddress.TabIndex = 2;
            this.lblBankAddress.Text = "Address";
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.Location = new System.Drawing.Point(7, 22);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(32, 13);
            this.lblBank.TabIndex = 0;
            this.lblBank.Text = "Bank";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(284, 438);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(403, 438);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(522, 438);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(641, 438);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 484);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.grpBankDetails);
            this.Controls.Add(this.grpCustomerDetails);
            this.Controls.Add(this.grpCustomerList);
            this.Name = "frmCustomer";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpCustomerList.ResumeLayout(false);
            this.grpCustomerDetails.ResumeLayout(false);
            this.grpCustomerDetails.PerformLayout();
            this.grpBankDetails.ResumeLayout(false);
            this.grpBankDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCustomerList;
        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.GroupBox grpCustomerDetails;
        private System.Windows.Forms.GroupBox grpBankDetails;
        private System.Windows.Forms.DateTimePicker dtpExpDate;
        private System.Windows.Forms.TextBox txtCreditType;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtCreditLimit;
        private System.Windows.Forms.TextBox txtContactName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCreditType;
        private System.Windows.Forms.Label lblExpDate;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCreditLimit;
        private System.Windows.Forms.Label lblCreditCard;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.Label lblContactName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtBankAddress;
        private System.Windows.Forms.TextBox txtBankContactNumber;
        private System.Windows.Forms.TextBox txtBankContactName;
        private System.Windows.Forms.TextBox txtBranch;
        private System.Windows.Forms.TextBox txtBank;
        private System.Windows.Forms.Label lblBankContactNumber;
        private System.Windows.Forms.Label lblBankContactName;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.Label lblBankAddress;
        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rdoOther;
        private System.Windows.Forms.RadioButton rdoAmEx;
        private System.Windows.Forms.RadioButton rdomasterCard;
        private System.Windows.Forms.RadioButton rdoVisa;
        private System.Windows.Forms.TextBox txtAddresss;
        private System.Windows.Forms.CheckBox chkCreditcheck;
        private System.Windows.Forms.TextBox txtCardNumber;
    }
}

