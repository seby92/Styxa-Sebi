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
    [Route("api/poi")]
    public class PointsOfInterestController : Controller
    {
        //private readonly PointsOfInterestController _ctx;
        //private readonly IMapper _mapper;

        //public PointsOfInterestController(CityInfoContext ctx, IMapper mapper)
        //{
        //    _ctx = ctx; /*?? throw new ArgumentNullException(nameof(ctx));*/
        //    _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        //}

        [HttpGet]
        [Route("")]
        public JsonResult GetPointsOfInterest()
        {
            var pois = POIsDataStore.Current.PointsOfInterest;
            return new JsonResult(pois);
        }
        //public IActionResult GetPointsOfInterest()
        //{
        //    List<PointOfInterest> pointsOfInterestEntitiesList = _ctx;

        //    List<PointOfInterestDto> pointsOfInterestResponsesList = _mapper.Map<List<PointOfInterestDto>>(pointsOfInterestEntitiesList);

        //    return Ok(pointsOfInterestResponsesList);
        //}

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetPointOfInterest(int id)
        {
            var pois = POIsDataStore.Current.PointsOfInterest;
            PointOfInterestDto pointOfInterest = pois.Where(x => x.Id == id).FirstOrDefault();

            if (pointOfInterest == null)
            {
                return NotFound(pointOfInterest);
            }

            return Ok(pointOfInterest);
        }

        [HttpPost]
        [Route("")]
        public JsonResult CreatePoi([FromBody] PointOfInterestDto pointOfInterest)
        {
            var pois = POIsDataStore.Current.PointsOfInterest;
            pois.Add(pointOfInterest);

            return new JsonResult(pois);
        }
        [HttpDelete]
        [Route("")]
        public JsonResult DeletePoi([FromBody] PointOfInterestDto pointOfInterest)
        {
            var pois = POIsDataStore.Current.PointsOfInterest;
            pois.Remove(pointOfInterest);

            return new JsonResult(pois);
        }
    }
}
