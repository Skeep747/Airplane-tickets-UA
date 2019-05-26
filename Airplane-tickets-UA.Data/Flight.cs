﻿using System;

namespace Airplane_tickets_UA.Data
{
    public class Flight
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int Seats { get; set; }
        public decimal Price { get; set; }
        public ICAO From { get; set; }
        public ICAO To { get; set; }
    }
}
