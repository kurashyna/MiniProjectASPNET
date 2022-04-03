using MiniProject.data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MiniProject.Data.Models;


namespace MiniProjectWeb.Controllers
{
    public class HomeController : Controller
    {
        private IRestaurantData restaurantData;

        public HomeController() => restaurantData = RestaurantDataProvider.Instance();

        public ActionResult Index()
        {
            List<MiniProject.data.Models.Restaurant> List = restaurantData.GetRestaurants();
            return View(List);
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
    }
}