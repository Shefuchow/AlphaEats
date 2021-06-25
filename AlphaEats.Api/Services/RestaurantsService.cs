using System.Collections.Generic;
using System.Linq;
using AlphaEats.Api.Interfaces;
using AlphaEats.Api.Models;

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

        public void AddRestaurant(IRestaurant restaurant)
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
        public List<Restaurant> GetRestaurantsByName(string name) => _context.Restaurants.Where(e => e.Name.ToLower().Equals(name.ToLower())).Select(y=>y).ToList();

        public List<Restaurant> GetRestaurantsByPartialName(string partialName) => _context.Restaurants.Where(e => e.Name.ToLower().Contains(partialName.ToLower())).ToList();

        public List<Search> TopFiveRestaurantsFromSearch(Search search)
        {
            var restaurants = GetRestaurantsByName(search.RestaurantName); ;

            if ((restaurants != null) && (!restaurants.Any())) restaurants = GetRestaurantsByPartialName(search.RestaurantName);

            var cuisine = _cuisinesService.GetCuisineByName(search.CuisineName);
            if (cuisine != null)
            {
                var searchResults = ConvertSearchResults(restaurants);
                searchResults = FilterForCuisine(searchResults, cuisine);
                return TopSpecificedAmountOfRestaurants(search, searchResults, 5);

            }
            else
            {
                var searchResults = ConvertSearchResults(restaurants);
                searchResults = FilterForCuisine(searchResults, search);
                return TopSpecificedAmountOfRestaurants(search, searchResults, 5);
            }

        }

        //-------------------------------------------------------------- HELPER FUNCTIONS --------------------------------------------------------

        private List<Search> TopSpecificedAmountOfRestaurants(Search search, List<Search> restaurants, int number)
        {
            restaurants = restaurants.Where(e => e.Distance <= search.Distance && e.CustomerRating >= search.CustomerRating && e.Price <= search.Price).ToList();

            return restaurants.OrderBy(e => e.Distance).
            ThenByDescending(e => e.CustomerRating).
            ThenBy(e => e.Price).
            Take(number).ToList();
        }

        private List<Search> ConvertSearchResults(List<Restaurant> restaurants)
        {
            var restaurantResults = new List<Search>();
            foreach (Restaurant restaurant in restaurants)
            {
                restaurantResults.Add(new Search(restaurant.Name, restaurant.CustomerRating, restaurant.Distance, restaurant.Price, restaurant.CuisineId));
            }
            return restaurantResults;
        }

        private List<Search> FilterForCuisine(List<Search> restaurants, Cuisine cuisine)
        {
            restaurants = restaurants.Where(e => e.CuisineId == cuisine.Id).ToList();
            foreach (Search restaurant in restaurants)
            {
                restaurant.CuisineName = cuisine.Name;
            }
            return restaurants;
        }

        private List<Search> FilterForCuisine(List<Search> restaurants, Search search)
        {
            var cuisines = _cuisinesService.GetCuisinesByPartialName(search.CuisineName);
            Dictionary<int, string> cuisineDictionary = cuisines.ToDictionary(e => e.Id, e => e.Name);
            restaurants = restaurants.Where(e => cuisineDictionary.ContainsKey((int)e.CuisineId)).ToList();
            foreach (Search restaurant in restaurants)
            {
                if (cuisineDictionary.ContainsKey((int)restaurant.CuisineId)) restaurant.CuisineName = cuisineDictionary[(int)restaurant.CuisineId];
            }
            return restaurants;
        }

    }
}