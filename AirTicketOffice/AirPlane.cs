using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTicketOffice
{
    public class AirPlane : IComparer<AirPlane>
    {
        public Guid Id { get; set; }
        public string Model { get; set; }
        public int TotalSeats { get; set; }
        public int FreeSeats { get; set; }

        public int Compare(AirPlane x, AirPlane y)
        {
            if (x.TotalSeats - x.FreeSeats < y.TotalSeats - y.FreeSeats)
                return -1;
            else if (x.TotalSeats - x.FreeSeats > y.TotalSeats - y.FreeSeats)
                return 1;

                return 0;
        }

        public override string ToString()
        {
            return "Id: " + Id + 
                   "\nModel: " + Model;
        }
    }
}
