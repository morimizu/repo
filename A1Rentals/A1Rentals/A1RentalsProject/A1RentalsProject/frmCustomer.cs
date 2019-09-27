using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using A1Rentals.Types;
using A1Rentals.CU;
using A1Rentals.BOL;
using System.Data;

namespace A1Rentals
{
    public partial class frmCustomer : Form
    {
        #region "Constructor"

        public frmCustomer()
        {
            InitializeComponent();
        }

        #endregion

        #region "Form Varables"

        List<cCustomer> custList = new List<cCustomer>();
        
        private cCustomer SelectedCustomer;
        private DatabseMode formState = DatabseMode.None;
        private ButtonModes buttonMode;
        private bool loaded;
        #endregion

        #region "Form event methods"

        private void Form1_Load(object sender, EventArgs e)
        {
            formSetup();
            
            
        }

        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (loaded)
                {
                    btnEdit.Enabled = true;

                    if (lstCustomers.SelectedIndex != -1)
                    {
                        ClearForm();
                        SelectedCustomer = (lstCustomers.SelectedItem as cCustomer);


                        txtName.Text = SelectedCustomer.Name;
                        txtContactName.Text = SelectedCustomer.ContactFirstName + ' ' + SelectedCustomer.ContactLastName;
                        txtContactNumber.Text = SelectedCustomer.ContactNumber;
                        txtAddresss.Text = SelectedCustomer.Street + "\r\n" + SelectedCustomer.City + " " + SelectedCustomer.Prov + "\r\n" + SelectedCustomer.PostalCode;

                        switch (SelectedCustomer.AccountType)
                        {
                            case "Visa":
                                rdoVisa.Checked = true;
                                break;
                            case "Master Card":
                                rdomasterCard.Checked = true;
                                break;
                            case "AmEx":
                                rdoAmEx.Checked = true;
                                break;
                            default:
                                rdoOther.Checked = true;
                                txtCreditType.Text = SelectedCustomer.AccountType;
                                break;
                        } // end switch

                        txtCardNumber.Text = SelectedCustomer.AccountNumber;
                        txtCreditLimit.Text = SelectedCustomer.AccountLimit.ToString("c");
                        dtpExpDate.Value = SelectedCustomer.AccountExp;
                        //creditCardExpiryControl1.Value = SelectedCustomer.AccountExp;
                        chkCreditcheck.Checked = SelectedCustomer.CreditCheck;
                        if (chkCreditcheck.Checked)
                        {
                            txtBank.Text = SelectedCustomer.BankName;
                            txtBankAddress.Text = SelectedCustomer.BankStreet + "\r\n" + SelectedCustomer.BankCity + " " + SelectedCustomer.BankProv + "\r\n" + SelectedCustomer.BankPostalCode;
                            txtBranch.Text = SelectedCustomer.Branch;
                            txtBankContactName.Text = SelectedCustomer.BankContactName1 + " " + SelectedCustomer.BankContactName2;
                            txtBankContactNumber.Text = SelectedCustomer.BankContactNumber;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } // end lstcustomers_selectedindexedchanged

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                EnableButtons(ButtonModes.EnableSave);

                formState = DatabseMode.Insert; // indicates that the form is in add state

                dtpExpDate.Value = DateTime.Today;
                chkCreditcheck.Checked = false;

                ClearForm();


                if (formState != DatabseMode.None)
                    grpCustomerDetails.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        } // end btnAdd_click

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                formState = DatabseMode.Update; //indicates that the form is in the edit state

                EnableButtons(ButtonModes.EnableSave);

                grpCustomerDetails.Enabled = true;
                grpBankDetails.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool reccount = false;
            cCustomer customer = cCustomer.Create();

            try
            {
                if (formState == DatabseMode.Update)
                    customer.CustomerId = (int)lstCustomers.SelectedValue;
                
                customer.Name = txtName.Text;

                string[] contactName = Regex.Split(txtContactName.Text, " ");

                customer.ContactFirstName = contactName[0];
                customer.ContactLastName = contactName[1];
                customer.ContactNumber = txtContactNumber.Text;

                string[] addresslines = Regex.Split(txtAddresss.Text, "\r\n");
                string[] addresslines2 = Regex.Split(addresslines[1], " ");

                customer.Street = addresslines[0];
                customer.City = addresslines2[0];
                customer.Prov = addresslines2[1];
                customer.PostalCode = addresslines[2];

                customer.CreditCheck = chkCreditcheck.Checked;
                customer.AccountNumber = txtCardNumber.Text;

                foreach (Control ctl in grpCustomerDetails.Controls)
                {
                    if (ctl is RadioButton)
                        if ((ctl as RadioButton).Checked)
                            if (ctl.Text == "Other (Specify)")
                                customer.AccountType = txtCreditType.Text;
                            else
                            customer.AccountType = ctl.Text;
                }
            
                customer.AccountExp = dtpExpDate.Value;
                string creditLimit;
                if(txtCreditLimit.Text.StartsWith("$"))
                   creditLimit  = txtCreditLimit.Text.Remove(0, 1);
                else
                    creditLimit = txtCreditLimit.Text;
                customer.AccountLimit = Convert.ToDecimal(creditLimit);
                if (customer.CreditCheck)
                {
                    customer.BankName = txtBank.Text;
                    customer.Branch = txtBranch.Text;

                    string[] bankContact = Regex.Split(txtBankContactName.Text, " ");

                    customer.BankContactName1 = bankContact[0];
                    customer.BankContactName2 = bankContact[1];
                    customer.BankContactNumber = txtBankContactNumber.Text;

                    string[] bankaddress1 = Regex.Split(txtBankAddress.Text, "\r\n");
                    string[] bankaddress2 = Regex.Split(bankaddress1[1], " ");

                    customer.BankStreet = bankaddress1[0];
                    customer.BankCity = bankaddress2[0];
                    customer.BankProv = bankaddress2[1];
                    customer.BankPostalCode = bankaddress1[2];
                }
                switch (formState)
                {
                    case  DatabseMode.Update:
                        reccount = cCustomerCU.Update(customer);
                        break;
                    case  DatabseMode.Insert:
                        reccount = cCustomerCU.Insert(customer);
                        break;
                } // end switch

                if (reccount)
                {
                    MessageBox.Show("Record has been saved.");
                    formState = DatabseMode.None; // return form state to default
                } // end if
                else
                    throw new DataException("Error - Record not saved.");

                formSetup();
            } // end try

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }

        }

