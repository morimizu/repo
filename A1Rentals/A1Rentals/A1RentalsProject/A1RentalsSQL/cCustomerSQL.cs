using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using A1Rentals.BOL;
using A1Rentals.DAL;
using A1Rentals.Types;


namespace A1Rentals.SQL
{
    /// <summary>
    /// Database access for the cCustomer object
    /// </summary>
    public class cCustomerSQL
    {
        /// <summary>
        /// Creates cCustomer objects from the database
        /// </summary>
        /// <param name="retrieveType">enum representing the way to retrieve the data from the database</param>
        /// <returns>list of cCustomer</cCustomer>"</returns>
        public static List<cCustomer> RetrieveData(retrieveCustomerData retrieveType)
        {
            ParamStruct param1 = new ParamStruct("@retrieveType", retrieveType, DbType.Int32, 4, ParameterDirection.Input);

            string sproc = "retrieveCustomerData";

            List<ParamStruct> paramList = new List<ParamStruct>();

            paramList.Add(param1);

            DbDataReader dr = DAL.DAL.ReadData(sproc, paramList);

            List<cCustomer> customerList = Repackage(dr, retrieveType);

            if (customerList.Count == 0)
                throw new DataException("No Records Found");
            else
                return customerList;

        } // end RetrieveData

        /// <summary>
        /// creates a single cCustomer from database
        /// </summary>
        /// <param name="retrieveType">way to retieve data</param>
        /// <param name="custId">ID for customer to create</param>
        /// <returns>cCustomer</returns>
        public static cCustomer RetrieveData(retrieveCustomerData retrieveType, int custId)
        {
            List<ParamStruct> paramList = new List<ParamStruct>();

            ParamStruct param0 = new ParamStruct("@customerId", custId, DbType.Int32, 4, ParameterDirection.Input);
            paramList.Add(param0);
            ParamStruct param1 = new ParamStruct("@retrieveType", retrieveType, DbType.Int32, 4, ParameterDirection.Input);
            paramList.Add(param1);

            string sproc = "retrieveCustomerData";          

            DbDataReader dr = DAL.DAL.ReadData(sproc, paramList);

            List<cCustomer> customerList = Repackage(dr, retrieveType);

            if (customerList.Count == 0)
                throw new DataException("No Records Found");
            else
                return customerList[0];
        } // end RetriveData - Customer detail
        /// <summary>
        /// gets the lookup for the cCustomer
        /// </summary>
        /// <param name="type">way to retrive data</param>
        /// <param name="startswith">charecters that the customer's name starts with</param>
        /// <returns>list of cCustomers</returns>
        public static List<cCustomer> retrieveSearch(retrieveCustomerData type, string startswith)
        {
            List<ParamStruct> paramList = new List<ParamStruct>();

            ParamStruct param0 = new ParamStruct("@startswith", startswith, DbType.String, 4, ParameterDirection.Input);
            paramList.Add(param0);
            ParamStruct param1 = new ParamStruct("@retrieveType", type, DbType.Int32, 20, ParameterDirection.Input);
            paramList.Add(param1);

            string sproc = "retrieveCustomerData";

            DbDataReader dr = DAL.DAL.ReadData(sproc, paramList);

            List<cCustomer> customerList = Repackage(dr, type);

                return customerList;
        }
        /// <summary>
        /// gets the schema for the Customers table
        /// </summary>
        /// <returns>DataTable</returns>
        public static DataTable RetrieveSchema()
        {
            string sproc = "retrieveCustomerData";

            ParamStruct param1 = new ParamStruct("@retrieveType", retrieveCustomerData.getCustomerSchema, DbType.Int32, 4, ParameterDirection.Input);
            List<ParamStruct> paramList = new List<ParamStruct>();

            paramList.Add(param1);

            DataTable schema = DAL.DAL.ReadTable(sproc, paramList);

            return schema;
        } // end RetrieveSchema

