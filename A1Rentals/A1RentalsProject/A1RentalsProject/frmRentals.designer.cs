namespace A1Rentals
{
    partial class frmRentals
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpCustomers = new System.Windows.Forms.GroupBox();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.grpCustDtls = new System.Windows.Forms.GroupBox();
            this.txtCreditType = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtCreditLimit = new System.Windows.Forms.TextBox();
            this.rdoOther = new System.Windows.Forms.RadioButton();
            this.rdoAmEx = new System.Windows.Forms.RadioButton();
            this.rdoMaster = new System.Windows.Forms.RadioButton();
            this.rdoVisa = new System.Windows.Forms.RadioButton();
            this.txtCompName = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtExpDate = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.grpItemDtls = new System.Windows.Forms.GroupBox();
            this.dgvItemDetail = new System.Windows.Forms.DataGridView();
            this.grpInvoiceDtls = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.grpItems = new System.Windows.Forms.GroupBox();
            this.lstAvailItems = new System.Windows.Forms.ListBox();
            this.cmbItems = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.grpCustomers.SuspendLayout();
            this.grpCustDtls.SuspendLayout();
            this.grpItemDtls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemDetail)).BeginInit();
            this.grpInvoiceDtls.SuspendLayout();
            this.grpItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(547, 431);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(381, 431);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpCustomers
            // 
            this.grpCustomers.Controls.Add(this.cmbCustomers);
            this.grpCustomers.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grpCustomers.Location = new System.Drawing.Point(7, 12);
            this.grpCustomers.Name = "grpCustomers";
            this.grpCustomers.Size = new System.Drawing.Size(200, 55);
            this.grpCustomers.TabIndex = 0;
            this.grpCustomers.TabStop = false;
            this.grpCustomers.Text = "Customers";
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.Location = new System.Drawing.Point(6, 19);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(187, 21);
            this.cmbCustomers.TabIndex = 0;
            this.cmbCustomers.DropDown += new System.EventHandler(this.cmbCustomers_DropDown);
            this.cmbCustomers.SelectionChangeCommitted += new System.EventHandler(this.cmbCustomers_SelectionChangeCommitted);
            this.cmbCustomers.TextUpdate += new System.EventHandler(this.cmbCustomers_TextUpdate);
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
            this.grpCustDtls.Controls.Add(this.txtCompName);
            this.grpCustDtls.Controls.Add(this.Label7);
            this.grpCustDtls.Controls.Add(this.txtExpDate);
            this.grpCustDtls.Controls.Add(this.Label6);
            this.grpCustDtls.Controls.Add(this.Label5);
            this.grpCustDtls.Controls.Add(this.txtCardNo);
            this.grpCustDtls.Controls.Add(this.txtContactName);
            this.grpCustDtls.Controls.Add(this.txtContactNumber);
            this.grpCustDtls.Controls.Add(this.Label4);
            this.grpCustDtls.Controls.Add(this.Label3);
            this.grpCustDtls.Controls.Add(this.Label2);
            this.grpCustDtls.Controls.Add(this.Label1);
            this.grpCustDtls.Enabled = false;
            this.grpCustDtls.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grpCustDtls.Location = new System.Drawing.Point(213, 12);
            this.grpCustDtls.Name = "grpCustDtls";
            this.grpCustDtls.Size = new System.Drawing.Size(524, 171);
            this.grpCustDtls.TabIndex = 2;
            this.grpCustDtls.TabStop = false;
            this.grpCustDtls.Text = "Customer Details";
            // 
            // txtCreditType
            // 
            this.txtCreditType.Location = new System.Drawing.Point(390, 139);
            this.txtCreditType.Name = "txtCreditType";
            this.txtCreditType.Size = new System.Drawing.Size(128, 20);
            this.txtCreditType.TabIndex = 18;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label8.Location = new System.Drawing.Point(280, 142);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(90, 13);
            this.Label8.TabIndex = 17;
            this.Label8.Text = "Other Credit Type";
            // 
            // txtCreditLimit
            // 
            this.txtCreditLimit.Location = new System.Drawing.Point(106, 139);
            this.txtCreditLimit.Name = "txtCreditLimit";
            this.txtCreditLimit.Size = new System.Drawing.Size(161, 20);
            this.txtCreditLimit.TabIndex = 16;
            // 
            // rdoOther
            // 
            this.rdoOther.AutoSize = true;
            this.rdoOther.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdoOther.Location = new System.Drawing.Point(390, 110);
            this.rdoOther.Name = "rdoOther";
            this.rdoOther.Size = new System.Drawing.Size(95, 17);
            this.rdoOther.TabIndex = 14;
            this.rdoOther.TabStop = true;
            this.rdoOther.Text = "Other (Specify)";
            this.rdoOther.UseVisualStyleBackColor = true;
            // 
            // rdoAmEx
            // 
            this.rdoAmEx.AutoSize = true;
            this.rdoAmEx.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdoAmEx.Location = new System.Drawing.Point(303, 110);
            this.rdoAmEx.Name = "rdoAmEx";
            this.rdoAmEx.Size = new System.Drawing.Size(52, 17);
            this.rdoAmEx.TabIndex = 13;
            this.rdoAmEx.TabStop = true;
            this.rdoAmEx.Text = "AmEx";
            this.rdoAmEx.UseVisualStyleBackColor = true;
            // 
            // rdoMaster
            // 
            this.rdoMaster.AutoSize = true;
            this.rdoMaster.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdoMaster.Location = new System.Drawing.Point(186, 110);
            this.rdoMaster.Name = "rdoMaster";
            this.rdoMaster.Size = new System.Drawing.Size(82, 17);
            this.rdoMaster.TabIndex = 12;
            this.rdoMaster.TabStop = true;
            this.rdoMaster.Text = "Master Card";
            this.rdoMaster.UseVisualStyleBackColor = true;
            // 
            // rdoVisa
            // 
            this.rdoVisa.AutoSize = true;
            this.rdoVisa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdoVisa.Location = new System.Drawing.Point(106, 110);
            this.rdoVisa.Name = "rdoVisa";
            this.rdoVisa.Size = new System.Drawing.Size(45, 17);
            this.rdoVisa.TabIndex = 11;
            this.rdoVisa.TabStop = true;
            this.rdoVisa.Text = "Visa";
            this.rdoVisa.UseVisualStyleBackColor = true;
            // 
            // txtCompName
            // 
            this.txtCompName.Location = new System.Drawing.Point(106, 19);
            this.txtCompName.Name = "txtCompName";
            this.txtCompName.Size = new System.Drawing.Size(412, 20);
            this.txtCompName.TabIndex = 1;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label7.Location = new System.Drawing.Point(16, 52);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(75, 13);
            this.Label7.TabIndex = 2;
            this.Label7.Text = "Contact Name";
            // 
            // txtExpDate
            // 
            this.txtExpDate.Location = new System.Drawing.Point(390, 80);
            this.txtExpDate.Name = "txtExpDate";
            this.txtExpDate.Size = new System.Drawing.Size(70, 20);
            this.txtExpDate.TabIndex = 9;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label6.Location = new System.Drawing.Point(16, 112);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(59, 13);
            this.Label6.TabIndex = 10;
            this.Label6.Text = "Credit Card";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label5.Location = new System.Drawing.Point(319, 83);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(51, 13);
            this.Label5.TabIndex = 8;
            this.Label5.Text = "Exp Date";
            // 
            // txtCardNo
            // 
            this.txtCardNo.Location = new System.Drawing.Point(106, 79);
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(161, 20);
            this.txtCardNo.TabIndex = 7;
            // 
            // txtContactName
            // 
            this.txtContactName.Location = new System.Drawing.Point(106, 49);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(161, 20);
            this.txtContactName.TabIndex = 3;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(390, 49);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(128, 20);
            this.txtContactNumber.TabIndex = 5;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label4.Location = new System.Drawing.Point(16, 142);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(58, 13);
            this.Label4.TabIndex = 15;
            this.Label4.Text = "Credit Limit";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label3.Location = new System.Drawing.Point(16, 82);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(69, 13);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "Card Number";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(286, 52);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(84, 13);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Contact Number";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(16, 22);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(82, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Company Name";
            // 
            // grpItemDtls
            // 
            this.grpItemDtls.Controls.Add(this.dgvItemDetail);
            this.grpItemDtls.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grpItemDtls.Location = new System.Drawing.Point(255, 189);
            this.grpItemDtls.Name = "grpItemDtls";
            this.grpItemDtls.Size = new System.Drawing.Size(492, 220);
            this.grpItemDtls.TabIndex = 5;
            this.grpItemDtls.TabStop = false;
            this.grpItemDtls.Text = "Rental Item Details";
            // 
            // dgvItemDetail
            // 
            this.dgvItemDetail.AllowUserToAddRows = false;
            this.dgvItemDetail.AllowUserToDeleteRows = false;
            this.dgvItemDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemDetail.Location = new System.Drawing.Point(6, 19);
            this.dgvItemDetail.Name = "dgvItemDetail";
            this.dgvItemDetail.ReadOnly = true;
            this.dgvItemDetail.RowHeadersVisible = false;
            this.dgvItemDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemDetail.Size = new System.Drawing.Size(476, 187);
            this.dgvItemDetail.TabIndex = 0;
            // 
            // grpInvoiceDtls
            // 
            this.grpInvoiceDtls.Controls.Add(this.lblTotal);
            this.grpInvoiceDtls.Controls.Add(this.lblTax);
            this.grpInvoiceDtls.Controls.Add(this.lblSubtotal);
            this.grpInvoiceDtls.Controls.Add(this.Label18);
            this.grpInvoiceDtls.Controls.Add(this.Label17);
            this.grpInvoiceDtls.Controls.Add(this.Label11);
            this.grpInvoiceDtls.Enabled = false;
            this.grpInvoiceDtls.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grpInvoiceDtls.Location = new System.Drawing.Point(753, 12);
            this.grpInvoiceDtls.Name = "grpInvoiceDtls";
            this.grpInvoiceDtls.Size = new System.Drawing.Size(203, 397);
            this.grpInvoiceDtls.TabIndex = 9;
            this.grpInvoiceDtls.TabStop = false;
            this.grpInvoiceDtls.Text = "Invoice Details";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(74, 82);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(117, 23);
            this.lblTotal.TabIndex = 11;
            // 
            // lblTax
            // 
            this.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTax.Location = new System.Drawing.Point(74, 51);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(117, 23);
            this.lblTax.TabIndex = 9;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubtotal.Location = new System.Drawing.Point(74, 19);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(117, 23);
            this.lblSubtotal.TabIndex = 7;
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label18.Location = new System.Drawing.Point(31, 88);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(37, 13);
            this.Label18.TabIndex = 10;
            this.Label18.Text = "Total :";
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label17.Location = new System.Drawing.Point(37, 57);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(31, 13);
            this.Label17.TabIndex = 8;
            this.Label17.Text = "Tax :";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label11.Location = new System.Drawing.Point(16, 24);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(52, 13);
            this.Label11.TabIndex = 6;
            this.Label11.Text = "Subtotal :";
            // 
            // grpItems
            // 
            this.grpItems.Controls.Add(this.lstAvailItems);
            this.grpItems.Controls.Add(this.cmbItems);
            this.grpItems.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grpItems.Location = new System.Drawing.Point(7, 73);
            this.grpItems.Name = "grpItems";
            this.grpItems.Size = new System.Drawing.Size(200, 336);
            this.grpItems.TabIndex = 1;
            this.grpItems.TabStop = false;
            this.grpItems.Text = "Rental Items";
            // 
            // lstAvailItems
            // 
            this.lstAvailItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstAvailItems.FormattingEnabled = true;
            this.lstAvailItems.Location = new System.Drawing.Point(6, 46);
            this.lstAvailItems.Name = "lstAvailItems";
            this.lstAvailItems.Size = new System.Drawing.Size(186, 277);
            this.lstAvailItems.TabIndex = 1;
            // 
            // cmbItems
            // 
            this.cmbItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItems.FormattingEnabled = true;
            this.cmbItems.Location = new System.Drawing.Point(6, 19);
            this.cmbItems.Name = "cmbItems";
            this.cmbItems.Size = new System.Drawing.Size(187, 21);
            this.cmbItems.TabIndex = 0;
            this.cmbItems.SelectionChangeCommitted += new System.EventHandler(this.cmbItems_SelectionChangeCommitted);
            
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(213, 262);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(36, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = ">>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(213, 291);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(36, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "<<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // frmRentals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 512);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpCustomers);
            this.Controls.Add(this.grpCustDtls);
            this.Controls.Add(this.grpItemDtls);
            this.Controls.Add(this.grpInvoiceDtls);
            this.Controls.Add(this.grpItems);
            this.Name = "frmRentals";
            this.Text = "Rentals";
            this.Load += new System.EventHandler(this.frmRentals_Load);
            this.grpCustomers.ResumeLayout(false);
            this.grpCustDtls.ResumeLayout(false);
            this.grpCustDtls.PerformLayout();
            this.grpItemDtls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemDetail)).EndInit();
            this.grpInvoiceDtls.ResumeLayout(false);
            this.grpInvoiceDtls.PerformLayout();
            this.grpItems.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.GroupBox grpCustomers;
        internal System.Windows.Forms.ComboBox cmbCustomers;
        internal System.Windows.Forms.GroupBox grpCustDtls;
        internal System.Windows.Forms.TextBox txtCreditType;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox txtCreditLimit;
        internal System.Windows.Forms.RadioButton rdoOther;
        internal System.Windows.Forms.RadioButton rdoAmEx;
        internal System.Windows.Forms.RadioButton rdoMaster;
        internal System.Windows.Forms.RadioButton rdoVisa;
        internal System.Windows.Forms.TextBox txtCompName;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtExpDate;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtCardNo;
        internal System.Windows.Forms.TextBox txtContactName;
        internal System.Windows.Forms.TextBox txtContactNumber;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.GroupBox grpItemDtls;
        internal System.Windows.Forms.DataGridView dgvItemDetail;
        internal System.Windows.Forms.GroupBox grpInvoiceDtls;
        internal System.Windows.Forms.Label Label18;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.GroupBox grpItems;
        internal System.Windows.Forms.ListBox lstAvailItems;
        internal System.Windows.Forms.ComboBox cmbItems;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSubtotal;
        internal System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.Button btnRemove;
    }
}