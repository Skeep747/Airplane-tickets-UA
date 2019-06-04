using System;

namespace Airplane_tickets_UA.Data
{
    public class Ticket
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public int Seat { get; set; }

        public int ExistingFlightId { get; set; }
        public ExistingFlight ExistingFlight { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}