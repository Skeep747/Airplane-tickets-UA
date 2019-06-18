using Airplane_tickets_UA.Data;
using Airplane_tickets_UA.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Airplane_tickets_UA.Worker
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IServiceProvider _service;

        private int _maxDaysToCreate = 90;
        private int _startCreateWith = 1;

        private readonly FlightHelper _flightHelper = new FlightHelper();
        private readonly Announcer _emailHelper = new Announcer();

        public Worker(ILogger<Worker> logger, IServiceProvider service)
        {
            _logger = logger;
            _service = service;
            _flightHelper.FlightGeneratedEvent += _emailHelper.NotifyAboutNewFlight;
            _flightHelper.PriceChangedEvent += _emailHelper.NotifyAboutPriceChange;
            _flightHelper.DiscountActivatedEvent += _emailHelper.SendEmailAboutDiscount;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            using var scope = _service.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<Context>();
            _logger.LogInformation("Worker start at: {time}", DateTimeOffset.Now);
            await InitialGenerateExistingFlights(context);
            _logger.LogInformation("Worker finished initial existing flights generate at: {time}", DateTimeOffset.Now);

            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker begins daily creation of existing flights at: {time}", DateTimeOffset.Now);
                await EverydayGenerateFlights(context);
                _logger.LogInformation("Worker finished daily creation of existing flights at: {time}", DateTimeOffset.Now);

                _logger.LogInformation("Worker goes sleep at: {time}", DateTimeOffset.Now);
                await Task.Delay(GetSleepTime(), stoppingToken);
                _logger.LogInformation("Worker wakeups at: {time}", DateTimeOffset.Now);
            }
        }

        private async Task InitialGenerateExistingFlights(Context context)
        {
            if (!await context.Flights.AnyAsync())
            {
                context.Flights.AddRange(DBGenerator.GenerateFlights());
                await context.SaveChangesAsync();
            }
            if (!await context.Cities.AnyAsync())
            {
                context.Cities.AddRange(DBGenerator.GenerateCities());
                await context.SaveChangesAsync();
            }
            if (!await context.Clients.AnyAsync())
            {
                context.Clients.Add(DBGenerator.GenerateClient());
                await context.SaveChangesAsync();
            }

            var helper = await context.Helpers.FirstOrDefaultAsync(e => e.Name == "ExistingFlightsGenerateDate");
            if (helper == null)
            {
                context.Helpers.Add(new Helper { Name = "ExistingFlightsGenerateDate", Property = DateTime.Now.ToShortDateString() });
                await context.SaveChangesAsync();
            }
            else
            {
                _startCreateWith = (DateTime.Now.AddDays(_maxDaysToCreate) - DateTime.Parse(helper.Property).AddDays(_maxDaysToCreate)).Days;
            }
            if (_startCreateWith != 0)
            {

                var flights = await context.Flights.AsNoTracking().ToArrayAsync();
                foreach (var flight in flights)
                {
                    for (int i = _startCreateWith; i < _maxDaysToCreate; i++)
                    {
                        var existingFlight = _flightHelper.GenerateFlight(flight, i);
                        context.ExistingFlights.Add(existingFlight);
                    }
                }
                await context.SaveChangesAsync();
            }
        }

        private async Task EverydayGenerateFlights(Context context)
        {
            var helper = await context.Helpers.FirstOrDefaultAsync(e => e.Name == "ExistingFlightsGenerateDate");
            if (helper != null)
            {
                _startCreateWith = (DateTime.Now.AddDays(_maxDaysToCreate) - DateTime.Parse(helper.Property).AddDays(_maxDaysToCreate)).Days;
            }
            if (_startCreateWith != 0)
            {
                var flights = await context.Flights.AsNoTracking().ToArrayAsync();
                foreach (var flight in flights)
                {
                    var existingFlight = _flightHelper.GenerateFlight(flight, 1);
                    context.ExistingFlights.Add(existingFlight);
                }
                await context.SaveChangesAsync();
            }
        }

        private int GetSleepTime()
        {
            return (int)((DateTime.Now.Date.AddDays(1) - DateTime.Now).TotalMilliseconds + 3600000);
        }
    }
}