using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CityInfo.Models
{
    public class CityDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "City name is required")]
        public string Name { get; set; }
        [MinLength(3, ErrorMessage = "Description length is mininum 3 characters")]
        [MaxLength(200, ErrorMessage = "Description length is maximum 200 characters")]
        public string Description { get; set; }
        public string GoogleMapsUrl { get; set; }
        public List<PointOfInterestDto> PointsOfInterest { get; set; }
      = new List<PointOfInterestDto>();

        public int PoiNumber { get => PointsOfInterest.Count; }

        public CityDto() { }
        public CityDto(int id, string name, string description, string googleMapsUrl)
        {
            Id = id;
            Name = name;
            Description = description;
            GoogleMapsUrl = googleMapsUrl;
        }
    }
}
