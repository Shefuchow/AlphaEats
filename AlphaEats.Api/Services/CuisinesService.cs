using System.Collections.Generic;
using System.Linq;
using AlphaEats.Models;

namespace AlphaEats.Api.Services
{
    public class CuisinesService
    {

        ApplicationDbContext _context;

        public CuisinesService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Cuisine> GetAllCuisines() => _context.Cuisines.ToList();

        public Cuisine GetCuisineByName(string name) => _context.Cuisines.FirstOrDefault(e => e.Name.ToLower() == name.ToLower());

        public List<Cuisine> GetCuisinesByPartialName(string partialName) => _context.Cuisines.Where(e => e.Name.ToLower().Contains(partialName.ToLower())).ToList();

    }
}
