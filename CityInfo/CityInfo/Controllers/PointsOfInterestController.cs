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
        [HttpGet]
        [Route("")]
        public JsonResult GetPointsOfInterest()
        {
            var pois = POIsDataStore.Current.PointsOfInterest;
            return new JsonResult(pois);
        }

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
