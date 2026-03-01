using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03
{
    internal static class BookingHelper
    {
        private static int counter = 0;

        public static double CalcGroupDiscount(int numberOfTickets, double pricePerTicket)
        {
            double totalprice = pricePerTicket * numberOfTickets;

            double priceafterdiscount = totalprice * 90 / 100;
            if (numberOfTickets >= 5)
            {
                return priceafterdiscount;
            }
            else
            {
                return totalprice;
            }
        }

        public static string GenerateBookingReference()
        {
            counter++;
            return $"BK-{counter}";
        }
    }
}
