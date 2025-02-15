﻿using AlphaEats.Api.Interfaces;

namespace AlphaEats.Api.Models
{
    public class Search : ISearch
    {
        public string RestaurantName { get; set; }
        public int CustomerRating { get; set; }
        public int Distance { get; set; }
        public int Price { get; set; }
        public int CuisineId { get; set; }
        public string? CuisineName { get; set; }

        public Search(string restaurantName, int customerRating, int distance, int price, int cuisineId)
        {
            RestaurantName = restaurantName;
            CustomerRating = customerRating;
            Distance = distance;
            Price = price;
            CuisineId = cuisineId;
        }
    }
}