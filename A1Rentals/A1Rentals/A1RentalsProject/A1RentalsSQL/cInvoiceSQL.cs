using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using A1Rentals.DAL;
using A1Rentals.Types;
using System.ComponentModel;
using A1Rentals.BOL;

namespace A1Rentals.SQL
{
    public class cInvoiceSQL
    {
        
        public static BindingList<cInvoice> Retrieve(decimal taxAmount,int customerID)
        {
            BindingList<cInvoice> invoices = new BindingList<cInvoice>();
            List<ParamStruct> paramiters = new List<ParamStruct>();
            paramiters.Add(new ParamStruct("@customerId",customerID,System.Data.DbType.Int32,4,System.Data.ParameterDirection.Input));

            DbDataReader reader = DAL.DAL.ReadData("retrieveInvoiceData", paramiters);
            //EquipmentList equip = new EquipmentList();
            while (reader.Read())
            {
                cInvoice inv = cInvoice.Create(taxAmount);
                inv.ReturnDate = DateTime.Today;
                inv.InvioceNum = Convert.ToInt32(reader["invoiceId"]);
                inv.Customer = cCustomerSQL.RetrieveData(retrieveCustomerData.getCustomerById,(Convert.ToInt32(reader["customerId"])));
                inv.Equipment = EquipmentListSQl.Retrieve(inv);
                              
            }
            reader.Close();
            return invoices;
            
            // paramiters.Add(new ParamStruct("@invoiceId",
        }


        public static int Insert(cInvoice inv)
        {
            List<ParamStruct> paramiters = new List<ParamStruct>();
            if (inv.Equipment.Count != 0)
            {
                
                
                    paramiters.Add(new ParamStruct("@invoiceId", 0, System.Data.DbType.Int32, 4, System.Data.ParameterDirection.Output));
                    paramiters.Add(new ParamStruct("@tax", inv.Tax, System.Data.DbType.Decimal, 4, System.Data.ParameterDirection.Input));
                    paramiters.Add(new ParamStruct("@total", inv.Total, System.Data.DbType.Decimal, 4, System.Data.ParameterDirection.Input));
                    paramiters.Add(new ParamStruct("@subtotal", inv.Subtotal, System.Data.DbType.Decimal, 4, System.Data.ParameterDirection.Input));
                    paramiters.Add(new ParamStruct("@date", DateTime.Today, System.Data.DbType.Date, 4, System.Data.ParameterDirection.Input));
                    DAL.DAL.SendData("insertInvoicwData", paramiters);
                    inv.InvioceNum = Convert.ToInt32(paramiters[0].paramValue);
                    paramiters.Clear();
                
            }
            for (int i = 0; i < inv.Equipment.Count-1; i++)
            {
                if (inv.Equipment.Count !=0)
                {
                    
                        paramiters.Add(new ParamStruct("@dateReturn", inv.Equipment[i].DateIn, System.Data.DbType.Date, 3, System.Data.ParameterDirection.Input));
                        paramiters.Add(new ParamStruct("@invoiceId", inv.InvioceNum, System.Data.DbType.Int32, 4, System.Data.ParameterDirection.Input));
                        paramiters.Add(new ParamStruct("@equipmentId", inv.Equipment[i].EquipId, System.Data.DbType.Int32, 4, System.Data.ParameterDirection.Input));
                        paramiters.Add(new ParamStruct("@customerId", inv.Customer.CustomerId, System.Data.DbType.Int32, 4, System.Data.ParameterDirection.Input));

                        DAL.DAL.SendData("InsertInvoiceDetail", paramiters);
                    
                }
                cEquipmentSQL.Update(inv.Equipment[i]);
                paramiters.Clear();
            }
            return 1;
        }
    }
    public class EquipmentListSQl
    { 
        public static EquipmentList Retrieve(cInvoice invoice)
        {
            EquipmentList list = new EquipmentList(invoice);
            List<ParamStruct> paramiters = new List<ParamStruct>();
            paramiters.Add(new ParamStruct("@invoiceId", invoice.InvioceNum, System.Data.DbType.Int32, 4, System.Data.ParameterDirection.Input));
            DbDataReader reader = DAL.DAL.ReadData("retrieveInvoiceData", paramiters);
            while(reader.Read())
            {
                cEquipment equip = cEquipmentSQL.RetrieveEquipment(Convert.ToInt32(reader["equipmentId"]));
               
                    list.AddEquipment(equip);
            }
            return list;
        }
    }
}
    

