using CityInfo.Entities;
using Microsoft.EntityFrameworkCore;

namespace CityInfo.Contexts
{
    public class CityInfoContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<PointOfInterest> PointsOfInterest { get; set; }

        public DbSet<User> Users { get; set; }
        public CityInfoContext(DbContextOptions<CityInfoContext> options)
           : base(options)
        {
            //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>()
                 .HasData(
                new City()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The one with that big park.",
                    GoogleMapsUrl = "https://goo.gl/maps/6CzStBQzmS46u6Z69"
                },
                new City()
                {
                    Id = 2,
                    Name = "Antwerp",
                    Description = "The one with the cathedral that was never really finished.",
                    GoogleMapsUrl = "https://goo.gl/maps/eGrxrSKEyMb1H9Lm7"
                },
                new City()
                {
                    Id = 3,
                    Name = "Paris",
                    Description = "The one with that big tower.",
                    GoogleMapsUrl = "https://goo.gl/maps/SLHYQd8Vu1U2Xv8M6"
                });


            modelBuilder.Entity<PointOfInterest>()
              .HasData(
                new PointOfInterest()
                {
                    Id = 1,
                    CityId = 1,
                    Name = "Central Park",
                    Description = "The most visited urban park in the United States.",
                    GoogleMapsUrl = "https://goo.gl/maps/iWzWAr2jXvehXVTJ6"

                },
                new PointOfInterest()
                {
                    Id = 2,
                    CityId = 1,
                    Name = "Empire State Building",
                    Description = "A 102-story skyscraper located in Midtown Manhattan.",
                    GoogleMapsUrl = "https://goo.gl/maps/9zkBjJfY3wgjcX488"
                },
                  new PointOfInterest()
                  {
                      Id = 3,
                      CityId = 2,
                      Name = "Cathedral",
                      Description = "A Gothic style cathedral, conceived by architects Jan and Pieter Appelmans.",
                      GoogleMapsUrl = "https://goo.gl/maps/8fdVULE4Diss8uHq6"
                  },
                new PointOfInterest()
                {
                    Id = 4,
                    CityId = 2,
                    Name = "Antwerp Central Station",
                    Description = "The the finest example of railway architecture in Belgium.",
                    GoogleMapsUrl = "https://goo.gl/maps/5a558knHtLdXeRSW6"
                },
                new PointOfInterest()
                {
                    Id = 5,
                    CityId = 3,
                    Name = "Eiffel Tower",
                    Description = "A wrought iron lattice tower on the Champ de Mars, named after engineer Gustave Eiffel.",
                    GoogleMapsUrl = "https://goo.gl/maps/UCY5ATXU2hig95ZR9"
                },
                new PointOfInterest()
                {
                    Id = 6,
                    CityId = 3,
                    Name = "The Louvre",
                    Description = "The world's largest museum.",
                    GoogleMapsUrl = "https://goo.gl/maps/6SUECXNRKev1K9aL8"
                }
                );
            modelBuilder.Entity<User>()
                 .HasData(
                new User()
                {
                    Id = 1,
                    Username = "admin",
                    Password = "admin",
                    IsAdmin = true,
                },
                new User()
                {
                    Id = 2,
                    Username = "user",
                    Password = "user",
                    IsAdmin = false,
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}
