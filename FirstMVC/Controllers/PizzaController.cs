using FirstMVC.Models;
using FirstMVC.Service;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVC.Controllers
{
    public class PizzaController : Controller
    {
        private const bool Isglutenfree;

        public IActionResult Index()
        {
            List<Pizza> pizzas = PizzaService.GetAll();
            return View(pizzas);
        }

        public IActionResult Detail(int id)
        {
            Pizza p = PizzaService.Get(id);
            return View(p);
        }
        
        public IActionResult Create(int id, string name, int size, decimal price, bool Isglutenfree = Isglutenfree);
        
        public IActionResult Create(Pizza p)
        {
            PizzaService.Add(p);
            return RedirectToAction("List");
        }
    }
}