        #endregion

        #region "action methods"

        private void formSetup()
        {
            custList = cCustomerCU.Retrieve(retrieveCustomerData.getCustomerDetail);
            lstCustomers.DataSource = null;
            lstCustomers.DataSource = custList;
            lstCustomers.ValueMember = "CustomerId";
            lstCustomers.DisplayMember = "Name";
            lstCustomers.SelectedIndex = -1;
           

            CheckButtonMode();

                grpCustomerDetails.Enabled = false;
            grpBankDetails.Enabled = false;
            SetMaxLengths();
            loaded = true;
        }

        private void EnableButtons(ButtonModes mode)
        {
            switch (mode)
            {
                case ButtonModes.NorecordsSelected:
                    {
                        btnAdd.Enabled = true;
                        btnCancel.Enabled = false;
                        btnEdit.Enabled = false;
                        btnSave.Enabled = false;
                        break;
                    }
                case ButtonModes.EnableSave:
                    {
                        btnAdd.Enabled = false;
                        btnCancel.Enabled = true;
                        btnEdit.Enabled = false;
                        btnSave.Enabled = true;
                        break;
                    }
                case ButtonModes.RecordSelected:
                    {
                        btnAdd.Enabled = true;
                        btnCancel.Enabled = false;
                        btnEdit.Enabled = true;
                        btnSave.Enabled = false;
                        break;
                    }
            }
        }

        private void CheckButtonMode()
        {
            if (lstCustomers.Items.Count > 0)
                EnableButtons(ButtonModes.RecordSelected);
            else
                EnableButtons(ButtonModes.NorecordsSelected);
        }

        private void ClearForm()
        {
            foreach (Control ctl in grpCustomerDetails.Controls)
            {
                if (ctl is TextBox)
                    (ctl as TextBox).ResetText();
            }

            foreach (Control ctl2 in grpBankDetails.Controls)
            {
                if (ctl2 is TextBox)
                    (ctl2 as TextBox).ResetText();
            }
        }

        private void SetMaxLengths()
        {
            DataTable schema = cCustomerCU.RetrieveSchema();
            txtName.MaxLength = schema.Columns["name"].MaxLength;
            txtContactNumber.MaxLength = schema.Columns["contactNumber"].MaxLength;
            txtCardNumber.MaxLength = schema.Columns["accountNumber"].MaxLength;
            txtCreditType.MaxLength = schema.Columns["accountType"].MaxLength;
        }
        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            int currentindex = lstCustomers.SelectedIndex;
            formSetup();
            CheckButtonMode();
            lstCustomers.SelectedIndex = currentindex;
        }

        private void chkCreditcheck_CheckedChanged(object sender, EventArgs e)
        {
            if (formState != DatabseMode.None)
            {
                if (chkCreditcheck.Checked)
                    grpBankDetails.Enabled = true;
                else
                    grpBankDetails.Enabled = false;
            }
        }

        private void rdo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoOther.Checked)
                txtCreditType.Enabled = true;
            else
            {
                txtCreditType.Enabled = false;
                txtCreditType.Focus();
            }
        }

        

        

       

    }
}
