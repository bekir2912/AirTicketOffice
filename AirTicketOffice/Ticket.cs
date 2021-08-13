using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTicketOffice
{
    public class Ticket
    {
        public Guid Id { get; set; }
        public Flight Flight { get; set; }
        public bool Buyied { get; set; }
        public Passenger passenger { get; set; }
    }
}
