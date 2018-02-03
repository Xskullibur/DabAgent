using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            
            if (NRIC.Length == 9)
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
