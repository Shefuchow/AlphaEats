using System;
using System.Collections.Generic;
using System.Linq;
using AlphaEats.DataAccess.Interfaces;
using AlphaEats.DataAccess.Models;

namespace AlphaEats.DataAccess.Services
{
    public class RestaurantsService
    {
        private ApplicationDbContext _context;

        public RestaurantsService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddRestaurant(Restaurant restaurant)
        {
            var _restaurant = new Restaurant()
            {
                Name = restaurant.Name,
                CustomerRating = restaurant.CustomerRating,
                Distance = restaurant.Distance,
                Price = restaurant.Price,
                CuisineId = restaurant.CuisineId
            };
            _context.Restaurants.Add(_restaurant);
        }

        public List<Restaurant> GetAllRestaurants() => _context.Restaurants.ToList();

        public Restaurant GetRestaurantById(int id) => _context.Restaurants.FirstOrDefault(e => e.CuisineId == id);
    }
}
