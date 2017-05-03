using CarProject.Models;
using Microsoft.EntityFrameworkCore;

namespace CarProject.persistance
{
    public class CarDbContext : DbContext
    {

        // Properties 
        public DbSet<Make> Makes {get; set;}

        public DbSet<Feature> Features {get; set; }

        public DbSet<Vehicle> Vehicles { get; set; }

        public DbSet<Model> Models { get; set;}

        public DbSet<Demo> Demos { get; set; }
        

        // Constructors 
        public CarDbContext(DbContextOptions<CarDbContext> options)
         : base (options)
        {
        }


        // Other methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

                // Bridge table
                modelBuilder.Entity<VehicleFeature>().HasKey(vf => 
                    new { vf.VehicleId, vf.FeatureId });


                // Vehicle Domain setup
                modelBuilder.Entity<Vehicle>()
                        .Property(v => v.Id)
                        .IsRequired();
                        
                                

                // Model domain setup
                modelBuilder.Entity<Model>()
                        .Property(m => m.Id)
                        .IsRequired();

                
                // Vehicle domain setup


            
        }


        
    }
}