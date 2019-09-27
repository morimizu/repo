using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using A1Rentals.BOL;
using A1Rentals.SQL;
using System.ComponentModel;

namespace A1Rentals.CU
{
    public class cInvoiceCU
    {
        public static BindingList<cInvoice> Retrive(decimal taxAmount,int customerId )
        {
            return cInvoiceSQL.Retrieve(taxAmount, customerId);
        }

        //public static int Close()
        //{ }

        public static int Insert(cInvoice inv)
        {
            return cInvoiceSQL.Insert(inv);
        }
    }
}
