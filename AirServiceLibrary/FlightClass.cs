using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AirServiceLibrary
{
    public class FlightClass
    {
        public int FlightID { get; set; }
        public int AirCarrierID { get; set; }
        public decimal Price { get; set; }
        public string DepartureCity { get; set; }
        public string DepartureState { get; set; }
        public string DepartureDate { get; set; }
        public string DepartureTime { get; set; }
        public string ArrivalCity { get; set; }
        public string ArrivalState { get; set; }
        public string ArrivalDate { get; set; }
        public string ArrivalTime { get; set; }
        public int Stops { get; set; }
        public string Class { get; set; }
        public int MaxSeats { get; set; }
        public int SeatsReserved { get; set; }

    }
}
