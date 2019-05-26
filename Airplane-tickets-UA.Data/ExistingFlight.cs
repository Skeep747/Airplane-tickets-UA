using System;
using System.Collections.Generic;

namespace Airplane_tickets_UA.Data
{
    public class ExistingFlight
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public int Seats { get; set; }
        public int EmptySeats { get; set; }
        public decimal Price { get; set; }
        public ICAO From { get; set; }
        public ICAO To { get; set; }
    }
}