        /// <summary>
        /// Updates the Customer Table
        /// </summary>
        /// <param name="customer">customer Id to update</param>
        /// <returns>int</returns>
        public static int updateData(cCustomer customer)
        {
            int recCount;
            string sproc = "updateCustomerData";
            List<ParamStruct> paramList = new List<ParamStruct>();

            ParamStruct param0 = new ParamStruct("@customerId", customer.CustomerId, DbType.Int32, 4, ParameterDirection.Input);
            paramList.Add(param0);

            ParamStruct param1 = new ParamStruct("@name", customer.Name, DbType.String, 50, ParameterDirection.Input);
            paramList.Add(param1);

            ParamStruct param2 = new ParamStruct("@contactFirstName", customer.ContactFirstName, DbType.String, 20, ParameterDirection.Input);
            paramList.Add(param2);

            ParamStruct param3 = new ParamStruct("@contactLastName", customer.ContactLastName, DbType.String, 30, ParameterDirection.Input);
            paramList.Add(param3);

            ParamStruct param4 = new ParamStruct("@contactNumber", customer.ContactNumber, DbType.String, 13, ParameterDirection.Input);
            paramList.Add(param4);

            ParamStruct param5 = new ParamStruct("@street", customer.Street, DbType.String, 30, ParameterDirection.Input);
            paramList.Add(param5);

            ParamStruct param6 = new ParamStruct("@city", customer.City, DbType.String, 20, ParameterDirection.Input);
            paramList.Add(param6);

            ParamStruct param7 = new ParamStruct("@prov", customer.Prov, DbType.String, 2, ParameterDirection.Input);
            paramList.Add(param7);

            ParamStruct param8 = new ParamStruct("@postalCode", customer.PostalCode, DbType.String, 7, ParameterDirection.Input);
            paramList.Add(param8);

            ParamStruct param9 = new ParamStruct("@creditCheck", customer.CreditCheck, DbType.Boolean, 1, ParameterDirection.Input);
            paramList.Add(param9);

            ParamStruct param10 = new ParamStruct("@accountNumber", customer.AccountNumber, DbType.String, 15, ParameterDirection.Input);
            paramList.Add(param10);

            ParamStruct param11 = new ParamStruct("@accountType", customer.AccountType, DbType.String, 15, ParameterDirection.Input);
            paramList.Add(param11);

            ParamStruct param12 = new ParamStruct("@accountExpiry", customer.AccountExp, DbType.Date, 4, ParameterDirection.Input);
            paramList.Add(param12);

            ParamStruct param13 = new ParamStruct("@accountLimit", customer.AccountLimit, DbType.Currency, 4, ParameterDirection.Input);
            paramList.Add(param13);

            if (customer.CreditCheck)
            {
                ParamStruct param14 = new ParamStruct("@bankName", customer.BankName, DbType.String, 30, ParameterDirection.Input);
                paramList.Add(param14);

                ParamStruct param15 = new ParamStruct("@branch", customer.Branch, DbType.String, 5, ParameterDirection.Input);
                paramList.Add(param15);

                ParamStruct param16 = new ParamStruct("@bankContactName1", customer.BankContactName1, DbType.String, 20, ParameterDirection.Input);
                paramList.Add(param16);

                ParamStruct param17 = new ParamStruct("@bankContactName2", customer.BankContactName2, DbType.String, 30, ParameterDirection.Input);
                paramList.Add(param17);

                ParamStruct param18 = new ParamStruct("@bankContactNumber", customer.BankContactNumber, DbType.String, 13, ParameterDirection.Input);
                paramList.Add(param18);

                ParamStruct param19 = new ParamStruct("@bankStreet", customer.BankStreet, DbType.String, 30, ParameterDirection.Input);
                paramList.Add(param19);

                ParamStruct param20 = new ParamStruct("@bankCity", customer.BankCity, DbType.String, 20, ParameterDirection.Input);
                paramList.Add(param20);

                ParamStruct param21 = new ParamStruct("@bankProv", customer.BankProv, DbType.String, 2, ParameterDirection.Input);
                paramList.Add(param21);

                ParamStruct param22 = new ParamStruct("@bankPostalCode", customer.BankPostalCode, DbType.String, 7, ParameterDirection.Input);
                paramList.Add(param22);
            }
            recCount = DAL.DAL.SendData(sproc, paramList);

            return recCount;

        } // end UpdateData

