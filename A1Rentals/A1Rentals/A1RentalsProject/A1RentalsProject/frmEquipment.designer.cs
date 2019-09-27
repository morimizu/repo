namespace A1Rentals
{
    partial class frmEquipment
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.grpItemDtls = new System.Windows.Forms.GroupBox();
            this.cmbDesc = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.dtpReturn = new System.Windows.Forms.DateTimePicker();
            this.dtpOut = new System.Windows.Forms.DateTimePicker();
            this.txtListValue = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.txtRentPrice = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtItemNumber = new System.Windows.Forms.TextBox();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.grpItems = new System.Windows.Forms.GroupBox();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.grpItemDtls.SuspendLayout();
            this.grpItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(536, 367);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(430, 367);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(324, 367);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(218, 367);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // grpItemDtls
            // 
            this.grpItemDtls.Controls.Add(this.cmbDesc);
            this.grpItemDtls.Controls.Add(this.cmbStatus);
            this.grpItemDtls.Controls.Add(this.Label1);
            this.grpItemDtls.Controls.Add(this.dtpReturn);
            this.grpItemDtls.Controls.Add(this.dtpOut);
            this.grpItemDtls.Controls.Add(this.txtListValue);
            this.grpItemDtls.Controls.Add(this.Label9);
            this.grpItemDtls.Controls.Add(this.txtRentPrice);
            this.grpItemDtls.Controls.Add(this.Label10);
            this.grpItemDtls.Controls.Add(this.Label12);
            this.grpItemDtls.Controls.Add(this.txtItemName);
            this.grpItemDtls.Controls.Add(this.txtItemNumber);
            this.grpItemDtls.Controls.Add(this.Label13);
            this.grpItemDtls.Controls.Add(this.Label14);
            this.grpItemDtls.Controls.Add(this.Label15);
            this.grpItemDtls.Controls.Add(this.Label16);
            this.grpItemDtls.Enabled = false;
            this.grpItemDtls.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grpItemDtls.Location = new System.Drawing.Point(218, 12);
            this.grpItemDtls.Name = "grpItemDtls";
            this.grpItemDtls.Size = new System.Drawing.Size(500, 322);
            this.grpItemDtls.TabIndex = 1;
            this.grpItemDtls.TabStop = false;
            this.grpItemDtls.Text = "Equipment Details";
            // 
            // cmbDesc
            // 
            this.cmbDesc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDesc.FormattingEnabled = true;
            this.cmbDesc.Location = new System.Drawing.Point(106, 154);
            this.cmbDesc.Name = "cmbDesc";
            this.cmbDesc.Size = new System.Drawing.Size(128, 21);
            this.cmbDesc.TabIndex = 15;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(104, 88);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(128, 21);
            this.cmbStatus.TabIndex = 9;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(16, 124);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(50, 13);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "Out Date";
            // 
            // dtpReturn
            // 
            this.dtpReturn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturn.Location = new System.Drawing.Point(354, 121);
            this.dtpReturn.Name = "dtpReturn";
            this.dtpReturn.Size = new System.Drawing.Size(130, 20);
            this.dtpReturn.TabIndex = 13;
            // 
            // dtpOut
            // 
            this.dtpOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOut.Location = new System.Drawing.Point(104, 121);
            this.dtpOut.Name = "dtpOut";
            this.dtpOut.Size = new System.Drawing.Size(126, 20);
            this.dtpOut.TabIndex = 11;
            // 
            // txtListValue
            // 
            this.txtListValue.Location = new System.Drawing.Point(354, 55);
            this.txtListValue.Name = "txtListValue";
            this.txtListValue.Size = new System.Drawing.Size(130, 20);
            this.txtListValue.TabIndex = 7;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label9.Location = new System.Drawing.Point(16, 58);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(65, 13);
            this.Label9.TabIndex = 4;
            this.Label9.Text = "Rental Price";
            // 
            // txtRentPrice
            // 
            this.txtRentPrice.Location = new System.Drawing.Point(104, 55);
            this.txtRentPrice.Name = "txtRentPrice";
            this.txtRentPrice.Size = new System.Drawing.Size(128, 20);
            this.txtRentPrice.TabIndex = 5;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label10.Location = new System.Drawing.Point(16, 157);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(83, 13);
            this.Label10.TabIndex = 14;
            this.Label10.Text = "Item Description";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label12.Location = new System.Drawing.Point(274, 124);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(65, 13);
            this.Label12.TabIndex = 12;
            this.Label12.Text = "Return Date";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(104, 22);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(128, 20);
            this.txtItemName.TabIndex = 1;
            // 
            // txtItemNumber
            // 
            this.txtItemNumber.Location = new System.Drawing.Point(354, 22);
            this.txtItemNumber.Name = "txtItemNumber";
            this.txtItemNumber.ReadOnly = true;
            this.txtItemNumber.Size = new System.Drawing.Size(130, 20);
            this.txtItemNumber.TabIndex = 3;
            this.txtItemNumber.TabStop = false;
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label13.Location = new System.Drawing.Point(286, 58);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(53, 13);
            this.Label13.TabIndex = 6;
            this.Label13.Text = "List Value";
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label14.Location = new System.Drawing.Point(16, 91);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(60, 13);
            this.Label14.TabIndex = 8;
            this.Label14.Text = "Item Status";
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label15.Location = new System.Drawing.Point(272, 25);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(67, 13);
            this.Label15.TabIndex = 2;
            this.Label15.Text = "Item Number";
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label16.Location = new System.Drawing.Point(16, 25);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(58, 13);
            this.Label16.TabIndex = 0;
            this.Label16.Text = "Item Name";
            // 
            // grpItems
            // 
            this.grpItems.Controls.Add(this.lstItems);
            this.grpItems.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grpItems.Location = new System.Drawing.Point(12, 12);
            this.grpItems.Name = "grpItems";
            this.grpItems.Size = new System.Drawing.Size(200, 422);
            this.grpItems.TabIndex = 0;
            this.grpItems.TabStop = false;
            this.grpItems.Text = "Equipment Name";
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.Location = new System.Drawing.Point(7, 20);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(187, 394);
            this.lstItems.TabIndex = 0;
            this.lstItems.SelectedIndexChanged += new System.EventHandler(this.lstItems_SelectedIndexChanged);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(19, 440);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(90, 23);
            this.btnReload.TabIndex = 6;
            this.btnReload.Text = "Load &List";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // frmEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 512);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.grpItemDtls);
            this.Controls.Add(this.grpItems);
            this.Name = "frmEquipment";
            this.Text = "Manage Equipment";
            this.Load += new System.EventHandler(this.frmEquipment_Load);
            this.grpItemDtls.ResumeLayout(false);
            this.grpItemDtls.PerformLayout();
            this.grpItems.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.Button btnEdit;
        internal System.Windows.Forms.GroupBox grpItemDtls;
        internal System.Windows.Forms.ComboBox cmbStatus;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.DateTimePicker dtpReturn;
        internal System.Windows.Forms.DateTimePicker dtpOut;
        internal System.Windows.Forms.TextBox txtListValue;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox txtRentPrice;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.TextBox txtItemName;
        internal System.Windows.Forms.TextBox txtItemNumber;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.GroupBox grpItems;
        internal System.Windows.Forms.ListBox lstItems;
        internal System.Windows.Forms.ComboBox cmbDesc;
        internal System.Windows.Forms.Button btnReload;
    }
}