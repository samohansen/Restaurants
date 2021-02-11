using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Restaurants.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurants.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Pass list to Index view:
        public IActionResult Index()
        {
            List<string> restaurantList = new List<string>();

                // TopRestaurants.GetRestaurants()
            foreach (TopRestaurants r in TopRestaurants.GetRestaurants())
            {
                int? rank = r.Rank ?? 999;
                restaurantList.Add(string.Format("#{0}: {1} {2} {3} {4} {5}", r.Rank, r.RestaurantName, r.FavoriteDish ?? "It's all tasty!", r.Address, r.RestaurantPhone, r.LinkToWebsite));
            }
            // 6 items to add: Rank, RestaurantName, FavoriteDish, Address, RestaurantPhone, LinkToWebsite

            return View(restaurantList);
        }
        public IActionResult Privacy()
        {
            return View();
        }


        // GET and POST methods for fetching the page and for submitting form:
        [HttpGet]
        public IActionResult SuggestionForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SuggestionForm(SuggestionResponse appResponse)
        {
            if (ModelState.IsValid)
            {
                TempStorage.AddApplication(appResponse);
                return View("Confirmation", appResponse);
            }
            else
            {
                return View(appResponse);
            }
        }

        public IActionResult SuggestionList()
        {
            return View(TempStorage.Suggestions);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
