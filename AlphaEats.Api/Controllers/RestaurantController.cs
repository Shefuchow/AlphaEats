using AlphaEats.DataAccess.Models;
using AlphaEats.DataAccess.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AlphaEats.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : Controller
    {
        public RestaurantsService _restaurantsService;

        public RestaurantController(RestaurantsService restaurantsService)
        {
            _restaurantsService = restaurantsService;
        }

        //[HttpGet]
        //public IActionResult GetRestaurantById(int id)
        //{
        //    var restaurant = _restaurantsService.GetRestaurantById(id);
        //    return Ok(restaurant);
        //}

        [HttpGet]
        public IActionResult GetAllRestaurants()
        {
            var allRestaurants = _restaurantsService.GetAllRestaurants();
            return Ok(allRestaurants);
        }

        [HttpPost]
        public IActionResult AddRestaurant([FromBody]Restaurant restaurant)
        {
            _restaurantsService.AddRestaurant(restaurant);
            return Ok();
        }

    }
}
