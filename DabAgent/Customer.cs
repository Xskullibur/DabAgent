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
            Regex ValidIC = new Regex(@"^[sStTgGfF]\d{7}[a-zA-Z]$");
            if (ValidIC.IsMatch(NRIC))
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
