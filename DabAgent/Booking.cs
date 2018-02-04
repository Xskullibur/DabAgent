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
        public string NRIC;
        public DateTime TravelDt;
        public int Pax;
        public double Cost;
        public string Departure;
        public string Arrival;

        public Booking()
        {

        }

        public Booking(int id, string ic, DateTime traveldate, int pax, double cost, string departure, string arrival)
        {
            ID = id;
            NRIC = ic;
            TravelDt = traveldate;
            Pax = pax;
            Cost = cost;
            Departure = departure;
            Arrival = arrival;
        }

        public double TotalCost()
        {
            return Pax * Cost;
        }
    }
}