        /// <summary>
        /// Inserts a new customer record
        /// </summary>
        /// <param name="customer">the customer object to reate the record from</param>
        /// <returns>int</returns>
        public static int insertData(cCustomer customer)
        {

            int recCount;
            string sproc = "insertCustomerData";
            List<ParamStruct> paramList = new List<ParamStruct>();
                        
            ParamStruct param1 = new ParamStruct("@name", customer.Name, DbType.String, 50, ParameterDirection.Input);
            paramList.Add(param1);

            ParamStruct param2 = new ParamStruct("@contactFirstName", customer.ContactFirstName, DbType.String, 20, ParameterDirection.Input);
            paramList.Add(param2);

            ParamStruct param3 = new ParamStruct("@contactLastName", customer.ContactLastName, DbType.String, 30, ParameterDirection.Input);
            paramList.Add(param3);

            ParamStruct param4 = new ParamStruct("@contactNumber", customer.ContactNumber, DbType.String, 13, ParameterDirection.Input);
            paramList.Add(param4);

            ParamStruct param5 = new ParamStruct("@street", customer.Street, DbType.String, 30, ParameterDirection.Input);
            paramList.Add(param5);

            ParamStruct param6 = new ParamStruct("@city", customer.City, DbType.String, 20, ParameterDirection.Input);
            paramList.Add(param6);

            ParamStruct param7 = new ParamStruct("@prov", customer.Prov, DbType.String, 2, ParameterDirection.Input);
            paramList.Add(param7);

            ParamStruct param8 = new ParamStruct("@postalCode", customer.PostalCode, DbType.String, 7, ParameterDirection.Input);
            paramList.Add(param8);

            ParamStruct param9 = new ParamStruct("@creditCheck", customer.CreditCheck, DbType.Boolean, 1, ParameterDirection.Input);
            paramList.Add(param9);

            ParamStruct param10 = new ParamStruct("@accountNumber", customer.AccountNumber, DbType.String, 15, ParameterDirection.Input);
            paramList.Add(param10);

            ParamStruct param11 = new ParamStruct("@accountType", customer.AccountType, DbType.String, 15, ParameterDirection.Input);
            paramList.Add(param11);

            ParamStruct param12 = new ParamStruct("@accountExpiry", customer.AccountExp, DbType.Date, 4, ParameterDirection.Input);
            paramList.Add(param12);

            ParamStruct param13 = new ParamStruct("@accountLimit", customer.AccountLimit, DbType.Currency, 4, ParameterDirection.Input);
            paramList.Add(param13);

            if (customer.CreditCheck)
            {
                ParamStruct param14 = new ParamStruct("@bankName", customer.BankName, DbType.String, 30, ParameterDirection.Input);
                paramList.Add(param14);

                ParamStruct param15 = new ParamStruct("@branch", customer.Branch, DbType.String, 5, ParameterDirection.Input);
                paramList.Add(param15);

                ParamStruct param16 = new ParamStruct("@bankContactName1", customer.BankContactName1, DbType.String, 20, ParameterDirection.Input);
                paramList.Add(param16);

                ParamStruct param17 = new ParamStruct("@bankContactName2", customer.BankContactName2, DbType.String, 30, ParameterDirection.Input);
                paramList.Add(param17);

                ParamStruct param18 = new ParamStruct("@bankContactNumber", customer.BankContactNumber, DbType.String, 13, ParameterDirection.Input);
                paramList.Add(param18);

                ParamStruct param19 = new ParamStruct("@bankStreet", customer.BankStreet, DbType.String, 30, ParameterDirection.Input);
                paramList.Add(param19);

                ParamStruct param20 = new ParamStruct("@bankCity", customer.BankCity, DbType.String, 20, ParameterDirection.Input);
                paramList.Add(param20);

                ParamStruct param21 = new ParamStruct("@bankProv", customer.BankProv, DbType.String, 2, ParameterDirection.Input);
                paramList.Add(param21);

                ParamStruct param22 = new ParamStruct("@bankPostalCode", customer.BankPostalCode, DbType.String, 7, ParameterDirection.Input);
                paramList.Add(param22);
            }
            recCount = DAL.DAL.SendData(sproc, paramList);

            return recCount;
        
        } // end InsertData

