using Microsoft.AspNetCore.Mvc;
using FishListMVC.Models;

namespace FishListMVC.Controllers
{
    public class HelloWorldController : Controller
    {

        private static List<Fish> fishList = new List<Fish>();

        public IActionResult Index()
        {
            return View(fishList);
        }

        public IActionResult Home()
        {
            return View(fishList);
            //var fishVM = new Fish();
            //fishVM.Name = "Vil";
            //fishVM.Age = 9;

            //return View(fishVM);
        }

        public IActionResult Create()
        {
            var fishVM = new Fish();

            return View(fishVM);
        }

        public IActionResult CreateFish(Fish fish)
        {
            fishList.Add(fish);
            //return View("Home");
            return RedirectToAction(nameof(Home));
        }
    }
}
