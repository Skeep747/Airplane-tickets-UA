using System;
using System.Collections.Generic;

namespace Airplane_tickets_UA.Data
{
    public class City
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public string Name { get; set; }

        public List<Airport> Airports { get; set; } = new List<Airport>();
    }
}
