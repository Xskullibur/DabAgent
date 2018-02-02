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
            if (NRIC == String.Format("{0: (a-zA-Z)#######(a-zA-Z)}", NRIC))
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
            Customer customer = new Customer();
            customer.NRIC = NRIC;
            customer.Name = Name;
            customer.Contact = Contact;
            customer.Address = Address;
        }
    }
}
