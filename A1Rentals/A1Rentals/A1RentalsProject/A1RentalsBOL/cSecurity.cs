using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A1Rentals
{
    public class cSecurity
    {
        private string mName;
        private string mAccess;

        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }

        public string Access
        {
            get { return mAccess; }
            set { mAccess = value; }
        }

        public cSecurity()
        { }

    }
}
