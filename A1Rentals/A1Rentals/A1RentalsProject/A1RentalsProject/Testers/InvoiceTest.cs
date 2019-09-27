using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using A1Rentals.BOL;
using System.ComponentModel;


namespace A1Rentals.Testers
{
    public partial class InvoiceTest : Form
    {
        cInvoice Inv;
        public InvoiceTest()
        {
            InitializeComponent();
            //Inv = new Invoice(Convert.ToDecimal(0.14));
        }

        private void InvoiceTest_Load(object sender, EventArgs e)
        {
            try
            {
                BindingList<cInvoice> i = cInvoiceSQL.Create(0.14M, 6);
                string text;
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); }
            //Inv.Equipment.AddEquipment(cEquipment.Retrive(22));
            //Inv.Equipment.AddEquipment(cEquipment.Retrive(22));
            ////Inv.Equipment.RemoveEquipment(Inv.Equipment[0]);
            //label1.Text = Inv.Subtotal.ToString("c2") + Environment.NewLine + Inv.Tax.ToString("c2") + Environment.NewLine + Inv.Total.ToString("c2");
        }
    }
}