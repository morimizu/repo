using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using A1Rentals.Types;
using Utilities;
using System.Diagnostics;


namespace A1Rentals.BOL
{
    

    public class cEquipment
    {

        #region "Properties"
        private bool mtrustedSource;
        public bool trustedSource
        {
            set
            {
                if ((new StackFrame(1).GetMethod().ReflectedType).Name == "cEquipmentSQL")
                    mtrustedSource = value;
                else
                    if (value == true)
                        throw new Exception("Cannot be set to true");
                    else
                        mtrustedSource = value;
            }
        }

        private int mEquipId;
        public int EquipId {
            get { return mEquipId; }
            set 
            {
                if (mtrustedSource == true)
                    mEquipId = value;
                else
                {
                    if (value == 0)
                    {
                        throw new Exception("Invalid EquipId");
                    }
                    mEquipId = value;
                }

            }
        }
       


        private string mSerial;
        public string Serial 
        {
            get { return mSerial; }
            set 
            {
                if (mtrustedSource == true)
                {
                    mSerial = value;
                }
                else
                {
                    if (value == string.Empty)
                    {
                        throw new Exception("Serial cannot be empty");
                    }
                    mSerial = value;
                }
            }
        }
        private decimal mRentPrice;
        public decimal RentPrice 
        {
            get { return mRentPrice; }
            set 
            {
                if (mtrustedSource == true)
                    mRentPrice = value;
                else
                {
                    
                    mRentPrice = value;
                }
            }
        }
        private decimal mListPrice;
        public decimal ListPrice 
        {
            get { return mListPrice; }
            set 
            {
                if (mtrustedSource == true)
                    mListPrice = value;
                else
                {
                   
                    mListPrice = value;
                }
            }
        }
    
        private StatusTypes mStatus;
        /// <summary>
        /// gets and sets the status of the equipment. changes the DateIn and DateOut depending on the status.
        /// </summary>
        public StatusTypes Status 
        {
            get { return mStatus; }
            set
            {
                if (mtrustedSource == true)
                    mStatus = value;
                else
                    
                if (value == StatusTypes.Out)
                    DateOut = DateTime.Today;
                if (value == StatusTypes.In || value==StatusTypes.Service)
                {
                    mDateOut = DateTime.Today;
                    mDateIn = DateTime.Today;

                    try
                    {
                        if (value == StatusTypes.Service)
                        {
                            throw new Exception("please select the date that the equipment is expected to be back in service with the return date");
                        }
                    }
                    finally
                    {
                        mStatus = value;
                    }
                }

            }
        }
       
        
        
        private DateTime mDateOut;
        /// <summary>
        /// Gets and sets DateOut. Calculates the Return date on set
        /// </summary>
        public DateTime DateOut 
        {
            get 
            {
                return mDateOut;
            }
            set 
            {
                if (mtrustedSource == true)
                    mDateOut = value;
                else
                {
                    mDateOut = value;
                    mDateIn = BusinessRules.CalculateReturnDate();
                }

            }
        }

        private DateTime mDateIn;
        /// <summary>
        /// gets and sets DateIn
        /// </summary>
        public DateTime DateIn 
        {
            get 
            {
                return mDateIn;
            }
            set 
            {
                if (mtrustedSource == true)
                    mDateIn = value;
                else
                   
                        mDateIn = value;
            }
        }

        private EquipmentTypes mCategory;
        public EquipmentTypes Category 
        {
            get { return mCategory; }
            set 
            {
                if (mtrustedSource == true)
                    mCategory = value;
                else
                    mCategory = value;
            }
        }

        #endregion

        #region "constructor"
        private cEquipment()
        { }
        #endregion

        #region "CRUD methods"

        /// <summary>
        /// Creates an empty cEquipment
        /// </summary>
        /// <returns>cEquipment</returns>
        public static cEquipment Create()
        {return new cEquipment(); }


        #endregion













    }
}
