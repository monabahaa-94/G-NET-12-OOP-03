using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03
{
    internal class VIPTicket:Ticket
    {
        public bool LoungeAccess {  get; set; }
        public decimal ServiceFee { get; } = 50;
        

        public VIPTicket(string moviename, decimal price,seat_location seat, bool loungeaccess)
       : base(moviename, price + 50,seat) 
        {
            LoungeAccess = loungeaccess;
        }

        public override string ToString()
        {
            return $"{LoungeAccess}:{ServiceFee}:{Moviename}:{Price}:{Seat}";
        }
    }
}
