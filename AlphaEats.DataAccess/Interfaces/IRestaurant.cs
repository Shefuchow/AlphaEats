using System;
namespace AlphaEats.DataAccess.Interfaces
{
    public interface IRestaurant
    {
        public string Name { get; set; }
        public int CustomerRating { get; set; }
        public int Distance { get; set; }
        public int Price { get; set; }
        public int CuisineId { get; set; }
    }
}
