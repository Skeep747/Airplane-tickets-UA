namespace Airplane_tickets_UA.Data
{
    public class Airport
    {
        public int Id { get; set; }
        public ICAO ICAO { get; set; }
        public string Name { get; set; }

        public int CityId { get; set; }
        public City City { get; set; }
    }
}
