using Microsoft.AspNetCore.Mvc;
using Sinhasth2028.Api.Models;
using System.Collections.Generic;
using System.Linq;

namespace Sinhasth2028.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransportController : ControllerBase
    {
        private static readonly List<Transport> _transport = new List<Transport>
        {
            new Transport { Id = 1, Type = "Bus", Route = "Route 1", PickupPoint = "Bus Stand", DropPoint = "Mahakal Temple" },
            new Transport { Id = 2, Type = "Auto", Route = "Route 2", PickupPoint = "Railway Station", DropPoint = "Ram Ghat" }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Transport>> GetTransport()
        {
            return Ok(_transport);
        }
    }
}
