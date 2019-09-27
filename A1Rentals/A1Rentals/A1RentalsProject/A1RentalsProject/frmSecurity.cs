using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using A1Rentals.BOL;
using A1Rentals.CU;

namespace A1Rentals
{
    public partial class frmSecurity : Form
    {
        public frmSecurity()
        {
            InitializeComponent();
        }

        private int logAttempt = 0;
        private bool valid = false;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (logAttempt == 2)
                    this.Close();

                cSecurity currentUser = new cSecurity();

               frmMain.currentUser = cSecurityC.checkLogin(txtUserName.Text, txtPassword.Text);

                if (currentUser.Name != string.Empty)
                {
                    valid = true;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                logAttempt++;
                label3.Visible = true;
                label3.Text = ex.Message;
                txtUserName.SelectAll();
                txtUserName.Focus();
            }
        }

        private void frmSecurity_Load(object sender, EventArgs e)
        {
            txtUserName.SelectAll();
            txtUserName.Focus();
            label3.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSecurity_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (valid == false)
                Application.Exit();

            // This form is added to the Mdi Parent form first - and only load other forms on valid login.
            // The valid variable is set to false by default so if this form is closed without
            // a valid login the application will close.
           
        }
    }
}
