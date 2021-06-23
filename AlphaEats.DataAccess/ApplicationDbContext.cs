using System;
using AlphaEats.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace AlphaEats.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Cuisine> Cuisines { get; set; }
    }
}
