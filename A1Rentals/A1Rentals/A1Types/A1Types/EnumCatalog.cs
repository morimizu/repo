using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1Rentals.Types
{
    public enum retrieveCustomerData
    {
        getCustomerSchema = 0,
        getCustomerIdName = 1,
        getCustomerById = 2,
        getCustomerDetail = 3,
        getCustomerLookup = 4
    }

    public enum retrieveEquipmentData
    { 
        getEquipmentSchema = 0,
        getEquipmentIdSerial = 1,
        getEquipmentById = 2,
        getEquipmentDetail = 3,
        getRentedEquipment = 4,
        getEquipmentByCategory =5,
        getEquipmentExcludNotAvail =6
    }
    public enum StatusTypes
    { 
       Out,
       In,
       Service,
       NotAvaliable
    }
    public enum ButtonModes
    { 
       NorecordsSelected,
       EnableSave,
       RecordSelected
    }
    public enum DatabseMode
    { 
        Insert,
        Update,
        None
    }
    public enum EquipmentTypes
    { 
       EarthMoving,
        Compressors,
        AirTools,
        Sanding,
        Cutting
    }
    
}
