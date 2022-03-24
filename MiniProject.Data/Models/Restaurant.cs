using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.data.Models
{
    public class Restaurant
    {
        public int RestaurantId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public float Stars { get; set; }
        public float AveragePrice { get; set; }
        public string Image { get; set; }
        public int Discount { get; set; }
        public RestaurantCategory Category { get; set; }

        public Restaurant(int restaurantId, string name, string address, float stars, float averagePrice, string image, int discount, RestaurantCategory category)
        {
            RestaurantId = restaurantId;
            Name = name;
            Address = address;
            Stars = stars;
            AveragePrice = averagePrice;
            Image = image;
            Discount = discount;
            Category = category;
        }
    }
}