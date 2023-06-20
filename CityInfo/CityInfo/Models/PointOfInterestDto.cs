namespace CityInfo.Models
{
  public class PointOfInterestDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public PointOfInterestDto() { }
        public PointOfInterestDto(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
    }
}
