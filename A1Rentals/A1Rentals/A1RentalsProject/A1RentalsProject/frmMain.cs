using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A1Rentals
{
    public partial class frmMain : Form
    {
        public static cSecurity currentUser;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            new frmSecurity().ShowDialog();

            tabControl1.TabPages.Add(new frmReports());
            tabControl1.TabPages.Add(new frmCustomer());
            if (currentUser.Access == "admin")
            {
                tabControl1.TabPages.Add(new frmEquipment());
            }
            tabControl1.TabPages.Add(new frmReturns());
            tabControl1.TabPages.Add(new frmRentals());

            foreach (MdiTabControl.TabPage tp in tabControl1.TabPages)
            {
                tp.CloseButtonVisible = false;
            }
            toolStripStatusLabel1.Text = "current user: " + currentUser.Name;

        }
    }
}
