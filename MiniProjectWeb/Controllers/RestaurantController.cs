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
        
        public ActionResult Cart(int restaurantId, int dishId = -1 , int actionId = -1 )
        {
            restaurantData = RestaurantDataProvider.Instance();
            Restaurant restaurant = restaurantData.GetRestaurant(restaurantId);
            DishViewModel dishViewModel = new DishViewModel();
            dishViewModel.Restaurant = restaurant;
            IDictionary<Dish, int> cart = Session[restaurantId.ToString()] as Dictionary<Dish, int>;
            if (actionId == 1)
            {
                Dish dish = restaurantData.GetDishById(restaurant, dishId);
                if (cart.ContainsKey(dish))
                {
                    cart[dish]++;
                }
                else
                {
                    cart.Add(dish, 1);
                }
                Session[restaurantId.ToString()] = cart;
            }
            else if (actionId == 2)
            {
                Dish dish = restaurantData.GetDishById(restaurant, dishId);
                if (cart.ContainsKey(dish))
                {
                    cart[dish]--;
                    if (cart[dish] == 0)
                    {
                        cart.Remove(dish);
                    }
                    Session[restaurantId.ToString()] = cart;
                }
            }
            dishViewModel.Cart = cart;
            if (dishViewModel.Cart.Count > 0)
            {
                return View(dishViewModel);
            } else
            {
                return RedirectToAction("Index", new {restaurantId = restaurantId});
            }
            
        }
    }
}