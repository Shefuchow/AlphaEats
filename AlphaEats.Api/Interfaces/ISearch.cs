namespace AlphaEats.Api.Interfaces
{
    public interface ISearch
    {
        public string RestaurantName { get; set; }
        public int CustomerRating { get; set; }
        public int Distance { get; set; }
        public int Price { get; set; }
        public int CuisineId { get; set; }
        public string? CuisineName { get; set; }
    }
}
