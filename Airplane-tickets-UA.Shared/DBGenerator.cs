using Airplane_tickets_UA.Data;
using System;
using System.Collections.Generic;

namespace Airplane_tickets_UA.Shared
{
    public static class DBGenerator
    {
        public static Flight[] GenerateFlights()
        {
            return new Flight[]
            {
                new Flight{ Guid = Guid.NewGuid(), DepartureTime = "08:00", ArrivalTime = "10:00", Seats = 50, Price = 50, From = ICAO.UKBB, To = ICAO.UKDD },
                new Flight{ Guid = Guid.NewGuid(), DepartureTime = "09:00", ArrivalTime = "11:00", Seats = 75, Price = 75, From = ICAO.UKKV, To = ICAO.UKKK },
                new Flight{ Guid = Guid.NewGuid(), DepartureTime = "10:00", ArrivalTime = "12:00", Seats = 50, Price = 50, From = ICAO.UKLL, To = ICAO.UKOO },
                new Flight{ Guid = Guid.NewGuid(), DepartureTime = "11:00", ArrivalTime = "13:00", Seats = 100, Price = 100, From = ICAO.UKHH, To = ICAO.UKWW },
                new Flight{ Guid = Guid.NewGuid(), DepartureTime = "12:00", ArrivalTime = "14:00", Seats = 75, Price = 75, From = ICAO.UKDE, To = ICAO.UKLI },
                new Flight{ Guid = Guid.NewGuid(), DepartureTime = "13:00", ArrivalTime = "15:00", Seats = 50, Price = 50, From = ICAO.UKON, To = ICAO.UKHP },
                new Flight{ Guid = Guid.NewGuid(), DepartureTime = "14:00", ArrivalTime = "16:00", Seats = 25, Price = 25, From = ICAO.UKLR, To = ICAO.UKLT },
                new Flight{ Guid = Guid.NewGuid(), DepartureTime = "15:00", ArrivalTime = "17:00", Seats = 75, Price = 75, From = ICAO.UKLU, To = ICAO.UKOH },
                new Flight{ Guid = Guid.NewGuid(), DepartureTime = "16:00", ArrivalTime = "18:00", Seats = 100, Price = 100, From = ICAO.UKKE, To = ICAO.UKLN }
            };
        }

        public static City[] GenerateCities()
        {
            return new City[]
            {
                new City{ Guid = Guid.NewGuid(), Name = "Бориспіль", Airports = new List<Airport>{ new Airport { Name = "Бориспіль", ICAO = ICAO.UKBB } } },
                new City{ Guid = Guid.NewGuid(), Name = "Дніпро", Airports = new List<Airport>{ new Airport { Name = "Дніпро", ICAO = ICAO.UKDD } } },
                new City{ Guid = Guid.NewGuid(), Name = "Житомир", Airports = new List<Airport>{ new Airport { Name = "Житомир", ICAO = ICAO.UKKV } } },
                new City{ Guid = Guid.NewGuid(), Name = "Київ", Airports = new List<Airport>{ new Airport { Name = "Київ", ICAO = ICAO.UKKK } } },
                new City{ Guid = Guid.NewGuid(), Name = "Львів", Airports = new List<Airport>{ new Airport { Name = "Львів", ICAO = ICAO.UKLL } } },
                new City{ Guid = Guid.NewGuid(), Name = "Одеса", Airports = new List<Airport>{ new Airport { Name = "Одеса", ICAO = ICAO.UKOO } } },
                new City{ Guid = Guid.NewGuid(), Name = "Харків", Airports = new List<Airport>{ new Airport { Name = "Харків", ICAO = ICAO.UKHH } } },
                new City{ Guid = Guid.NewGuid(), Name = "Вінниця", Airports = new List<Airport>{ new Airport { Name = "Вінниця", ICAO = ICAO.UKWW } } },
                new City{ Guid = Guid.NewGuid(), Name = "Запоріжжя", Airports = new List<Airport>{ new Airport { Name = "Запоріжжя", ICAO = ICAO.UKDE } } },
                new City{ Guid = Guid.NewGuid(), Name = "Івано-франківськ", Airports = new List<Airport>{ new Airport { Name = "Івано-франківськ", ICAO = ICAO.UKLI } } },
                new City{ Guid = Guid.NewGuid(), Name = "Миколаїв", Airports = new List<Airport>{ new Airport { Name = "Миколаїв", ICAO = ICAO.UKON } } },
                new City{ Guid = Guid.NewGuid(), Name = "Полтава", Airports = new List<Airport>{ new Airport { Name = "Полтава", ICAO = ICAO.UKHP } } },
                new City{ Guid = Guid.NewGuid(), Name = "Рівне", Airports = new List<Airport>{ new Airport { Name = "Рівне", ICAO = ICAO.UKLR } } },
                new City{ Guid = Guid.NewGuid(), Name = "Тернопіль", Airports = new List<Airport>{ new Airport { Name = "Тернопіль", ICAO = ICAO.UKLT } } },
                new City{ Guid = Guid.NewGuid(), Name = "Ужгород", Airports = new List<Airport>{ new Airport { Name = "Ужгород", ICAO = ICAO.UKLU } } },
                new City{ Guid = Guid.NewGuid(), Name = "Херсон", Airports = new List<Airport>{ new Airport { Name = "Херсон", ICAO = ICAO.UKOH } } },
                new City{ Guid = Guid.NewGuid(), Name = "Черкаси", Airports = new List<Airport>{ new Airport { Name = "Черкаси", ICAO = ICAO.UKKE } } },
                new City{ Guid = Guid.NewGuid(), Name = "Чернівці", Airports = new List<Airport>{ new Airport { Name = "Чернівці", ICAO = ICAO.UKLN } } }
            };
        }

        public static Client GenerateClient()
        {
            return new Client
            {
                Guid = Guid.NewGuid(),
                Email = "Skeep747@gmail.com",
                Password = "P@ssw0rd",
                FirstName = "Alexander",
                LastName = "Sadomov",
                Birthday = "28.01.1992",
                RegistrationDate = DateTime.UtcNow.ToLongDateString()
            };
        }
    }
}
