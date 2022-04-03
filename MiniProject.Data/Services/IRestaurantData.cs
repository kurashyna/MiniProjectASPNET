using MiniProject.data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniProject.Data.Models;

namespace MiniProject.data.Services
{
    public interface IRestaurantData
    {
        List<Restaurant> GetRestaurants();
        Restaurant GetRestaurant(int id);
        void AddRestaurant(Restaurant restaurant);
        List<Dish> GetDishes(Restaurant restaurant);
        Dish GetDishById(Restaurant restaurant, int DishId);
    }
}