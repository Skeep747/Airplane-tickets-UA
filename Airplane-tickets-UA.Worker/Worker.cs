using Airplane_tickets_UA.Shared;
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

        private readonly FlightHelper _flightHelper = new FlightHelper();
        private readonly EmailHelper _emailHelper = new EmailHelper();

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
            _flightHelper.DiscountActivatedEvent += _emailHelper.SendEmail;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
