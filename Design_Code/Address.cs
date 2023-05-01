using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Code
{
    public struct Address
    {
        public string street;
        public string city;
        public string state;
        public int zipCode;
        public string country;

        public bool Validate()
        {
            return true;
        }
    }
}
