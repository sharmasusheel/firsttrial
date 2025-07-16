using Microsoft.AspNetCore.Mvc;
using Sinhasth2028.Api.Models;
using System.Collections.Generic;
using System.Linq;

namespace Sinhasth2028.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RestaurantsController : ControllerBase
    {
        private static readonly List<Restaurant> _restaurants = new List<Restaurant>
        {
            new Restaurant { Id = 1, Name = "Shree Ganga", Cuisine = "Indian", Address = "Ujjain", OpeningHours = "9am-10pm", ImageUrl = "https://via.placeholder.com/150" },
            new Restaurant { Id = 2, Name = "Domino's Pizza", Cuisine = "Italian", Address = "Ujjain", OpeningHours = "11am-11pm", ImageUrl = "https://via.placeholder.com/150" }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Restaurant>> GetRestaurants()
        {
            return Ok(_restaurants);
        }
    }
}
