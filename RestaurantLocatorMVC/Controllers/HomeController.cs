using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestaurantLocatorMVC.Models;

namespace RestaurantLocatorMVC.Controllers
{
    public class HomeController : Controller
    {
        private static List<Restaurant> restaurants = new List<Restaurant>();

        public ActionResult Index()
        {
            ViewBag.restaurants = restaurants;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]        
        public ActionResult Add(string name, string streetaddress, string city, string state, int zipcode )
        {
            var newrestaurant = new Restaurant(name, streetaddress, city, state, zipcode);
            restaurants.Add(newrestaurant);
            return Redirect("/");

        }

        public ActionResult Random()
        {
            Random randNum = new System.Random(restaurants.Count);

            Restaurant objRest;

            objRest = restaurants[randNum.Next(restaurants.Count)];

            ViewBag.objRest = objRest;

            return View();

        }
    }
}