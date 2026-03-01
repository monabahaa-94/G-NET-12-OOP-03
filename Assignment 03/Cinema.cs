using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03
{
    internal class Cinema
    {
        private string _cinemaname;
        private Projector _projector;
        private Ticket[] _tickets = new Ticket[20];
        public Cinema(string cinemaname) {
            _cinemaname = cinemaname;
            _projector = new Projector();
        }
        public Ticket this[int index]
        {
            get
            {
                if (index >= _tickets.Length || index < 0)
                {
                    return null;
                }
                return _tickets[index];
            }
            set
            {
                if (index >= 0 && index < _tickets.Length)
                {
                    _tickets[index] = value;
                }
            }
        }

        public Ticket GetMovie(string moviename)
        {
            for (int i = 0; i < _tickets.Length; i++)
            {
                if (_tickets[i].Moviename == moviename && _tickets[i] != null)
                {
                    return _tickets[i];
                }

            }
            return null;
        }

        public bool AddTicket(Ticket t)
        {
            for (int i = 0; i < _tickets.Length; i++)
            {
                if (_tickets[i] == null)
                {
                    _tickets[i] = t;
                    return true;
                }
            }
            return false;
        }

        public void PrintAllTickets()
        {
            for (int i = 0; i < _tickets.Length; i++)
            {
                if (_tickets[i] != null)
                {
                    Console.WriteLine($"your ticket info :");
                    Console.WriteLine($"movie name :{_tickets[i].Moviename}");
                    Console.WriteLine($"seat place :{_tickets[i].Seat}");
                    Console.WriteLine($"ticket price :{_tickets[i].Price}");
                    Console.WriteLine($"ticket id :{_tickets[i].TicketId}");
                }
                
            }
        }

        public void OpenCinema()
        {
            Console.WriteLine($"cinema{_cinemaname} is open");
            _projector.start();
        }

        public void CloseCinema()
        {
            Console.WriteLine($"cinema{_cinemaname} is closed");
            _projector.stop();
        }
    }
}
