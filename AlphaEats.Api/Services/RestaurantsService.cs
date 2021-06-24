using System.Collections.Generic;
using System.Linq;
using AlphaEats.Models;

namespace AlphaEats.Api.Services
{
    public class RestaurantsService
    {
        private ApplicationDbContext _context;
        public CuisinesService _cuisinesService;

        public RestaurantsService(ApplicationDbContext context, CuisinesService cuisinesService)
        {
            _context = context;
            _cuisinesService = cuisinesService;
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

        //From the csv, I see all unique restaurant names, but we cannot assume this in real life
        public List<Restaurant> GetRestaurantsByName(string name) => _context.Restaurants.Where(e => e.Name.ToLower() == name.ToLower()).ToList();

        public List<Restaurant> GetRestaurantsByPartialName(string partialName) => _context.Restaurants.Where(e => e.Name.ToLower().Contains(partialName.ToLower())).ToList();

        public List<Restaurant> TopFiveRestaurantsFromSearch(string restaurantNameInput, string cuisineNameInput, int distanceInput, int ratingInput, int priceInput)
        {
            var restaurants = GetRestaurantsByName(restaurantNameInput); ;

            if ((restaurants != null) && (!restaurants.Any())) restaurants = GetRestaurantsByPartialName(restaurantNameInput);
     
            var cuisine = _cuisinesService.GetCuisineByName(cuisineNameInput);
            if (cuisine != null)
            {
                restaurants = restaurants.Where(e => e.CuisineId == cuisine.Id).ToList();
            } else
            {
                var cuisines = _cuisinesService.GetCuisinesByPartialName(cuisineNameInput);
                HashSet<int> cuisineIds = new HashSet<int>(cuisines.Select(e => e.Id));
                restaurants = restaurants.Where(e => cuisineIds.Contains(e.CuisineId)).ToList();
            }

            restaurants = restaurants.Where(e => e.Distance <= distanceInput && e.CustomerRating >= ratingInput && e.Price <= priceInput).ToList();

            return restaurants.OrderBy(e => e.Distance).
            ThenByDescending(e => e.CustomerRating).
            ThenBy(e => e.Price).
            Take(5).ToList();

        } 
    }
}
