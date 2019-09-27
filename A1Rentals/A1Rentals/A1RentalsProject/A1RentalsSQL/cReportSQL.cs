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
    /// A class to control Database access for the reports
    /// </summary>
    public class cReportSQL
    {
        /// <summary>
        /// gets the information on overdue equipment
        /// </summary>
        /// <param name="customer">the customerId</param>
        /// <param name="equipment">the EquipmentId</param>
        /// <param name="start">the date to start looking from</param>
        /// <param name="end">the date to stop looking</param>
        /// <param name="days">narrows the search to how many days overdue</param>
        /// <returns></returns>
        public static DataTable getOverdueReport(int customer, int equipment, DateTime start, DateTime end, int days)
        {
            DataTable report = new DataTable();
            List<ParamStruct> paramList = new List<ParamStruct>();

            ParamStruct param0 = new ParamStruct("@customerId", customer, DbType.Int32, 4, ParameterDirection.Input);
            paramList.Add(param0);

            ParamStruct param1 = new ParamStruct("@equipmentId", equipment, DbType.Int32, 4, ParameterDirection.Input);
            paramList.Add(param1);

            ParamStruct param2 = new ParamStruct("@startDate", start, DbType.Date, 4, ParameterDirection.Input);
            paramList.Add(param2);

            ParamStruct param3 = new ParamStruct("@endDate", end, DbType.Date, 4, ParameterDirection.Input);
            paramList.Add(param3);

            ParamStruct param4 = new ParamStruct("@daysover", days, DbType.Int32, 4, ParameterDirection.Input);
            paramList.Add(param4);

            string sproc = "getRentalsDueRpt";
            report = DAL.DAL.ReadTable(sproc, paramList);

            return report;
        }
        /// <summary>
        /// gets the reports on the customer
        /// </summary>
        /// <param name="customer">the customerId</param>
        /// <param name="start">the date to start looking from</param>
        /// <param name="end">the date to stop looking</param>
        /// <returns></returns>
        public static DataTable getCustomerReport(int customer, DateTime start, DateTime end)
        {
            DataTable report = new DataTable();
            List<ParamStruct> paramList = new List<ParamStruct>();

            ParamStruct param0 = new ParamStruct("@totalRevenue", 0, DbType.Currency, 8, ParameterDirection.InputOutput);
            paramList.Add(param0);

            ParamStruct param1 = new ParamStruct("@customerId", customer, DbType.Int32, 4, ParameterDirection.Input);
            paramList.Add(param1);

            ParamStruct param2 = new ParamStruct("@startDate", start, DbType.Date, 4, ParameterDirection.Input);
            paramList.Add(param2);

            ParamStruct param3 = new ParamStruct("@endDate", end, DbType.Date, 4, ParameterDirection.Input);
            paramList.Add(param3);

            string sproc = "getCustomerReport";
            report = DAL.DAL.ReadTable(sproc, paramList);

            decimal revenue = Convert.ToDecimal(paramList[0].paramValue);
            return report;
        }
        /// <summary>
        /// thes the reports on the equipment
        /// </summary>
        /// <param name="equipment">the equipmentId</param>
        /// <param name="start">date to start looking from</param>
        /// <param name="end">the date to stop looking</param>
        /// <returns></returns>
        public static DataTable getEquipmentReport(int equipment, DateTime start, DateTime end)
        {
            DataTable report = new DataTable();
            List<ParamStruct> paramList = new List<ParamStruct>();

            ParamStruct param0 = new ParamStruct("@totalRevenue", 0, DbType.Currency, 8, ParameterDirection.InputOutput);
            paramList.Add(param0);

            ParamStruct param1 = new ParamStruct("@equipmentId", equipment, DbType.Int32, 4, ParameterDirection.Input);
            paramList.Add(param1);

            ParamStruct param2 = new ParamStruct("@startDate", start, DbType.Date, 4, ParameterDirection.Input);
            paramList.Add(param2);

            ParamStruct param3 = new ParamStruct("@endDate", end, DbType.Date, 4, ParameterDirection.Input);
            paramList.Add(param3);

            string sproc = "getEquipmentReport";
            report = DAL.DAL.ReadTable(sproc, paramList);

            decimal revenue = Convert.ToDecimal(paramList[0].paramValue);
            return report;
        }

    }
}
