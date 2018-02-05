using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DabAgent
{
    class Customer
    {
        public string NRIC;
        public string Contact;
        public string Address;
        public string Name;

        public bool IsNRICValid()
        {
            
            if (NRIC.Equals(@"[sStTgGfF]#######[a-zA-Z]"))
            { 
                return true;
            }
            else
            {
                return false;
            }
        }

        public Customer()
        {

        }
    }
}
