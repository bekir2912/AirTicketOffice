using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTicketOffice
{
    public class Discount
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public float percentDiscount { get; set; }
        public Flight FlightId { get; set; }
    }
}
