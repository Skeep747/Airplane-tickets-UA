using Airplane_tickets_UA.Data;

namespace Airplane_tickets_UA.Shared
{
    public class Announcer
    {
        public void SendEmailAboutDiscount(ICAO firstAirport, ICAO secondAirport)
        {
            //Send Email
        }

        public void NotifyAboutNewFlight(ExistingFlight existingFlight)
        {
            //Notification of the creation of a new flight
        }

        public void NotifyAboutPriceChange(ExistingFlight existingFlight)
        {
            //Price сhange notice
        }
    }
}
