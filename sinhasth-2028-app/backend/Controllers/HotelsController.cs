using Microsoft.AspNetCore.Mvc;
using Sinhasth2028.Api.Models;
using System.Collections.Generic;
using System.Linq;

namespace Sinhasth2028.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HotelsController : ControllerBase
    {
        private static readonly List<Hotel> _hotels = new List<Hotel>
        {
            new Hotel
            {
                Id = 1,
                Name = "Hotel Mahakal",
                Address = "Ujjain",
                ImageUrl = "https://via.placeholder.com/150",
                Rooms = new List<Room>
                {
                    new Room { Id = 1, Type = "Standard", Capacity = 2, Price = 1000, IsAvailable = true },
                    new Room { Id = 2, Type = "Deluxe", Capacity = 2, Price = 2000, IsAvailable = true }
                }
            },
            new Hotel
            {
                Id = 2,
                Name = "Hotel Shipra",
                Address = "Ujjain",
                ImageUrl = "https://via.placeholder.com/150",
                Rooms = new List<Room>
                {
                    new Room { Id = 3, Type = "Standard", Capacity = 2, Price = 1200, IsAvailable = false },
                    new Room { Id = 4, Type = "Suite", Capacity = 4, Price = 3000, IsAvailable = true }
                }
            }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Hotel>> GetHotels([FromQuery] decimal? maxPrice)
        {
            var hotels = _hotels.AsQueryable();

            if (maxPrice.HasValue)
            {
                hotels = hotels.Select(h => new Hotel
                {
                    Id = h.Id,
                    Name = h.Name,
                    Address = h.Address,
                    ImageUrl = h.ImageUrl,
                    Rooms = h.Rooms.Where(r => r.Price <= maxPrice.Value).ToList()
                }).Where(h => h.Rooms.Any());
            }

            return Ok(hotels.ToList());
        }
    }
}
