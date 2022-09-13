using System.Net.Sockets;
using System.Xml.Linq;
using WebAPI_2022.Models;

namespace WebAPI_2022.Services
{
    public class TicketService
    {
        static List<Ticket> Tickets { get; }
        static int nextId = 3;
        static TicketService()
        {
            Tickets = new List<Ticket>
            {
                new Ticket{Id = 1 ,BookedBy = "Harry" , EventTitle = "Concert" , Cost = 499 , NofTickets = 2 ,Discount = 30},
                 new Ticket{Id = 2 ,BookedBy = "Ron" , EventTitle = "Ball" , Cost = 349 , NofTickets = 4 ,Discount = 40},
                 new Ticket{Id = 3 ,BookedBy = "Hermoine" , EventTitle = "Fest" , Cost = 699 , NofTickets = 3 ,Discount = 50},
                 new Ticket{Id = 4 ,BookedBy = "Draco" , EventTitle = "Ball" , Cost = 699 , NofTickets = 1 ,Discount = 40},
                new Ticket{Id = 5 ,BookedBy = "Luna" , EventTitle = "Concert" , Cost = 499 , NofTickets = 2 ,Discount = 30},


            };
        }

        public static List<Ticket> GetAll() => Tickets;

        public static Ticket? Get(int ID) => Tickets.FirstOrDefault(t => t.Id == ID);

        //public static void Add(Ticket t)
        //{
        //    t.Id = nextId++;
        //    Tickets.Add(t);
        //}

        //public static void Delete(int id)
        //{
        //    var t = Get(id);
        //    if (t is null)
        //        return;

        //    Tickets.Remove(t);
        //}

        //public static void Update(Ticket t)
        //{
        //    var index = Tickets.FindIndex(t => t.Id == t.Id);
        //    if (index == -1)
        //        return;

        //    Tickets[index] = t;
        //}
    }
}
