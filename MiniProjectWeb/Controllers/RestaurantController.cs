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
            if (Session[restaurantId.ToString()] == null)
            {
                Session[restaurantId.ToString()] = new Dictionary<Dish, int>();
            }
            
            int dishId = _dishId ?? -1;
            restaurantData = RestaurantDataProvider.Instance();
            Restaurant restaurant = restaurantData.GetRestaurant(restaurantId);
            DishViewModel dishViewModel = new DishViewModel();
            dishViewModel.Restaurant = restaurant;
            if (dishId != -1)
            {
                Dish dish = restaurantData.GetDishById(restaurant, dishId);
                dishViewModel.Dish = dish;
                IDictionary<Dish, int> cartList = Session[restaurantId.ToString()] as Dictionary<Dish, int>;
                if (cartList.ContainsKey(dish)) {
                    cartList[dish]++;
                } else
                {
                    cartList.Add(dish, 1);
                }
                Session[restaurantId.ToString()] = cartList;
            }
            IDictionary<Dish, int> cart = Session[restaurantId.ToString()] as Dictionary<Dish, int>;
            dishViewModel.Cart = cart;
            
            return View(dishViewModel);
        }
    }
}