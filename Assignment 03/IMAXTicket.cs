using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03
{
    internal class IMAXTicket:Ticket
    {
        public bool Is3D {  get; set; }
        public IMAXTicket(string movieName, decimal price,seat_location seat, bool is3d)
        : base(movieName, is3d ? price + 30 : price,seat)
        {
            Is3D = is3d;
        }

        public override string ToString()
        {
            return $"{Is3D}:{Moviename}:{Price}:{Seat}";
        }
    }
}
