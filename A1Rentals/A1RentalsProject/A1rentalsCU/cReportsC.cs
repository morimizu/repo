using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using A1Rentals.SQL;

namespace A1Rentals.CU
{
    public class cReportsC
    {
        public static DataTable getOverdueReport(int customerId, int equipmentId, DateTime start, DateTime stop, int daysOver)
        {
            return cReportSQL.getOverdueReport(customerId, equipmentId, start, stop, daysOver);
        }

        public static DataTable getCustomerReport(int customerId,DateTime start,DateTime end)
        {
           return cReportSQL.getCustomerReport(customerId, start, end);
        }

        public static DataTable getEquipmentReport(int equipmentId,DateTime start, DateTime end)
        {
            return cReportSQL.getEquipmentReport(equipmentId,start,end);
        }
    }
}
