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

namespace A1Rentals.Testers
{
    public partial class EquipTester1 : Form
    {
        public EquipTester1()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
           List<cEquipment> equip = EquipmentSQL.GetEquipment(retrieveEquipmentData.getEquipmentDetail);

           listBox1.DataSource = equip;
           listBox1.DisplayMember = "Name";
        }

       
    }
}
