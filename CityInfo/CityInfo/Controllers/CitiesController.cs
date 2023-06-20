using CityInfo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CityInfo.Controllers
{
  [ApiController]
  [Route("api/cities")]
  public class CitiesController : Controller
  {
    [HttpGet]
    [Route("")]
    public JsonResult GetCities()
    {
      var cities = CitiesDataStore.Current.Cities;
      return new JsonResult(cities);
    }

    [HttpGet]
    [Route("{id}")]
    public IActionResult GetCityById(int id)
    {
      var cities = CitiesDataStore.Current.Cities;
      CityDto city = cities.Where(x => x.Id == id).FirstOrDefault();

      if (city == null)
      {
        return NotFound(city);
      }

      return Ok(city);
    }

    [HttpPost]
    [Route("")]
    public JsonResult CreateCity([FromBody]CityDto city)
    {
      var cities = CitiesDataStore.Current.Cities;
      cities.Add(city);

      return new JsonResult(cities);
    }
        [HttpDelete]
        [Route("")]
        public JsonResult DeleteCity([FromBody] CityDto city)
        {
            var cities = CitiesDataStore.Current.Cities;
            cities.Remove(city);

            return new JsonResult(cities);
        }
    }
}
