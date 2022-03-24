using MiniProject.data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.data.Services
{
    public sealed class RestaurantDataProvider : IRestaurantData
    {
        private static RestaurantDataProvider instance;
        private static readonly object padlock = new object();

        private List<Restaurant> restaurants = new List<Restaurant>();
        RestaurantDataProvider() { }
        public static RestaurantDataProvider Instance()
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new RestaurantDataProvider();
                    instance.restaurants.Add(new Restaurant(1, "Chai Les Copains", "1 Quai de Bacalan, 33300 Bordeaux", 4.7f, 23.0f, "https://lh5.googleusercontent.com/p/AF1QipNYbnL7vVtW2cWbtZuIXVKBjwkEuQI_b--C6dcP=w408-h544-k-no", 5, RestaurantCategory.French));
                    instance.restaurants.Add(new Restaurant(2, "Le 9...Ô Plat", "9 Rue Camille Godard, 33000 Bordeaux", 4.7f, 25.3f, "https://lh5.googleusercontent.com/p/AF1QipMhUOOtOrUjNfeO2W36sDBQVBKWIp1wWpTL0gtG=w408-h544-k-no", 10, RestaurantCategory.French));
                    instance.restaurants.Add(new Restaurant(3, "IL RISTORANTE", "39 Av. John Fitzgerald Kennedy, 33700 Mérignac", 5, 13.45f, "https://lh5.googleusercontent.com/p/AF1QipO67Gw1cKYcNc9gxfkyYCPkO0c6Ye5JQwuMt5CP=w408-h272-k-no", 13, RestaurantCategory.Italian));
                    instance.restaurants.Add(new Restaurant(4, "Restaurant", "12 rue de la Rue, 33127 Martignas-Sur-Jalle", 5, 23.0f, "https://images.unsplash.com/photo-1517248135467-4c7edcad34c4?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80", 10, RestaurantCategory.Chinese));
                    instance.restaurants.Add(new Restaurant(5, "Restaurant", "12 rue de la Rue, 33127 Martignas-Sur-Jalle", 5, 23.0f, "https://images.unsplash.com/photo-1517248135467-4c7edcad34c4?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80", 10, RestaurantCategory.Chinese));
                    instance.restaurants.Add(new Restaurant(6, "Restaurant", "12 rue de la Rue, 33127 Martignas-Sur-Jalle", 5, 23.0f, "https://images.unsplash.com/photo-1517248135467-4c7edcad34c4?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80", 10, RestaurantCategory.Chinese));
                }
                return instance;
            }
        }
        public void AddRestaurant(Restaurant restaurant)
        {
            throw new NotImplementedException();
        }

        public List<Restaurant> GetRestaurants()
        {
            return restaurants.OrderBy(r => r.Stars).ToList();
        }

    }   
}

