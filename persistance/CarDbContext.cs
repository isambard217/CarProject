using CarProject.Models;
using Microsoft.EntityFrameworkCore;

namespace CarProject.persistance
{
    public class CarDbContext : DbContext
    {

        public CarDbContext(DbContextOptions<CarDbContext> options) : base (options)
        {
        }

        public DbSet<Make> Makes {get; set;}

        public DbSet<Feature> Features {get; set; }

      //  public DbSet<Model> Modles { get; set;}

        
    }
}