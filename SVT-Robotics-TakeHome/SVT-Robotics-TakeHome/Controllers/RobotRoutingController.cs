using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SVT_Robotics_TakeHome.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RobotRoutingController : ControllerBase
    {
        private readonly ILogger<RobotRoutingController> _logger;

        public RobotRoutingController(ILogger<RobotRoutingController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public Robot GetRobotForLoad(string postData)
        {
            return new Robot();
        }
    }
}
