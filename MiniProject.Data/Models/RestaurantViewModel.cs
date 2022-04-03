using System.Collections.Generic;
using MiniProject.data.Models;

namespace MiniProject.Data.Models
{
    public class RestaurantViewModel
    {
        public Restaurant Restaurant { get; set; }
        public List<Dish> Dishes { get; set; }
    }
}