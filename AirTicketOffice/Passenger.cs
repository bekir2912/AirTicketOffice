using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirTicketOffice
{
    public class Passenger
    {
        public Passenger()
        {
            tickets = new List<Ticket>();
            Balance = 1000;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Location location { get; set; }
        public int Age { get; set; }
        public byte[] Image { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public double Balance { get; set; }
        public ICollection<Ticket> tickets { get; set; }
    }
}
