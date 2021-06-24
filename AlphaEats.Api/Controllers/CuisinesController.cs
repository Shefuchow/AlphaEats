using AlphaEats.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace AlphaEats.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CuisinesController : Controller
    {
        public CuisinesService _cuisinesService;

        public CuisinesController(CuisinesService cuisineService)
        {
            _cuisinesService = cuisineService;
        }

        [HttpGet("all-cuisines")]
        public IActionResult GetAllCuisines()
        {
            var allCuisines = _cuisinesService.GetAllCuisines();
            return Ok(allCuisines);
        }

        [HttpGet("cuisines-by-name")]
        public IActionResult GetCuisineByName([FromQuery] string name)
        {
            var cuisine = _cuisinesService.GetCuisineByName(name);
            return Ok(cuisine);
        }
    }
}