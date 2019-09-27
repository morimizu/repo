using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using A1Rentals.BOL;
using A1Rentals.Types;
using A1Rentals.CU;

namespace A1Rentals
{
    public partial class frmReturns : Form
    {
        #region "constructor"

        public frmReturns()
        {
            InitializeComponent();

            SelectedCustomer = cCustomer.Create(); //Goes in form constructor after InitializeComponet
            

        }

       

        #endregion

        #region "form variables"

        private string input = null;
        private BindingList<cInvoice> invoiceList;
        BindingList<cEquipment> Equipmentlist;
        List<cEquipment> Returned = new List<cEquipment>();
        private cCustomer SelectedCustomer;
        private cInvoice SelectedInvoice;
        private cEquipment SelectedEquipment;
        private bool returned;
        #endregion

        #region "form event methods"

        private void frmReturns_Load(object sender, EventArgs e)
        {
            
        }

        private void dgvCurrentRentals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             try
            {
               BindingList<cEquipment> equipmentList = new BindingList<cEquipment>();
              
               for (int i = 0; i < invoiceList[dgvCurrentInvoices.SelectedRows[0].Index].Equipment.Count; i++)
               {
                   equipmentList.Add(invoiceList[dgvCurrentInvoices.SelectedRows[0].Index].Equipment[i]);
               }

               dgvEquipList.DataSource = equipmentList;

               txtInvoiceNo.Text = invoiceList[dgvCurrentInvoices.SelectedRows[0].Index].InvioceNum.ToString();
               dtpRent.Value = invoiceList[dgvCurrentInvoices.SelectedRows[0].Index].ReturnDate;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.StackTrace.ToString());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           cInvoiceCU.Insert(SelectedInvoice);
            foreach (cEquipment eq in Returned)
            {
               cEquipmentCU.Update(eq);
            }
            
        } // end btnUpdate_click

        private void cmbCustomers_TextUpdate(object sender, EventArgs e)
        {
            Search();
            cmbCustomers.DroppedDown = true;
        }

        private void dgvEquipList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            

