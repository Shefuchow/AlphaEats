using System.ComponentModel.DataAnnotations;
using AlphaEats.Api.Interfaces;

namespace AlphaEats.Api.Models
{
    public class Restaurant : IRestaurant
    {
        [Key]
        public string Name { get; set; }
        public int CustomerRating { get; set; }
        public int Distance { get; set; }
        public int Price { get; set; }
        public int CuisineId { get; set; }
    }
}