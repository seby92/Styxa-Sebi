using CityInfo.Entities;
using CityInfo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CityInfo.Controllers
{
    [ApiController]
    [Route("api/cities/{cityId}/pointsOfInterest")]
    public class PointsOfInterestsController : Controller
    {
        [HttpGet]
        public IActionResult GetPointOfInterests(int cityId)
        {
            CityDto city = CitiesDataStore.Current.Cities.FirstOrDefault(x => x.Id == cityId);

            if (city == null)
            {
                return BadRequest();
            }

            return Ok(city.PointsOfInterest);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetPointOfInterest(int cityId, int id)
        {
            CityDto city = CitiesDataStore.Current.Cities.FirstOrDefault(x => x.Id == cityId);

            if (city == null)
            {
                return BadRequest();
            }

            return Ok(city.PointsOfInterest.FirstOrDefault(x => x.Id == id));
        }

        [HttpPost]
        public IActionResult CreatePointOfInterest(int cityId, [FromBody] PointOfInterestDto poi)
        {
            CityDto city = CitiesDataStore.Current.Cities.FirstOrDefault(x => x.Id == cityId);

            if (city == null)
            {
                return BadRequest();
            }

            if (poi.Description == poi.Name)
            {
                ModelState.AddModelError(
                    "Description",
                    "The provided description should be different from the name.");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            int maxId = CitiesDataStore.Current.Cities
              .SelectMany(x => x.PointsOfInterest)
              .Max(x => x.Id);

            poi.Id = ++maxId;
            city.PointsOfInterest.Add(poi);

            return Ok(city.PointsOfInterest);
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult UpdatePointOfInterest(int cityId, int id, [FromBody] PointOfInterestDto poiFromBody)
        {
            CityDto city = CitiesDataStore.Current.Cities.FirstOrDefault(x => x.Id == cityId);

            if (city == null)
            {
                return BadRequest();
            }

            var poi = city.PointsOfInterest.FirstOrDefault(x => x.Id == id);

            poi.Name = poiFromBody.Name;
            poi.Description = poiFromBody.Description;

            return Ok(city.PointsOfInterest);
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeletePoi(int cityId, int id, [FromBody] PointOfInterestDto pointOfInterest)
        {
            CityDto city = CitiesDataStore.Current.Cities.FirstOrDefault(x => x.Id == cityId);

            if (city == null)
            {
                return BadRequest();
            }
            var poi = city.PointsOfInterest.FirstOrDefault(x => x.Id == id);

            city.Remove(poi); // itt nem tudom, hogy mit kell csinalni

            return new JsonResult(city);
        }
    }
}
