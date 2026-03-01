using Assignment_03.Enem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03
{
    internal class Ticket
    {
        private string _moviename;
        private decimal _price;
        private seat_location _seat;
        private static int _ticketCounter = 0;
       

        public int TicketId { get; }
        public string Moviename
        {
            get
            { return _moviename; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _moviename = value;
                }

            }
        }
        public decimal Price
        {
            get
            { return _price; }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
            }
        }
        public seat_location Seat { get; set; }


        private const decimal _taxPercent = 14;
        public decimal PriceAfterTax
        {
            get { return _price + (_price * _taxPercent / 100); }
        }

        public Ticket()
        {
            _ticketCounter++;
            TicketId = _ticketCounter;
        }

        public Ticket(string? moviename,decimal price)
        {
            TicketId = ++_ticketCounter;
            Moviename = moviename;
            Price = price;
        }
        public Ticket(string? moviename, decimal price, seat_location seat)
        {

            TicketId = ++_ticketCounter;
            Moviename = moviename;
            Price = price;
            Seat = seat;
        }

        public Ticket(string? moviename) : this(moviename, 50, new seat_location('a', 1))
        {

        }

        public decimal CalcTotal(decimal taxPercent)
        {
            return Price + (Price * taxPercent / 100);
        }

        public void ApplyDiscount(decimal discountAmount)
        {

            if (discountAmount > 0 && discountAmount <= Price)
            {
                Price = Price - discountAmount;
                discountAmount = 0;
            }


        }

        public static int GetTotalTickets()
        {
            return _ticketCounter;
        }


        public override string ToString()
        {
            return $"your ticket info: movie name:{Moviename} seat place:{Seat} ticket price:{Price} ticket ids:{TicketId}";
        }
    }
}
