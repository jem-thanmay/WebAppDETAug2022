using System.Net.Sockets;
using System.Xml.Linq;
using WebAppDETAug2022.Models;

namespace WebAppDETAug2022.Services
{
    public class TicketService
    {
        static List<Ticket> Tickets { get; }
        static int nextId = 3;
        static TicketService()
        {
            Tickets = new List<Ticket>
            {
                new Ticket{Category = "PlatinumPlus", Price = 5000 , MaxLimit = 200000 ,ID = 1},
                new Ticket{Category = "Platinum", Price = 4000 , MaxLimit = 300000,ID = 2},
                new Ticket{Category = "Gold", Price = 3000 , MaxLimit = 500000,ID = 3},
                new Ticket{Category = "Silver", Price = 2000 , MaxLimit = 500000,ID = 4},
                new Ticket{Category = "General", Price = 800 , MaxLimit = 100000,ID = 5},


            };
        }

        public static List<Ticket> GetAll() => Tickets;

        public static Ticket? Get(int ID) => Tickets.FirstOrDefault(t => t.ID == ID);

        public static void Add(Ticket ticket)
        {
            ticket.ID = nextId++;
            Tickets.Add(ticket);
        }

        public static void Delete(int id)
        {
            var ticket = Get(id);
            if (ticket is null)
                return;

            Tickets.Remove(ticket);
        }

        public static void Update(Ticket ticket)
        {
            var index = Tickets.FindIndex(t => t.ID == ticket.ID);
            if (index == -1)
                return;

            Tickets[index] = ticket;
        }
    }
}
