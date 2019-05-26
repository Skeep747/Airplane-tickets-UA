using Airplane_tickets_UA.Data;
using System;

namespace Airplane_tickets_UA.Shared
{
    internal static class FlightGenerator
    {
        public static ExistingFlight GetExistingFlight(Flight flight)
        {
            var luckyNumber = new Random().Next(1, 10);
            var existingFlight = new ExistingFlight
            {
                Guid = Guid.NewGuid(),
                DepartureTime = flight.DepartureTime,
                ArrivalTime = flight.ArrivalTime,
                DepartureDate = DateTime.Today.AddDays(90),
                ArrivalDate = DateTime.Today.AddDays(90),
                Seats = flight.Seats,
                EmptySeats = flight.Seats,
                Price = flight.Price,
                From = flight.From,
                To = flight.To
            };
            return DiscountGenerator.GetDiscount(existingFlight, luckyNumber);
        }
    }
}