        /// <summary>
        /// Uses database data to create cCustomer Objects
        /// </summary>
        /// <param name="datareader">data reader containing the table data</param>
        /// <param name="retrieve">way to retrieve data</param>
        /// <returns>list of cCustomers</returns>
        private static List<cCustomer> Repackage(IDataReader datareader, retrieveCustomerData retrieve)
        {
            using (datareader)
            {
                List<cCustomer> custList = new List<cCustomer>();

                while (datareader.Read())
                {
                    cCustomer cust = cCustomer.Create();

                    switch (retrieve)
                    {
                        case retrieveCustomerData.getCustomerIdName:
                            cust.CustomerId = (int)datareader["customerId"];
                            if (datareader["name"] == DBNull.Value)
                            {
                                cust.Name = (string)datareader["contactFirstName"] + ' ' + (string)datareader["contactLastName"];
                            }
                            else
                                cust.Name = (string)datareader["name"];
                            break;
                        case retrieveCustomerData.getCustomerDetail:
                        
                        case retrieveCustomerData.getCustomerLookup:
                            cust.CustomerId = (int)datareader["customerId"];
                            if (datareader["name"] == DBNull.Value)
                                cust.Name = (string)datareader["contactFirstName"] + ' ' + (string)datareader["contactLastName"];
                            else
                                cust.Name = (string)datareader["name"];
                            cust.ContactFirstName = (string)datareader["contactFirstName"];
                            cust.ContactLastName = (string)datareader["contactLastName"];
                            cust.ContactNumber = (string)datareader["contactNumber"];
                            cust.Street = (string)datareader["street"];
                            cust.City = (string)datareader["city"];
                            cust.Prov = (string)datareader["prov"];
                            cust.PostalCode = (string)datareader["postalCode"];
                            cust.CreditCheck = (bool)datareader["creditCheck"];
                            cust.AccountNumber = (string)datareader["accountNumber"];
                            cust.AccountType = (string)datareader["accountType"];
                            cust.AccountExp = (DateTime)datareader["accountExpiry"];
                            cust.AccountLimit = (decimal)datareader["accountLimit"];
                            if (cust.CreditCheck == true)
                            {
                                cust.BankName = (string)datareader["bankName"];
                                cust.Branch = (string)datareader["branch"];
                                cust.BankContactName1 = (string)datareader["bankContactName1"];
                                cust.BankContactName2 = (string)datareader["bankContactName2"];
                                cust.BankContactNumber = (string)datareader["bankContactNumber"];
                                cust.BankStreet = (string)datareader["bankStreet"];
                                cust.BankCity = (string)datareader["bankCity"];
                                cust.BankProv = (string)datareader["bankProv"];
                                cust.BankPostalCode = (string)datareader["bankPostalCode"];
                            }
                            break;
                        
                        
                          
                    } // end switch

                    cust.Trusted = false;
                    custList.Add(cust);
                } // end while

                datareader.Close();
                return custList;

            } //end using
        } // end Repackage
    }
}
