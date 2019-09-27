using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Diagnostics;
using A1Rentals.Types;

namespace A1Rentals
{
    public class cCustomer
    {
      

        #region TrustedSource

           private static bool mTrusted = false;

           public bool Trusted
           {
               set
               {
                   if ((new StackFrame(1).GetMethod().ReflectedType).Name == "cEquipmentSQL")
                       mTrusted = value;
                   else
                   {
                       if (value == true)
                           throw new Exception("Invalid value for property.");
                       else
                           mTrusted = false;
                   }
               }
           }

           #endregion

        #region Valid

        private bool mValid = true;

        public bool Valid
        {
            get 
            {
                if (mValid == false || mName == string.Empty || mContactFirstName == string.Empty || mContactLastName == string.Empty || mContactNumber == string.Empty ||
                    mStreet == string.Empty || mCity == string.Empty || mProv == string.Empty || mPostalCode == string.Empty || mAccountNumber == string.Empty ||
                    mAccountExp == DateTime.Today || mAccountLimit == 0 || mBankName == string.Empty || mBranch == string.Empty || mBankContactName1 == string.Empty ||
                    mBankContactName2 == string.Empty || mBankContactNumber == string.Empty || mBankStreet == string.Empty || mBankCity == string.Empty || mBankProv == string.Empty ||
                    mBankPostalCode == string.Empty)
                    return false;
                else
                    return true;
            }
        }

        #endregion

        #region PrivateVariables

           private int mCustomerId;
        private string mName;
        private string mContactFirstName;
        private string mContactLastName;
        private string mContactNumber;
        private string mStreet;
        private string mCity;
        private string mProv;
        private string mPostalCode;
        private bool mCreditCheck;
        private string mAccountNumber;
        private string mAccountType;
        private DateTime mAccountExp;
        private decimal mAccountLimit;
        private string mBankName;
        private string mBranch;
        private string mBankContactName1;
        private string mBankContactName2;
        private string mBankContactNumber;
        private string mBankStreet;
        private string mBankCity;
        private string mBankProv;
        private string mBankPostalCode;
 
        #endregion

        #region Properties

        public int CustomerId
        {
            get { return mCustomerId; }
            set 
            {
             
                mCustomerId = value; 
            }
        }

        public string Name
        {
            get { return mName; }
            set
            {
                if (mTrusted == true)
                {
                    mName = value;
                    return;
                }
                else
                {
                    if (value == string.Empty)
                    {
                        mValid = false;
                        throw new Exception("Company Name field cannot be empty.");
                    }
                    mName = value;
                }
            }
        }

        public string ContactFirstName
        {
            get { return mContactFirstName; }
            set
            {
                if (mTrusted == true)
                {
                    mContactFirstName = value;
                    return;
                }
                else
                {
                    if (value == string.Empty)
                    {
                        mValid = false;
                        throw new Exception("Name field cannot be empty.");
                    }
                    mContactFirstName = value;
                }
            }
        }

        public string ContactLastName
        {
            get { return mContactLastName; }
            set
            {
                if (mTrusted == true)
                {
                    mContactLastName = value;
                    return;
                }
                else
                {
                    if (value == string.Empty)
                    {
                        mValid = false;
                        throw new Exception("Name field cannot be empty.");
                    }
                    mContactLastName = value;
                }
            }
        }

        public string ContactNumber
        {
            get { return mContactNumber; }
            set
            {
                if (mTrusted == true)
                {
                    mContactNumber = value;
                    return;
                }
                else
                {
                    if (mContactNumber != value && value != string.Empty)
                    {

                        cCustomerValidation.checkPhoneNumber(value);
                        mContactNumber = value;
                    }
                    
                }
            }
        }

        public string Street
        {
            get { return mStreet; }
            set
            {
                if (mTrusted == true)
                {
                    mStreet = value;
                    return;
                }
                else
                {
                    if (value == string.Empty)
                    {
                        mValid = false;
                        throw new Exception("Street field cannot be empty.");
                    }
                    mStreet = value;
                }
            }
        }

        public string City
        {
            get { return mCity; }
            set
            {
                if (mTrusted == true)
                {
                    mCity = value;
                    return;
                }
                else
                {
                    if (value == string.Empty)
                    {
                        mValid = false;
                        throw new Exception("City field cannot be empty.");
                    }
                    mCity = value;
                }
            }
        }

        public string Prov
        {
            get { return mProv; }
            set
            {
                if (mTrusted == true)
                {
                    mProv = value;
                    return;
                }
                else
                {
                    if (value == string.Empty)
                    {
                        mValid = false;
                        throw new Exception("Province field cannot be empty.");
                    }
                    mProv = value;
                }
            }
        }

        public string PostalCode
        {
            get { return mPostalCode; }
            set
            {
                if (mTrusted == true)
                {
                    mPostalCode = value;
                    return;
                }
                else
                {
                    if (mPostalCode != value && value != string.Empty)
                    {
                        cCustomerValidation.checkPostalCode(value);
                    }
                    mPostalCode = value;
                }
            }
        }

