using FirstMVC.Models;
using FirstMVC.Service;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVC.Controllers
{
    public class FriendController : Controller
    {
        public IActionResult Index()
        {
            List<FriendModel> friends = FriendService.GetAll();
            return View(friends);
        }

        public IActionResult Details(int id)
        {
            FriendModel f = FriendService.Get(id);
            return View(f);
        }
        public IActionResult List()
        {
            List<FriendModel> friends = FriendService.GetAll();
            return View(friends);
        }


        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(FriendModel f)
        {
            FriendService.Add(f);
            return RedirectToAction("List");
        }

        public IActionResult Delete(int Id)
        {
            FriendModel f = FriendService.Get(Id);
            if (f != null)
                return View(f);
            else
                return RedirectToAction("List");
        }
        [HttpPost]
        public IActionResult Delete(FriendModel f)
        {
            FriendService.Delete(f.FriendID);
            return RedirectToAction("List");
        }
    }
}
