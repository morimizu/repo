using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Data.Common;
using A1Rentals.DAL;
using A1Rentals.Types;
using A1Rentals.BOL;

namespace A1Rentals.SQL
{
    public class cEquipmentSQL
    {
        public static List<cEquipment> RetrieveEquipment(retrieveEquipmentData type)
        { 
            List<ParamStruct>paramiters = new List<ParamStruct>();
            paramiters.Add(new ParamStruct("@retriveType",type,DbType.Int32,4,ParameterDirection.Input));
            DbDataReader reader = DAL.DAL.ReadData("retrieveEqipmentData",paramiters);
            return Repackager(reader,type);
        }
        public static cEquipment RetrieveEquipment(int EquipID)
        {
            List<ParamStruct> paramiters = new List<ParamStruct>();
            paramiters.Add(new ParamStruct("@retriveType", 2, DbType.Int32, 4, ParameterDirection.Input));
            paramiters.Add(new ParamStruct("@equipmentId", EquipID, DbType.Int32, 4, ParameterDirection.Input));
            DbDataReader reader = DAL.DAL.ReadData("retrieveEqipmentData", paramiters);
            return Repackager(reader,retrieveEquipmentData.getEquipmentById)[0];
        }
        public static List<cEquipment> RetrieveEquipment(EquipmentTypes Category)
        {
            List<ParamStruct> paramiters = new List<ParamStruct>();
            paramiters.Add(new ParamStruct("@retriveType",5, DbType.Int32, 4, ParameterDirection.Input));
            paramiters.Add(new ParamStruct("@category", Category, DbType.Int32, 4, ParameterDirection.Input));
            DbDataReader reader = DAL.DAL.ReadData("retrieveEqipmentData", paramiters);
            return Repackager(reader,retrieveEquipmentData.getEquipmentByCategory);
        }
        private static List<cEquipment> Repackager(DbDataReader reader,retrieveEquipmentData type)
        {
            List<cEquipment> EquipList = new List<cEquipment>();
            
           
            while (reader.Read())
            {
                
                
                cEquipment equip = cEquipment.Create();
                equip.trustedSource = true;
                switch (type)
                {
                    case retrieveEquipmentData.getEquipmentIdSerial:
                        {
                            equip.EquipId = Convert.ToInt32(reader["equipmentId"]);
                            equip.Serial = reader["serial"].ToString();
                            break;
                        }
                    case retrieveEquipmentData.getEquipmentById:
                    case retrieveEquipmentData.getEquipmentByCategory:
                    case retrieveEquipmentData.getEquipmentDetail:
                    case retrieveEquipmentData.getEquipmentExcludNotAvail:
                        {
                            
                            equip.EquipId = Convert.ToInt32(reader["equipmentId"]);
                            equip.Serial = reader["serial"].ToString();
                            equip.RentPrice = Convert.ToDecimal(reader["rentPrice"]);
                            equip.ListPrice = Convert.ToDecimal(reader["listPrice"]);
                            equip.Status = (StatusTypes)reader["availStatus"];
                            if (reader["dateOut"] != DBNull.Value)
                                equip.DateOut = Convert.ToDateTime(reader["dateOut"]);
                            if (reader["dateIn"] != DBNull.Value)
                                equip.DateIn = Convert.ToDateTime(reader["dateIn"]);
                            equip.Category = (EquipmentTypes)reader["category"];
                            
                            break;
                        }
                }
                
                equip.trustedSource = false;
                EquipList.Add(equip);
            
            }
            return EquipList;
        }
        public static int Insert(cEquipment Equip)
        {
            List<ParamStruct> paramiters = new List<ParamStruct>();
            paramiters.Add(new ParamStruct("@serial", Equip.Serial, DbType.String, 20, ParameterDirection.Input));
            paramiters.Add(new ParamStruct("@rentPrice", Equip.RentPrice, DbType.Decimal, 4, ParameterDirection.Input));
            paramiters.Add(new ParamStruct("@listPrice", Equip.ListPrice, DbType.Decimal, 4, ParameterDirection.Input));
            paramiters.Add(new ParamStruct("@status", (int)Equip.Status, DbType.Int32, 4, ParameterDirection.Input));
            paramiters.Add(new ParamStruct("@dateOut", Equip.DateOut, DbType.DateTime, 8, ParameterDirection.Input));
            paramiters.Add(new ParamStruct("@In", Equip.DateIn, DbType.DateTime, 8, ParameterDirection.Input));
            paramiters.Add(new ParamStruct("@category", (int)Equip.Category, DbType.Int32, 4, ParameterDirection.Input));
            return DAL.DAL.SendData("InsertEquipment", paramiters);
        }
        public static int Update(cEquipment Equip)
        {
            List<ParamStruct> paramiters = new List<ParamStruct>();
            paramiters.Add(new ParamStruct("@EquipId", Equip.EquipId, DbType.Int32 , 4, ParameterDirection.Input));
            paramiters.Add(new ParamStruct("@serial", Equip.Serial, DbType.String, 20, ParameterDirection.Input));
            paramiters.Add(new ParamStruct("@rentPrice", Equip.RentPrice, DbType.Decimal, 4, ParameterDirection.Input));
            paramiters.Add(new ParamStruct("@listPrice", Equip.ListPrice, DbType.Decimal, 4, ParameterDirection.Input));
            paramiters.Add(new ParamStruct("@status", (int)Equip.Status, DbType.Int32, 4, ParameterDirection.Input));
            paramiters.Add(new ParamStruct("@Out", Equip.DateOut, DbType.DateTime, 8, ParameterDirection.Input));
            paramiters.Add(new ParamStruct("@In", Equip.DateIn, DbType.DateTime, 8, ParameterDirection.Input));
            paramiters.Add(new ParamStruct("@category", (int)Equip.Category, DbType.Int32, 4, ParameterDirection.Input));
            return DAL.DAL.SendData("updateEquipmentData", paramiters);
        }
        
       
    }
}
