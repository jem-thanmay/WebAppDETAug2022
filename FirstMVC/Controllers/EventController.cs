using FirstMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVC.Controllers
{
    public class EventController : Controller
    {

        public List<BookingModel> events { get; set; }

        public IActionResult Index()
        {
            events = new List<BookingModel>();
            events.Add(new BookingModel { Title = "Ask CEO", EventDate = DateTime.Today, Qty = 10 });
            return View(events);
        }
    }
}
