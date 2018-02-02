using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DabAgent
{
    class Booking
    {
        public int ID;
        public DateTime TravelDt;
        public int Pax;
        public string NRIC;
        public double cost;

        public double TotalCost()
        {
            return Pax * cost;
        }
    }
}
