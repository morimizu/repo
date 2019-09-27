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
    public partial class frmRentals : Form
    {
        #region "form Variable"

        private string input;
        private cCustomer SelectedCustomer;
        private cInvoice NewInvoice;
        List<cEquipment> equip = new List<cEquipment>();
        private BindingList<cEquipment> Equipment = new BindingList<cEquipment>();

        #endregion

        #region "constructor"

        public frmRentals()
        {
            InitializeComponent();
            SelectedCustomer = cCustomer.Create();
            NewInvoice = cInvoice.Create(0.14M);
           
        }

        #endregion

        #region "Form Event Methods"

        

        private void frmRentals_Load(object sender, EventArgs e)
        {
            
            dgvItemDetail.DataSource = Equipment;

            SetupDGV();

            cmbItems.DataSource = Enum.GetValues(typeof(EquipmentTypes));
            cmbItems.SelectedIndex = -1;
            
            equip.Clear();
            BindEquipmentList();
               
        }

        private void cmbCustomers_TextUpdate(object sender, EventArgs e)
        {
            Search();
            cmbCustomers.SelectedIndex = -1;
            cmbCustomers.DroppedDown = true;
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lstAvailItems.SelectedIndex != -1)
            {
                AddEquipment();
                btnSave.Enabled = true;
                btnRemove.Enabled = true;
                if (lstAvailItems.Items.Count == 0)
                    btnAdd.Enabled = false;
            }

        }

       
        private void cmbCustomers_DropDown(object sender, EventArgs e)
        {
            Search();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           cInvoiceCU.Insert(NewInvoice);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveEquipment();
            if (dgvItemDetail.Rows.Count == 0)
            {
                btnRemove.Enabled = false;
                btnSave.Enabled = false;
            }
        }

         private void cmbItems_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (NewInvoice.Customer == null)
                    throw new Exception("You must select a Customer first");
                if (cmbItems.SelectedItem != null)
                    FillItemList();
                if (lstAvailItems.Items.Count > 0)
                    btnAdd.Enabled = true;
                else
                    btnAdd.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbCustomers_SelectionChangeCommitted(object sender, EventArgs e)
        {
            foreach (object item in cmbCustomers.Items)
            {
                if (cmbCustomers.Text == (item as cCustomer).Name)
                {
                    FillForm();
                    NewInvoice.Customer = (cCustomer)cmbCustomers.SelectedItem;
                }

            }
        }
        #endregion

        #region "Action methods"

        private void SetupDGV()
        {
            dgvItemDetail.Columns["EquipId"].Visible = false;
            dgvItemDetail.Columns["Status"].Visible = false;
            dgvItemDetail.Columns["RentPrice"].DefaultCellStyle.Format = "c2";
            dgvItemDetail.Columns["ListPrice"].DefaultCellStyle.Format = "c2";
            dgvItemDetail.Columns["DateOut"].DefaultCellStyle.Format = "d";
            dgvItemDetail.Columns["DateIn"].DefaultCellStyle.Format = "d";
        }

        private void BindEquipmentList()
        {
            
            lstAvailItems.DataSource = null;
            lstAvailItems.DataSource = equip;
            lstAvailItems.DisplayMember = "Serial";
            lstAvailItems.ValueMember = "EquipId";
        }

        private void AddEquipment()
        {
            cEquipment selected = (cEquipment)lstAvailItems.SelectedItem;
            selected.Status = Types.StatusTypes.Out;
            Equipment.Add(selected);
            NewInvoice.Equipment.AddEquipment(selected);
            UpdateLabels();
            equip.Remove(selected);
            BindEquipmentList();
        }

        private void UpdateLabels()
        {
            lblSubtotal.Text = NewInvoice.Subtotal.ToString("c2");
            lblTax.Text = NewInvoice.Tax.ToString("c2");
            lblTotal.Text = NewInvoice.Total.ToString("c2");
        }

        private void RemoveEquipment()
        {
            cEquipment selected=null;
            foreach (cEquipment e in Equipment)
            { 
                if(e.EquipId==Convert.ToInt32(dgvItemDetail.SelectedRows[0].Cells["EquipId"].Value))
                {
                    selected=e;
                    break;
                }
            }
             
            selected.Status = Types.StatusTypes.In;
            Equipment.Remove(selected);
            NewInvoice.Equipment.RemoveEquipment(selected);
            UpdateLabels();
            if (selected.Category == (EquipmentTypes)cmbItems.SelectedItem)
            {
                equip.Add(selected);
                BindEquipmentList();
            }
            //lstAvailItems.Items.Add(dgvItemDetail.SelectedRow);
        }

        private void FillForm()
        {
            cCustomer selected = (cCustomer)cmbCustomers.SelectedItem;
            txtCompName.Text = selected.Name;
            txtCardNo.Text = selected.AccountNumber;
            txtContactName.Text = selected.ContactFirstName + " " + selected.ContactLastName;
            txtContactNumber.Text = selected.ContactNumber;
            txtCreditLimit.Text = selected.AccountLimit.ToString("c2");
            txtExpDate.Text = selected.AccountExp.ToString("d");
            switch (selected.AccountType)
            {
                case "visa":
                    {
                        rdoVisa.Checked = true;
                        break;
                    }
                case "Master Card":
                    {
                        rdoMaster.Checked = true;
                        break;
                    }
                case "AmEx":
                    {
                        rdoAmEx.Checked = true;
                        break;
                    }
                default:
                    {
                        rdoOther.Checked = true;
                        txtCreditType.Text= selected.AccountType;
                        break;
                    }
            }
            
        }

        private void GetBlankInvoice()
        {
            NewInvoice = cInvoice.Create(0.14M);

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

        private void FillItemList()
        {
            lstAvailItems.DataSource = null;
            equip = cEquipmentCU.RetreiveByCategory((EquipmentTypes)cmbItems.SelectedItem);
            List<cEquipment>equip2 = new List<cEquipment>();
            foreach (cEquipment e in equip)
            {
                equip2.Add(e);
            }

            foreach (cEquipment e in equip2)
            {
                if (IsInList(e))
                {
                    equip.Remove(e);
                }
                if (e.Status != StatusTypes.In)
                {
                    equip.Remove(e);
                }

            }
            lstAvailItems.DataSource = equip;
            lstAvailItems.DisplayMember = "Serial";
            lstAvailItems.ValueMember = "EquipId";

        }

        private bool IsInList(cEquipment e)
        {
            foreach (cEquipment equip1 in Equipment)
            {
                if (equip1.EquipId == e.EquipId)
                    return true;
            }

            return false;
        }
        
        #endregion

        

       

       
        }

        
        

        

        

               

       
    }

