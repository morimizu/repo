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
     public class cSecuritySQL
    {
         public static cSecurity CheckLogin(string user, string pass)
        {
            List<ParamStruct> paramList = new List<ParamStruct>();

            ParamStruct param0 = new ParamStruct("@userName", user, DbType.String, 8, ParameterDirection.Input);
            paramList.Add(param0);
            ParamStruct param1 = new ParamStruct("@password", pass, DbType.String, 8, ParameterDirection.Input);
            paramList.Add(param1);

            string sproc = "checkLogin";          

            DbDataReader valid = DAL.DAL.ReadData(sproc, paramList);
            cSecurity currentUser = Repackage(valid);

            if (currentUser.Name == null)
                throw new Exception("Access Denied");
            else
                return currentUser;
        }// end CheckLogin

         private static cSecurity Repackage(IDataReader datareader)
         {
             using (datareader)
             {
                 cSecurity user = new cSecurity();

                 while (datareader.Read())
                 {
                     user.Name = (string)datareader["name"];
                     user.Access = (string)datareader["access"];
                 } 

                 datareader.Close();
                 return user;
             }
         }// end Repackage

    }// end Class
}// end Namespace
