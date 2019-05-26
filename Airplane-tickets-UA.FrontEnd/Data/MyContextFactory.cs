using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Airplane_tickets_UA.FrontEnd.Data
{
    public class MyContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=AirplaneTicketsDb;Trusted_Connection=True;MultipleActiveResultSets=true;");

            return new MyContext(optionsBuilder.Options);
        }
    }
}
