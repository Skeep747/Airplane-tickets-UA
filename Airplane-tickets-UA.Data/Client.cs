using System;
using System.Collections.Generic;

namespace Airplane_tickets_UA.Data
{
    public class Client
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Birthday { get; set; }
        public string RegistrationDate { get; set; }

        public List<Ticket> Tickets { get; set; } = new List<Ticket>();
    }
}
