using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace A1Rentals
{
    class cCustomerValidation
    {
        
        public static bool checkExpiryDate(DateTime value)
        {
            string errorMsg = value + " - Expiry date must be at least 3 months from current date.";
            
            if (value > DateTime.Today.AddMonths(3))
            {
                return true;                
            }

            throw new Exception(errorMsg);
        }

        public static bool checkPostalCode(string value)
        { 
            string errorMsg = value + " - Is not a valid postal code.";
            Regex pc = new Regex(@"^[a-zA-Z]{1}[0-9]{1}[a-zA-Z]{1}(\-| |){1}[0-9]{1}[a-zA-Z]{1}[0-9]{1}$");

            if (pc.IsMatch(value))
            {
                return true;
            }

            throw new Exception(errorMsg);
        }

        public static bool checkPhoneNumber(string value)
        {
            string errorMsg = value + " - Is not is the proper format of (555)555-5555.";
            Regex phone = new Regex(@"^[\\(]{0,1}([0-9]){3}[\\)]{0,1}[ ]?([^0-1]){1}([0-9]){2}[ ]?[-]?[ ]?([0-9]){4}[ ]*((x){0,1}([0-9]){1,5}){0,1}$");

            if (phone.IsMatch(value))
            {
                return true;
            }

            throw new Exception(errorMsg);
        }
    }
}
