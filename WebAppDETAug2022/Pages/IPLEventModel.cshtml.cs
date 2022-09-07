using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppDETAug2022.Models;
using WebAppDETAug2022.Services;

namespace WebAppDETAug2022.Pages
{
    public class IPLEventModelModel : PageModel
    {
        public List<Ticket>Tickets { get; set; }
        //public void OnGet()
        //{
        //    //List<Ticket>
        //    Tickets = new List<Ticket>
        //    {
        //        new Ticket{Category = "PlatinumPlus", Price = 5000 , MaxLimit = 200000,ID =1},
        //        new Ticket{Category = "Platinum", Price = 4000 , MaxLimit = 300000,ID =2},
        //        new Ticket{Category = "Gold", Price = 3000 , MaxLimit = 500000,ID=3},
        //        new Ticket{Category = "Silver", Price = 2000 , MaxLimit = 500000,ID=4},
        //        new Ticket{Category = "General", Price = 800 , MaxLimit = 100000,ID=5},


        //    };
        //}
        public void OnGet()
        {
            Tickets = TicketService.GetAll();
         }
    }

}
