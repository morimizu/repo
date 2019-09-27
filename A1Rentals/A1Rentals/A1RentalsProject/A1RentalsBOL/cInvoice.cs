using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace A1Rentals.BOL
{
   
    public class cInvoice
    {
       
        public int InvioceNum { get; set; }
        public cCustomer Customer { get; set; }
        public DateTime ReturnDate { get; set; }
        public EquipmentList Equipment;
        private decimal mSubtotal = 0;
        
        private cInvoice(decimal taxAmount)
        {
            Equipment = new EquipmentList(this);
            this.TaxAmount = taxAmount;
            
        }
        private cInvoice()
        { 
            Equipment = new EquipmentList(this);
            
        }

        public static cInvoice Create(decimal taxAmount)
        {
            return new cInvoice(taxAmount);
        }

        public static cInvoice Create()
        {
            return new cInvoice();
        }
        public decimal Subtotal
        {
            get
            {
                return mSubtotal;
               
            }
            set 
            {
                if ((new StackFrame(1).GetMethod().ReflectedType).Name == "EquipmentList")
                {
                    mSubtotal = value;
                }
                else
                    throw new Exception("Cannot set the subtotal");
            }
        }
        public decimal TaxAmount { get; set; } //tax percentage in decimal
        public decimal Tax
        {
            get { return (Subtotal * TaxAmount); }
        }
        public decimal Total
        {
            get { return Subtotal + Tax; }
        }

        

    }

    public class EquipmentList
    {
        private List<cEquipment> mEquipment = new List<cEquipment>();
        private cInvoice mInvoice;

        public EquipmentList(cInvoice Inv)
        {
            mInvoice = Inv;
        }
        public EquipmentList()
        {     
        }
        //internal void Add(cEquipment Equip)
        //{
        //    mEquipment.Add(Equip);
        //}
        /// <summary>
        /// Add Equipment to Invoice. If Equipment is returned 3 days late the full price of equipment is charged
        /// </summary>
        /// <param name="Equip">Equipment being Added</param>
        public void AddEquipment(cEquipment Equip)
        {
            mEquipment.Add(Equip);

            if (mInvoice.ReturnDate != Convert.ToDateTime("1/1/0001 12:00:00 AM"))
            {
                if (BusinessRules.invoiceDateDiffCalc(mInvoice.ReturnDate, Equip.DateIn) > 3)//If over gace period charge list amount
                    mInvoice.Subtotal += Equip.ListPrice;
                else
                {
                    mInvoice.Subtotal += Equip.RentPrice;
                    //sets the new return date to two bussiness days from today
                    Equip.Status = Types.StatusTypes.In;
                    Equip.Status = Types.StatusTypes.Out;
                }

            }
            else
            {
                Equip.Status = Types.StatusTypes.Out;
                mInvoice.Subtotal += Equip.RentPrice;
            }
        }
        /// <summary>
        /// Removes Equipment from Invoice. Gives credit if returned early
        /// </summary>
        /// <param name="Equip">the equipment object to be removed</param>
        public void RemoveEquipment(cEquipment Equip)
        {
            mEquipment.Remove(Equip);
            if (mInvoice.ReturnDate != Convert.ToDateTime("1/1/0001 12:00:00 AM"))
            {
                if (BusinessRules.invoiceDateDiffCalc(mInvoice.ReturnDate, Equip.DateIn) <= 0)//if returned early give credit of half rent amount
                {
                    mInvoice.Subtotal -= Equip.RentPrice + (Equip.RentPrice / 2M);
                    Equip.Status = Types.StatusTypes.In;
                }
                else
                {
                    mInvoice.Subtotal -= Equip.RentPrice;
                    Equip.Status = Types.StatusTypes.In;

                }
            }
            else
            {
                mInvoice.Subtotal -= Equip.RentPrice;
                Equip.Status = Types.StatusTypes.In;
            }
            
        }

        public int Count
        {
            get { return mEquipment.Count; }
        }

        public bool Contains(cEquipment e)
        {
            foreach (cEquipment eq in mEquipment)
            {
                if (eq.EquipId == e.EquipId)
                    return true;
            }
            return false;
        }
        public cEquipment this[int index]
        {
            get { return mEquipment[index]; }
            set { mEquipment[index] = value; }
        }
       

    
    }
}
