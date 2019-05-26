using Airplane_tickets_UA.Data;
using Microsoft.EntityFrameworkCore;

namespace Airplane_tickets_UA.FrontEnd.Data
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Airport> Airports { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ExistingFlight> ExistingFlights { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
    }
}
