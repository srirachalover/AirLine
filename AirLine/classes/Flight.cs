using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLine.classes
{
    public class Flight
    {
        public string Id { get; set; }
        public DateTime DepartureTime { get; set; }
        public string DepartureCity { get; set; }
        public DateTime ArrivalDate { get; set; }
        public string ArrivalCity { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; }
    }
}