        public bool CreditCheck
        {
            get { return mCreditCheck; }
            set { mCreditCheck = value; }
        }

        public string AccountNumber
        {
            get { return mAccountNumber; }
            set
            {
                if (mTrusted == true)
                {
                    mAccountNumber = value;
                    return;
                }
                else
                {
                    if (value == string.Empty)
                    {
                        mValid = false;
                        throw new Exception("Account number field cannot be empty.");
                    }
                    mAccountNumber = value;
                }
            }
        }

        public string AccountType
        {
            get { return mAccountType; }
            set { mAccountType = value; }
        }

        public DateTime AccountExp
        {
            get { return mAccountExp; }
            set
            {
                if (mTrusted == true)
                {
                    mAccountExp = value;
                    return;
                }
                else
                {
                    if (mAccountExp != value)
                    {
                        cCustomerValidation.checkExpiryDate(value);
                    }
                    mAccountExp = value;
                }
            }
        }

        public decimal AccountLimit
        {
            get { return mAccountLimit; }
            set { mAccountLimit = value; }
        }

        public string BankName
        {
            get { return mBankName; }
            set
            {
                if (mTrusted == true)
                {
                    mBankName = value;
                    return;
                }
                else
                {
                    if (value == string.Empty)
                    {
                        mValid = false;
                        throw new Exception("Bank Name field cannot be empty.");
                    }
                    mBankName = value;
                }
            }
        }

        public string Branch
        {
            get { return mBranch; }
            set
            {
                if (mTrusted == true)
                {
                    mBranch = value;
                    return;
                }
                else
                {
                    if (value == string.Empty)
                    {
                        mValid = false;
                        throw new Exception("Branch field cannot be empty.");
                    }
                    mBranch = value;
                }
            }
        }

        public string BankContactName1
        {
            get { return mBankContactName1; }
            set
            {
                if (mTrusted == true)
                {
                    mBankContactName1 = value;
                    return;
                }
                else
                {
                    if (value == string.Empty)
                    {
                        mValid = false;
                        throw new Exception("Bank Contact Name field cannot be empty.");
                    }
                    mBankContactName1 = value;
                }
            }
        }

        public string BankContactName2
        {
            get { return mBankContactName2; }
            set
            {
                if (mTrusted == true)
                {
                    mBankContactName2 = value;
                    return;
                }
                else
                {
                    if (value == string.Empty)
                    {
                        mValid = false;
                        throw new Exception("Bank Contact Name field cannot be empty.");
                    }
                    mBankContactName2 = value;
                }
            }
        }

        public string BankContactNumber
        {
            get { return mBankContactNumber; }
            set
            {
                if (mTrusted == true)
                {
                    mBankContactNumber = value;
                    return;
                }
                else
                {
                    if (mBankContactNumber != value && value != string.Empty)
                    {
                        
                        cCustomerValidation.checkPhoneNumber(value);
                    }
                    mBankContactNumber = value;
                }
            }
        }

        public string BankStreet
        {
            get { return mBankStreet; }
            set
            {
                if (mTrusted == true)
                {
                    mBankStreet = value;
                    return;
                }
                else
                {
                    if (value == string.Empty)
                    {
                        mValid = false;
                        throw new Exception("Bank Street field cannot be empty.");
                    }
                    mBankStreet = value;
                }
            }
        }

        public string BankCity
        {
            get { return mBankCity; }
            set
            {
                if (mTrusted == true)
                {
                    mBankCity = value;
                    return;
                }

                if (value == string.Empty)
                {
                    mValid = false;
                    throw new Exception("Bank City field cannot be empty.");
                }
                mBankCity = value;
            }
        }

        public string BankProv
        {
            get { return mBankProv; }
            set
            {
                if (mTrusted == true)
                {
                    mBankProv = value;
                    return;
                }
                else
                {
                    if (value == string.Empty)
                    {
                        mValid = false;
                        throw new Exception("Bank Province field cannot be empty.");
                    }
                    mBankProv = value;
                }
            }
        }

        public string BankPostalCode
        {
            get { return mBankPostalCode; }
            set
            {
                if (mTrusted == true)
                {
                    mBankPostalCode = value;
                    return;
                }
                else
                {
                    if (mBankPostalCode != value && value != string.Empty)
                    {
                        cCustomerValidation.checkPostalCode(value);
                    }
                    mBankPostalCode = value;
                }
            }
        }

        #endregion

        private cCustomer()
        { }

        public static cCustomer Create()
        {
            cCustomer cust = new cCustomer();

            if (new StackFrame(1).GetMethod().ReflectedType.Name == "cCustomerSQL")
                mTrusted = true;
            else
                mTrusted = false;

            return cust;
        }

       
    }
}

