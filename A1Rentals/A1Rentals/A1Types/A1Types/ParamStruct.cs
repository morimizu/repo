#region "Using statments"

using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#endregion
namespace A1Rentals.Types
{
    /// <summary>
    /// a sturcture defining a stored procedure peramiter
    /// </summary>
    public struct ParamStruct
    {
       public string paramId;
       public object paramValue;
       public DbType paramType;
       public int paramLength;
       public ParameterDirection paramDirection;

        /// <summary>
        /// creates a new ParamStruct
        /// </summary>
        /// <param name="id">the name of the stored procedure peramiter</param>
        /// <param name="value">the value being passsed</param>
        /// <param name="type">the  data type of the peramiter value</param>
        /// <param name="length">the length of the database field</param>
        /// <param name="direction">the direction of the peramiter. input, output or both</param>
       public ParamStruct(string id, object value, DbType type, int length, ParameterDirection direction)
       {
        paramId = id;
        paramValue = value;
        paramType = type;
        paramLength = length;
        paramDirection = direction;
       }
    }
}
