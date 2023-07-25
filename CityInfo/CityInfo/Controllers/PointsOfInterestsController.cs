using AutoMapper;
using CityInfo.Contexts;
using CityInfo.Entities;
using CityInfo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CityInfo.Controllers
{
    [ApiController]
    [Route("api/cities/{cityId}/pointsofinterest")]
    public class PointsOfInterestsController : Controller
    {
        private readonly CityInfoContext _ctx;
        private readonly IMapper _mapper;

        public PointsOfInterestsController(CityInfoContext ctx, IMapper mapper)
        {
            _ctx = ctx ?? throw new ArgumentNullException(nameof(ctx));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        [Route("")]
        public IActionResult GetPointsOfInterest(int cityId)
        {
            List<PointOfInterest> pointsOfInterestEntitiesList = _ctx.PointsOfInterest.Where(x => x.CityId == cityId).ToList();

            List<PointOfInterestDto> pointsOfInterestResponsesList = _mapper.Map<List<PointOfInterestDto>>(pointsOfInterestEntitiesList);
             

            return Ok(pointsOfInterestResponsesList);

            //var pointsOfInterest = _ctx.PointsOfInterest;
            //PointOfInterest pointsOfInterestEntitiesList = pointsOfInterest.Where(x => x.Id == id).FirstOrDefault();

            //if (pointsOfInterestEntitiesList == null)
            //{
            //    return NotFound(pointsOfInterestEntitiesList);
            //}

            //return Ok(pointsOfInterestEntitiesList);
        }

        //[HttpGet]
        //[Route("{id}")]
        //public IActionResult GetPointOfInterest(int cityId, int id)
        //{
        //    CityDto city = CitiesDataStore.Current.Cities.FirstOrDefault(x => x.Id == cityId);

        //    if (city == null)
        //    {
        //        return BadRequest();
        //    }

        //    return Ok(city.PointsOfInterest.FirstOrDefault(x => x.Id == id));
        //}

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

        //[HttpDelete]
        //[Route("{id}")]
        //public IActionResult DeletePoi(int cityId, int id, [FromBody] PointOfInterestDto pointOfInterest)
        //{
        //    CityDto city = CitiesDataStore.Current.Cities.FirstOrDefault(x => x.Id == cityId);

        //    if (city == null)
        //    {
        //        return BadRequest();
        //    }
        //    var poi = city.PointsOfInterest.FirstOrDefault(x => x.Id == id);

        //    city.Remove(poi); // itt nem tudom, hogy mit kell csinalni

        //    return new JsonResult(city);
        //}
    }
}
