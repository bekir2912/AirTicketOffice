using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTicketOffice
{
    public class MyContext : DbContext
    {
        public MyContext() : base("AirSalesOffice") { }

        public DbSet<AirPlane> AirPlanes { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Admin> Leaders { get; set; }
        public DbSet<Passenger> Passengers{ get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Discount> Discounts { get; set; }

    }
}
