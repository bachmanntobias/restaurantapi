using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestaurantAPI.Models;
using RestaurantAPI.Services;

namespace RestaurantAPI.Services
{
    public class InMemoryData : IRestaurantData
    {
        

        public InMemoryData()
        {

            _restaurants = new List<Restaurant>
            {
                      new Restaurant { Id=1, Name="Pizzeria"},
                      new Restaurant { Id=2, Name="Dönerladen"},
                      new Restaurant { Id=3, Name="Kneipe2"}
            };

         }

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants.OrderBy(r => r.Name);
        }

        List<Restaurant> _restaurants;
    }
}
