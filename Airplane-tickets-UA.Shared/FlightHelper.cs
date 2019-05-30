using Airplane_tickets_UA.Data;
using System;
using System.Collections.Generic;

namespace Airplane_tickets_UA.Shared
{
    public class FlightHelper
    {
        private readonly decimal _discound = 0.85M;
        private readonly decimal _discound60 = 0.90M;
        private readonly decimal _discound30 = 0.95M;
        private readonly decimal _discound1 = 0.50M;

        private readonly Random random = new Random();

        public delegate void FlightGeneratorEventHandler();
        public event FlightGeneratorEventHandler FlightGeneratedEvent;

        public delegate void PriceChangeEventHandler();
        public event PriceChangeEventHandler PriceChangedEvent;

        public delegate void DiscountActivatorEventHandler();
        public event DiscountActivatorEventHandler DiscountActivatedEvent;

        private ExistingFlight GenerateFlight(Flight flight)
        {
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
            
            FlightGeneratedEvent?.Invoke();

            return GetDiscount(existingFlight, random.Next(1, 10));
        }

        private ExistingFlight GetDiscount(ExistingFlight existingFlight, int luckyNumber)
        {
            if (random.Next(1, 10) == luckyNumber)
            {
                existingFlight.Price *= _discound;

                PriceChangedEvent?.Invoke();
            }

            return existingFlight;
        }

        private List<ExistingFlight> GetSpecialOffer(List<ExistingFlight> existingFlights, int daysLeft)
        {
            foreach(var existingFlight in existingFlights)
            {
                switch (daysLeft)
                {
                    case 60:
                        existingFlight.Price *= _discound60;
                        break;
                    case 30:
                        existingFlight.Price *= _discound30;
                        break;
                    case 1:
                        existingFlight.Price *= _discound1;
                        break;
                }
            }

            DiscountActivatedEvent?.Invoke();

            return existingFlights;
        }
    }
}
