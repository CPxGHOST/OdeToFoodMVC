using System;
using System.Collections.Generic;
using System.Linq;
using static OdeToFood.Data.Models.CuisineType;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant{  RestaurantId = 1 , Name = "Momo Villa" , Cuisine = Chinese},
                new Restaurant { RestaurantId = 2, Name = "Burger King" , Cuisine = American}
            };
        }
            
        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }
    }

}
