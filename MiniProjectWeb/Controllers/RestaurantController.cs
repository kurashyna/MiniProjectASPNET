using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MiniProject.data.Models;
using MiniProject.Data.Models;
using MiniProject.data.Services;

namespace MiniProjectWeb.Controllers
{
    public class RestaurantController : Controller
    {
        
        private IRestaurantData restaurantData;
        
        // GET: Restaurant
        [HttpGet]
        public ActionResult Index(int id)
        {
            restaurantData = RestaurantDataProvider.Instance();

            /*RestaurantViewModel restaurantModel = null;*/

            Restaurant restaurant = restaurantData.GetRestaurant(id);
            /*List<Dish> dishes = restaurantData.GetDishes(restaurant);
            restaurantModel = new RestaurantViewModel() 
            {
                Restaurant =  restaurant,
                Dishes = dishes
            };*/

            return View(restaurant);
        }
    }
}