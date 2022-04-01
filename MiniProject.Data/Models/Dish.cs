using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Data.Models
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public bool IsPopular { get; set; }
        public int Discount { get; set; }
        public DishCategories Category { get; set; }

        public Dish(int id, string name, string description, float price, bool isPopular, int discount, DishCategories category)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            IsPopular = isPopular;
            Discount = discount;
            Category = category;
        }
    }
}
