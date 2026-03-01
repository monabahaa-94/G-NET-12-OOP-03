using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03
{
    internal class StandardTicket:Ticket
    {
        

        public StandardTicket(string moviename, decimal price,seat_location seat)
        : base(moviename, price ,seat)
        {
           
        }
        public override string ToString()
        {
            return $"{Seat}:{Moviename}:{Price}";
        }
    }
}
