using MiniProject.data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.data.Services
{
    public interface IRestaurantData
    {
        List<Restaurant> GetRestaurants();
        void AddRestaurant(Restaurant restaurant);

    }
}