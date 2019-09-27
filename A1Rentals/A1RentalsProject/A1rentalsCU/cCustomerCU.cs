using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using A1Rentals.Types;
using A1Rentals.SQL;
using A1Rentals.BOL;
using System.Data;

namespace A1Rentals.CU
{
    /// <summary>
    /// Create Update and Delete from cCustomer
    /// </summary>
    public class cCustomerCU
    {

        public static cCustomer Retrieve(int customerId, retrieveCustomerData retrieveType)
        {
            if (customerId == 0)
                throw new Exception("You must enter a valid customer ID.");

            return cCustomerSQL.RetrieveData(retrieveType, customerId);
        }
        public static List<cCustomer> Retrieve(retrieveCustomerData retrieveType)
        {

            return cCustomerSQL.RetrieveData(retrieveType);
        }

        /// <summary>
        /// retrives a list of customers that match the charecters the user is typing in
        /// </summary>
        /// <param name="startswith">the charecters the user is typing</param>
        /// <returns>list of cCustomer</returns>
        public static List<cCustomer> RetriveSearch(string startswith)
        {
            return cCustomerSQL.retrieveSearch(retrieveCustomerData.getCustomerLookup, startswith);
        }
        /// <summary>
        /// Retrieves the Schema for the Customer table
        /// </summary>
        /// <returns>datatable</returns>
        public static DataTable RetrieveSchema()
        {
            return cCustomerSQL.RetrieveSchema();
        }

        /// <summary>
        /// Insert new cCustomer
        /// </summary>
        /// <param name="customer">customer object to be inserted</param>
        /// <returns>bool</returns>
        public static bool Insert(cCustomer customer)
        {
            if (customer.Valid)
            {
                int response = cCustomerSQL.insertData(customer);

                if (response == 1)
                    return true;
                else
                    return false;
            }
            else
                throw new Exception("One or more fields contain invalid data");
        }

        /// <summary>
        /// Updates the cCustomer object
        /// </summary>
        /// <param name="customer">the ccustomer object</param>
        /// <returns>bool</returns>
        public static bool Update(cCustomer customer)
        {
            if (customer.Valid)
            {
                int response = cCustomerSQL.updateData(customer);

                if (response == 1)
                    return true;
                else
                    return false;
            }
            else
                throw new Exception("One or more fields contain invalid data");
        }

        
    }
 }

   
