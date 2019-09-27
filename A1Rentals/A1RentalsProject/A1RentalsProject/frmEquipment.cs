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
    public partial class frmEquipment : Form
    {
        #region "form variables"

        List<cEquipment> equip;//hold the list of current Equipment from the database
        bool loaded;//flag indicating if the form has been loaded for the first time
        DatabseMode mode;//Indicates if the form is Inserting or updating
        cEquipment SelectedEquip = cEquipment.Create();

        #endregion

        #region "form Constructor"

        public frmEquipment()
        {
            InitializeComponent();
           

        }

        #endregion

        #region "form event methods"

        //form event methods
        private void frmEquipment_Load(object sender, EventArgs e)
        {
            cmbStatus.DataSource = Enum.GetValues(typeof(StatusTypes));
            cmbDesc.DataSource = Enum.GetValues(typeof(EquipmentTypes));
            
            if (lstItems.Items.Count > 0)
            {
                lstItems.SelectedIndex = 0;
                EnableButtons(ButtonModes.RecordSelected);
            }
            else
                EnableButtons(ButtonModes.NorecordsSelected);

        }

        private void lstItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loaded)
                if (lstItems.SelectedIndex!=-1)
                    FillForm();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearForm();
            grpItemDtls.Enabled = true;
            txtItemName.Focus();
            EnableButtons(ButtonModes.EnableSave);
            mode = DatabseMode.Insert;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case DatabseMode.Update:
                    {
                        UpdateSelectedEquip();
                        GetSelected();
                        cEquipmentCU.Update(SelectedEquip);
                        break;
                    }
                case DatabseMode.Insert:
                    {
                        grpItemDtls.Enabled = false;
                        EnableButtons(ButtonModes.RecordSelected);
                        cEquipment Equip = cEquipment.Create();
                        Equip.Serial = txtItemName.Text;
                        Equip.RentPrice = Convert.ToDecimal(txtRentPrice.Text);
                        Equip.ListPrice = Convert.ToDecimal(txtListValue.Text);
                        Equip.Status = (StatusTypes)cmbStatus.SelectedItem;
                        Equip.DateOut = dtpOut.Value;
                        Equip.DateIn = dtpReturn.Value;
                        Equip.Category = (EquipmentTypes)cmbDesc.SelectedValue;
                        cEquipmentCU.Insert(Equip);
                        break;
                    }
            }
           
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ClearFormatting();
            grpItemDtls.Enabled = true;
            if ((StatusTypes)cmbStatus.SelectedItem == StatusTypes.In)
            {
                dtpOut.Enabled = false;
                dtpReturn.Enabled = false;
            }
            txtItemName.Focus();
            EnableButtons(ButtonModes.EnableSave);
            mode = DatabseMode.Update;
        }

       

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FillForm();
            EnableButtons(ButtonModes.RecordSelected);
            grpItemDtls.Enabled = false;
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loaded)
            {
                if (cmbStatus.SelectedValue != null)
                {
                    if ((StatusTypes)cmbStatus.SelectedItem == StatusTypes.In)
                    {
                        dtpOut.Enabled = false;
                        dtpReturn.Enabled = false;
                        dtpOut.Value = DateTime.Now;
                        dtpReturn.Value = DateTime.Now;
                    }
                    else
                    {
                        GetSelected();
                        dtpOut.Enabled = true;
                        dtpReturn.Enabled = true;
                        SelectedEquip.DateOut = DateTime.Now;
                        dtpOut.Value = SelectedEquip.DateOut;
                        dtpReturn.Value = SelectedEquip.DateIn;

                    }
                }
            }
        }
        #endregion
      
        #region "Action Methods"

        private void ClearForm()
        {
            cmbDesc.SelectedIndex = -1;
            txtItemName.ResetText();
            txtItemNumber.ResetText();
            txtListValue.ResetText();
            txtRentPrice.ResetText();
            cmbStatus.SelectedIndex = -1;
            dtpOut.Value = DateTime.Now;
            dtpReturn.Value = DateTime.Now;
        }

        private void ClearFormatting()
        {
            if (txtListValue.Text.Contains('$'))
                txtListValue.Text =  txtListValue.Text.Remove(0, 1);
            if (txtRentPrice.Text.Contains('$'))
                txtRentPrice.Text = txtRentPrice.Text.Remove(0, 1);
        }

        private void RefreshItems()
        {
            lstItems.DataSource = null;
            equip = cEquipmentCU.Retreive(retrieveEquipmentData.getEquipmentExcludNotAvail);
            lstItems.DataSource = equip;
            lstItems.DisplayMember = "Serial";
            lstItems.ValueMember = "EquipId";
            lstItems.SelectedIndex = -1;
            if (lstItems.Items.Count > 0)
            {
                lstItems.SelectedIndex = 0;
                EnableButtons(ButtonModes.RecordSelected);
            }
            else
            {
                EnableButtons(ButtonModes.NorecordsSelected);
                ClearForm();
            }
        }

        private void GetSelected()
        {
            if (lstItems.SelectedIndex != -1)
            {
                foreach (cEquipment e in equip)
                {
               
                    if (e.EquipId == (lstItems.SelectedItem as cEquipment).EquipId)
                    {
                        SelectedEquip.Serial = e.Serial;
                        SelectedEquip.RentPrice = e.RentPrice;
                        SelectedEquip.ListPrice = e.ListPrice;
                        SelectedEquip.Status = e.Status;
                        SelectedEquip.EquipId = e.EquipId;
                        SelectedEquip.Category = e.Category;
                        SelectedEquip.DateOut = e.DateOut;
                        SelectedEquip.DateIn = e.DateIn;
                    }
                }
                    
            }


        }

        private void FillForm()
        {
            GetSelected();
            txtItemName.Text = SelectedEquip.Serial;
            cmbDesc.SelectedItem = SelectedEquip.Category;
            txtItemNumber.Text = SelectedEquip.EquipId.ToString();
            txtListValue.Text = SelectedEquip.ListPrice.ToString("c2");
            txtRentPrice.Text = SelectedEquip.RentPrice.ToString("c2");
            cmbStatus.SelectedItem = SelectedEquip.Status;
            if (SelectedEquip.Status == StatusTypes.Service)
            {
                dtpOut.Enabled = false;
                dtpReturn.Enabled = true;
            }
            else
            {
                dtpOut.Enabled = false;
                dtpReturn.Enabled = false;
            }
            if (SelectedEquip.DateOut == Convert.ToDateTime("1/1/0001"))
                dtpOut.Value = DateTime.Today;
            else
                dtpOut.Value = SelectedEquip.DateOut;
            if (SelectedEquip.DateOut == Convert.ToDateTime("1/1/0001"))
                dtpReturn.Value = DateTime.Today;
            else
                dtpReturn.Value = SelectedEquip.DateIn;

        }

        private void UpdateSelectedEquip()
        {
            GetSelected();

            SelectedEquip.Serial = txtItemName.Text;
            ClearFormatting();
            SelectedEquip.RentPrice = Convert.ToDecimal(txtRentPrice.Text);
            SelectedEquip.ListPrice = Convert.ToDecimal(txtListValue.Text);
            SelectedEquip.Status = (StatusTypes)cmbStatus.SelectedItem;
            SelectedEquip.DateIn = dtpReturn.Value;
            SelectedEquip.DateOut = dtpOut.Value;
            SelectedEquip.Category = (EquipmentTypes)cmbDesc.SelectedValue;

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

        #endregion

        private void btnReload_Click(object sender, EventArgs e)
        {
            
            RefreshItems();
            if (!loaded)
            {
                loaded = true;
                btnReload.Text = "Refresh &List";
            }
            lstItems.SelectedIndex = -1;
        }

        
            
           
        }

    }

