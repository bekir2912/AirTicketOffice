using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTicketOffice
{
    
    public class Admin
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public byte[] Image { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