            SelectedEquipment = Equipmentlist[e.RowIndex];
            this.chkReturned.CheckedChanged -= new System.EventHandler(this.chkReturned_CheckedChanged);
            if (SelectedEquipment.Status == StatusTypes.In)
                chkReturned.Checked = true;
            else
                chkReturned.Checked = false;
            this.chkReturned.CheckedChanged += new System.EventHandler(this.chkReturned_CheckedChanged);
            FillEquipmentFields();

        }

        private void dgvCurrentInvoices_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (invoiceList != null)
            {
                if (dgvCurrentInvoices.SelectedRows.Count > 0)
                {
                    SelectedInvoice = invoiceList[e.RowIndex];
                    FillInvoiceFields();
                   
                    Equipmentlist = new BindingList<cEquipment>();
                    for (int i = 0; i < SelectedInvoice.Equipment.Count; i++)
                        Equipmentlist.Add(SelectedInvoice.Equipment[i]);
                    dgvEquipList.DataSource = Equipmentlist;
                    dgvEquipList.SelectedRows[0].Selected = false;
                    dgvEquipList.Columns[2].DefaultCellStyle.Format = "c2";
                    dgvEquipList.Columns[3].DefaultCellStyle.Format = "c2";
                    dgvEquipList.Columns[6].DefaultCellStyle.Format = "d";
                    dgvEquipList.Columns[7].DefaultCellStyle.Format = "d";
                    dgvEquipList.Columns[0].Visible = false;
                    dgvEquipList.Columns[5].Visible = false;
                    btnUpdate.Enabled = true;


                }
            }

        }

        private void cmbCustomers_DropDown(object sender, EventArgs e)
        {
            Search();
        }

        private void cmbCustomers_SelectionChangeCommitted(object sender, EventArgs e)
        {
            foreach (object item in cmbCustomers.Items)
            {
                if (cmbCustomers.Text == (item as cCustomer).Name)
                {
                    SelectedCustomer = (cCustomer)item;
                    FillForm();
                    loadCustomerInfo();
                }

            }
            FillForm();
        }

        private void chkReturned_CheckedChanged(object sender, EventArgs e)
        {
            if (SelectedEquipment != null)
            {
                if (chkReturned.Checked)
                {
                    SelectedInvoice.Equipment.RemoveEquipment(SelectedEquipment);
                    Returned.Add(SelectedEquipment);
                    dgvEquipList.SelectedRows[0].DefaultCellStyle.ForeColor = Color.Red;
                    FillInvoiceFields();
                }
            }
        }
        #endregion

        #region "action methods"

        private void FillForm()
        {
            try
            {
                dgvCurrentInvoices.DataSource = null;
                invoiceList = new BindingList<cInvoice>();
                BindingList<cInvoice> invoiceList2 = new BindingList<cInvoice>();
                invoiceList2 = cInvoiceCU.Retrive(0.15m, Convert.ToInt32((cmbCustomers.SelectedItem as cCustomer).CustomerId));
               
                foreach (cInvoice i in invoiceList2)
                {
                    if (!InvoiceInlist(invoiceList,i.InvioceNum))
                        invoiceList.Add(i);
                }

                dgvCurrentInvoices.DataSource = invoiceList;
                dgvCurrentInvoices.Columns[1].Visible = false;
                dgvCurrentInvoices.SelectedRows[0].Selected = false;
                dgvCurrentInvoices.Columns[3].DefaultCellStyle.Format="c2";
                dgvCurrentInvoices.Columns[4].DefaultCellStyle.Format = "P";
                dgvCurrentInvoices.Columns[5].DefaultCellStyle.Format = "c2";
                dgvCurrentInvoices.Columns[6].DefaultCellStyle.Format = "c2";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace);
            }
        }

        private bool InvoiceInlist(BindingList<cInvoice> list, int invoiceId)
        {
            foreach (cInvoice i in list)
            {
                if (i.InvioceNum == invoiceId)
                    return true;
                    
            }
            return false;
        }

        private void Search()
        {
            input = cmbCustomers.Text;
            cmbCustomers.DataSource = null;
            List<cCustomer> lookup = cCustomerCU.RetriveSearch(cmbCustomers.Text);
            cmbCustomers.DataSource = lookup;
            cmbCustomers.DisplayMember = "Name";
            cmbCustomers.ValueMember = "customerId";
            cmbCustomers.Text = input;
            cmbCustomers.Select(input.Length, 0);
        }

        private void loadCustomerInfo()
        {
            txtCoName.Text = SelectedCustomer.Name;
            txtContactName.Text = SelectedCustomer.ContactFirstName + ' ' + SelectedCustomer.ContactLastName;
            txtContactNo.Text = SelectedCustomer.ContactNumber;
            txtCardNo.Text = SelectedCustomer.AccountNumber;
            txtExpDate.Text = Convert.ToString(SelectedCustomer.AccountExp);
            txtCreditLimit.Text = SelectedCustomer.AccountLimit.ToString("c");

            switch (SelectedCustomer.AccountType)
            {
                case "Visa":
                    rdoVisa.Checked = true;
                    break;
                case "Master Card":
                    rdoMaster.Checked = true;
                    break;
                case "AmEx":
                    rdoAmEx.Checked = true;
                    break;
                default:
                    rdoOther.Checked = true;
                    txtCreditType.Text = SelectedCustomer.AccountType;
                    break;
            } // end switch
        }

        public void FillInvoiceFields()
        {
            txtInvoiceNo.Text = SelectedInvoice.InvioceNum.ToString();
            txtRevSubtotal.Text = SelectedInvoice.Subtotal.ToString("c2");
            txtRevTax.Text = SelectedInvoice.Tax.ToString("c2");
            txtRevTotal.Text = SelectedInvoice.Total.ToString("c2");
        }

        public void FillEquipmentFields()
        {
            txtItemName.Text = SelectedEquipment.Serial;
            dtpDue.Value = SelectedEquipment.DateIn;
            dtpRent.Value = SelectedEquipment.DateOut;
            if (SelectedEquipment.Status == StatusTypes.In)
            {
                returned = true;
                chkReturned.Checked = true;
            }
            else
            {
                returned = false;
                chkReturned.Checked = false;
            }
        }

        public void ClearForm()
        {
            invoiceList.Clear();
            Equipmentlist.Clear();
        }
        
        #endregion

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
            txtCardNo.ResetText();
            txtCoName.ResetText();
            txtContactName.ResetText();
            txtContactNo.ResetText();
            txtCreditLimit.ResetText();
            txtCreditType.ResetText();
            txtExpDate.ResetText();
            txtInvoiceNo.ResetText();
            txtItemName.ResetText();
            txtRevSubtotal.ResetText();
            txtRevTax.ResetText();
            txtRevTotal.ResetText();
            chkReturned.Checked = false;
            dtpDue.Value = DateTime.Today;
            dtpRent.Value = DateTime.Today;
            dtpReturned.Value = DateTime.Today;
            btnUpdate.Enabled = false; 
            cmbCustomers.ResetText();
            cmbCustomers.Focus();
        }

       

       

       
        

       

        

        
        
    }
}
