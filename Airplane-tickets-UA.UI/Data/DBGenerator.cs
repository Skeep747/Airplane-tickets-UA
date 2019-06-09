using Airplane_tickets_UA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airplane_tickets_UA.UI.Data
{
    public class DBGenerator
    {
        private readonly Context _context;
        public DBGenerator(Context context)
        {
            _context = context;
        }

        public async Task GenerateFlights()
        {
            var flights = new Flight[]
            {
                new Flight{ Guid = Guid.NewGuid(), DepartureTime = "08:00", ArrivalTime = "10:00", Seats = 50, Price = 50, From = ICAO.UKBB, To = ICAO.UKDD },
                new Flight{ Guid = Guid.NewGuid(), DepartureTime = "09:00", ArrivalTime = "11:00", Seats = 75, Price = 75, From = ICAO.UKBB, To = ICAO.UKDD },
                new Flight{ Guid = Guid.NewGuid(), DepartureTime = "10:00", ArrivalTime = "12:00", Seats = 50, Price = 50, From = ICAO.UKBB, To = ICAO.UKDD },
                new Flight{ Guid = Guid.NewGuid(), DepartureTime = "11:00", ArrivalTime = "13:00", Seats = 100, Price = 100, From = ICAO.UKBB, To = ICAO.UKDD },
                new Flight{ Guid = Guid.NewGuid(), DepartureTime = "12:00", ArrivalTime = "14:00", Seats = 75, Price = 75, From = ICAO.UKBB, To = ICAO.UKDD },
                new Flight{ Guid = Guid.NewGuid(), DepartureTime = "13:00", ArrivalTime = "15:00", Seats = 50, Price = 50, From = ICAO.UKBB, To = ICAO.UKDD },
                new Flight{ Guid = Guid.NewGuid(), DepartureTime = "14:00", ArrivalTime = "16:00", Seats = 25, Price = 25, From = ICAO.UKBB, To = ICAO.UKDD },
                new Flight{ Guid = Guid.NewGuid(), DepartureTime = "15:00", ArrivalTime = "17:00", Seats = 75, Price = 75, From = ICAO.UKBB, To = ICAO.UKDD },
                new Flight{ Guid = Guid.NewGuid(), DepartureTime = "16:00", ArrivalTime = "18:00", Seats = 100, Price = 100, From = ICAO.UKBB, To = ICAO.UKDD }
            };
        }
    }
}
