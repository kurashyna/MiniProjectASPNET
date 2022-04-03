using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;
using MiniProject.data.Models;
using MiniProject.Data.Models;
using MiniProject.data.Services;
using DishViewModel = MiniProject.Data.Models.DishViewModel;

namespace MiniProjectWeb.Controllers
{
    public class RestaurantController : Controller
    {
        
        private IRestaurantData restaurantData;

        [HttpGet]
        public ActionResult Index(int restaurantId, int? _dishId)
        {
            if (Session["RestaurantId"] == null)
            {
                Session["RestaurantId"] = restaurantId;
            }
            if (Session[restaurantId.ToString()] == null)
            {
                Session[restaurantId.ToString()] = new List<Dish>();
            }
            
            int dishId = _dishId ?? -1;
            Console.WriteLine(dishId);
            restaurantData = RestaurantDataProvider.Instance();
            Restaurant restaurant = restaurantData.GetRestaurant(restaurantId);
            DishViewModel dishViewModel = new DishViewModel();
            dishViewModel.Restaurant = restaurant;
            if (dishId != -1)
            {
                Dish dish = restaurantData.GetDishById(restaurant, dishId);
                dishViewModel.Dish = dish;
                System.Console.WriteLine(dishViewModel.Dish.Name);
                List<Dish> cartList = Session[restaurantId.ToString()] as List<Dish>;
                cartList.Add(dish);
                Session[restaurantId.ToString()] = cartList;
            }
            List<Dish> cart = Session[restaurantId.ToString()] as List<Dish>;
            dishViewModel.Cart = cart;
            
            return View(dishViewModel);
        }
    }
}