using Microsoft.AspNetCore.Mvc;
using Sinhasth2028.Api.Models;
using System.Collections.Generic;
using System.Linq;

namespace Sinhasth2028.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmergencyController : ControllerBase
    {
        private static readonly List<EmergencyService> _emergencyServices = new List<EmergencyService>
        {
            new EmergencyService { Id = 1, Name = "District Hospital", Type = "Hospital", ContactNumber = "102", Address = "Ujjain" },
            new EmergencyService { Id = 2, Name = "Police Control Room", Type = "Police", ContactNumber = "100", Address = "Ujjain" }
        };

        [HttpGet]
        public ActionResult<IEnumerable<EmergencyService>> GetEmergencyServices()
        {
            return Ok(_emergencyServices);
        }
    }
}
