using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTicketOffice
{
    public class Location : IComparer<Location>
    {
        public string Country { get; set; }
        public string City { get; set; }

        public int Compare(Location x, Location y)
        {
            return String.Compare(x.Country + x.City, y.Country + y.City);
        }

        internal void Add(Location from)
        {
            throw new NotImplementedException();
        }
    }
}
