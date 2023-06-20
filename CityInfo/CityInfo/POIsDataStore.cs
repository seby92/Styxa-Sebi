using CityInfo.Models;
using System.Collections.Generic;

namespace CityInfo
{
    public class POIsDataStore
    {
        public static POIsDataStore Current { get; } = new POIsDataStore();
        public List<PointOfInterestDto> PointsOfInterest { get; set; }
        public POIsDataStore()
        {
            // init dummy data
            PointsOfInterest = new List<PointOfInterestDto>()
            {
                new PointOfInterestDto()
                {
                     Id = 1,
                     Name = "Central Park",
                     Description = "The big park."
                },
                new PointOfInterestDto()
                {
                    Id = 2,
                    Name = "Cathedral of Our Lady",
                    Description = "The cathedral that was never really finished."
                },
                new PointOfInterestDto()
                {
                    Id= 3,
                    Name = "Eiffel Tower",
                    Description = "The big tower."
                }
            };
        }
    }
    
}
