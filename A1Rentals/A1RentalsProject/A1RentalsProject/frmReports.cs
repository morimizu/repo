using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Common;
using A1Rentals.BOL;
using A1Rentals.Types;
using A1Rentals.Properties;
using A1Rentals.CU;

namespace A1Rentals
{
    public partial class frmReports : Form
    {
        #region "constuctor"

        public frmReports()
        {
            InitializeComponent();
        }

        #endregion

        #region "Form Event Methods"

        private void frmReports_Load(object sender, EventArgs e)
        {
            try
            {
                List<cEquipment> equipment = new List<cEquipment>();
                List<cCustomer> customer = new List<cCustomer>();

                customer = cCustomerCU.Retrieve(retrieveCustomerData.getCustomerIdName);
                equipment = cEquipmentCU.Retreive(retrieveEquipmentData.getEquipmentIdSerial);
                
                loadRentalTab(equipment, customer);
                loadCustomerTab(customer);
                loadEquipmentTab(equipment);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace);
            }
        }

        private void btnGetCustomer_Click(object sender, EventArgs e)
        {
            decimal revenue = 0;
            DataTable custReport = cReportsC.getCustomerReport(Convert.ToInt32(cmbCoNameHST.SelectedValue), dtpCustStart.Value, dtpCustEnd.Value);
            dgvCustomer.DataSource = custReport;

            for (int i = 0; i < custReport.Rows.Count; i++)
            {
                revenue += Convert.ToDecimal(custReport.Rows[i]["subtotal"]);
            }

            txtCustRevenue.Text = revenue.ToString("c");
        }

        private void btnGetOverdue_Click(object sender, EventArgs e)
        {
            DateTime start = dtpStart.Value;
            DateTime end = dtpEnd.Value;

            if (txtDaysOver.Text == string.Empty)
                txtDaysOver.Text = Convert.ToString(0);

            if (dtpStart.Value > dtpEnd.Value)
                throw new Exception("Start date cannot be later than end date.");

            DataTable report = cReportsC.getOverdueReport(Convert.ToInt32(cmbCoNameHST.SelectedValue), 0, dtpStart.Value, dtpEnd.Value, Convert.ToInt32(txtDaysOver.Text));
            dgvOverdue.DataSource = report;
        }

        private void btnGetEquipment_Click(object sender, EventArgs e)
        {
            decimal revenue = 0;
            DataTable equipReport = cReportsC.getEquipmentReport(Convert.ToInt32(cmbCoNameHST.SelectedValue), dtpCustStart.Value, dtpCustEnd.Value);
            dgvEquipment.DataSource = equipReport;

            for (int i = 0; i < equipReport.Rows.Count; i++)
            {
                revenue += Convert.ToDecimal(equipReport.Rows[i]["subtotal"]);
            }

            txtCustRevenue.Text = revenue.ToString("c");
        }

        #endregion

        #region "Action Methods" 

        private void loadRentalTab(List<cEquipment> equipment, List<cCustomer> customer)
        {
            cmbCompanyName.DataSource = customer;
            cmbCompanyName.ValueMember = "customerId";
            cmbCompanyName.DisplayMember = "name";

            cmbEquipment.DataSource = equipment;
            cmbEquipment.ValueMember = "EquipId";
            cmbEquipment.DisplayMember = "Serial";
        }

        private void loadCustomerTab(List<cCustomer> customer)
        {
            cmbCoNameHST.DataSource = customer;
            cmbCoNameHST.ValueMember = "customerId";
            cmbCoNameHST.DisplayMember = "name";
        }

        private void loadEquipmentTab(List<cEquipment> equipment)
        {
            cmbEquipHST.DataSource = equipment;
            cmbEquipHST.ValueMember = "EquipId";
            cmbEquipHST.DisplayMember = "Serial";
        }

        #endregion
        
    }
}
