using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using A1Rentals.SQL;

namespace A1Rentals.CU
{
    public class cSecurityC
    {
        public static cSecurity checkLogin(string username, string password)
        {
            return cSecuritySQL.CheckLogin(username, password);
        }
    }
}
