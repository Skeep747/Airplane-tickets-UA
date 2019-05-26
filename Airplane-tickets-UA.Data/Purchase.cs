using System;

namespace Airplane_tickets_UA.Data
{
    public class Purchase
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public DateTime DateofPurchase { get; set; }

        public int TicketId { get; set; }
        public Ticket Ticket { get; set; }
    }
}
