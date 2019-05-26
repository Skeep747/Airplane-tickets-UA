using Airplane_tickets_UA.Data;
using System;

namespace Airplane_tickets_UA.Shared
{
    internal static class DiscountGenerator
    {
        private static readonly decimal _discound = 0.85M;
        public static ExistingFlight GetDiscount(ExistingFlight existingFlight, int luckyNumber)
        {
            var randomNumber = new Random().Next(1, 10);
            if (randomNumber == luckyNumber)
            {
                existingFlight.Price *= _discound;
            }
            return existingFlight;
        }
    }
}
