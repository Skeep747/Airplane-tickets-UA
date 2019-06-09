using Airplane_tickets_UA.Data;
using Microsoft.EntityFrameworkCore;

namespace Airplane_tickets_UA.Migrations
{
    public class MigrationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Airplane_tickets_UA_DB;Trusted_Connection=True;MultipleActiveResultSets=true;");
        }

        public DbSet<Airport> Airports { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ExistingFlight> ExistingFlights { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
    }
}