using System;
using System.Collections.Generic;

namespace Airplane_tickets_UA.Data
{
    public class ExistingFlight
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public string DepartureTime { get; set; }
        public string ArrivalTime { get; set; }
        public string DepartureDate { get; set; }
        public string ArrivalDate { get; set; }
        public int Seats { get; set; }
        public int EmptySeats { get; set; }
        public decimal Price { get; set; }
        public ICAO From { get; set; }
        public ICAO To { get; set; }

        public List<Ticket> Tickets { get; set; } = new List<Ticket>();
    }
}
