using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using A1Rentals.Types;
using A1Rentals.BOL;
using A1Rentals.SQL;

namespace A1Rentals.CU
{
    public class cEquipmentCU
    { 
        public static List<cEquipment> Retreive(retrieveEquipmentData type)
        {
          return cEquipmentSQL.RetrieveEquipment(type);

        }
        public static cEquipment Retreive(int EquipId)
        {
            return cEquipmentSQL.RetrieveEquipment(EquipId);
        }
        public static List<cEquipment> RetreiveByCategory(EquipmentTypes category)
        {
           return  cEquipmentSQL.RetrieveEquipment(category);
        }

        public static bool Insert(cEquipment equip)
        {
            if (cEquipmentSQL.Insert(equip) == 1)
                return true;
            else
                return false;
        }
        public static bool Update(cEquipment equipment)
        {
            if (cEquipmentSQL.Update(equipment) == 1)
                return true;
            else
                return false;
        }
    }
}
