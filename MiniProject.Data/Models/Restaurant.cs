using MiniProject.Data.Models;
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

        public List<Dish> Dishes = new List<Dish>();

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

            Dishes.Add(new Dish(1, "Starter n°1", "Little starter", 6.0f, false, 0, DishCategories.Starter));
            Dishes.Add(new Dish(2, "Starter n°2", "Little starter", 6.5f, false, 5, DishCategories.Starter));

            Dishes.Add(new Dish(3, "Main Course n°1", "Good soup", 12.0f, true, 0, DishCategories.MainCourse));
            Dishes.Add(new Dish(4, "Main Course n°2", "Good soup 2", 12.3f, false, 5, DishCategories.MainCourse));

            Dishes.Add(new Dish(5, "Dessert n°1", "Ice cream like Selena Gomez's song", 7.2f, false, 0, DishCategories.Dessert));
            Dishes.Add(new Dish(6, "Dessert n°2", "Ice cream like Selena Gomez's song", 8.0f, false, 0, DishCategories.Dessert));

            Dishes.Add(new Dish(7, "Coca bien frais chakal", "Un coca si frais t'as peur", 1.0f, false, 0, DishCategories.Drinks));
            Dishes.Add(new Dish(8, "Boisson 2", "Good soup (but as a drink)", 1.0f, false, 0, DishCategories.Drinks));
        }

    }
}