using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1Rentals.BOL
{
    /// <summary>
    /// used to check business logic in the classes
    /// </summary>
    internal class BusinessRules
    {
        /// <summary>
        /// Calculates the return date for equipment to being 2 bussiness days from the current date 
        /// </summary>
        /// <returns></returns>
        internal static DateTime CalculateReturnDate()
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday||DateTime.Now.DayOfWeek == DayOfWeek.Friday)
            {
                return DateTime.Now.AddDays(3);
            }
            else
                return DateTime.Now.AddDays(2);
           
        }
        /// <summary>
        /// Returns an int that represents the number of days difference between the two dates
        /// A negative amount is a credit / A positive number will result in a new amount due when
        /// multiplied with the equip rent price.
        /// </summary>
        /// <param name="returnDate"></param>
        /// <param name="dueDate"></param>
        /// <returns></returns>
        internal static int invoiceDateDiffCalc(DateTime returnDate, DateTime dueDate)
        {
            int dateDiff;

            if (returnDate.Year == dueDate.Year)
            {
                dateDiff = dueDate.DayOfYear - returnDate.DayOfYear;
                return dateDiff;
            }
            return 4;
            
        }
        /// <summary>
        /// Return true if credit limit is less than the sum of equipment rented list price
        /// </summary>
        /// <param name="creditLimit">Value of Customer obj credit limit</param>
        /// <param name="equipPriceSum">Sum of list price of all equipment on current invoice</param>
        /// <returns>Boolean result of true</returns>
        internal static bool checkCreditLimit(decimal creditLimit, decimal equipPriceSum)
        {
            decimal creditUsed = 0; // value returned by executeNonQuery on checkCreditLimit stored 						proceedure

            if (creditLimit < (equipPriceSum + creditUsed))
                throw new Exception("Value of rented equipment exceeds available credit limit.");

            return true;
        }





    }
}
