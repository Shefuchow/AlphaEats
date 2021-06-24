using System.ComponentModel.DataAnnotations;
using AlphaEats.Interfaces;

namespace AlphaEats.Models
{
    public class Restaurant : IRestaurant
    {
        [Key]
        public string Name { get; set; }
        public int CustomerRating { get; set; }
        public int Distance { get; set; }
        public int Price { get; set; }
        public int CuisineId { get; set; }
        public string CuisineName { get; set; }
    }
}