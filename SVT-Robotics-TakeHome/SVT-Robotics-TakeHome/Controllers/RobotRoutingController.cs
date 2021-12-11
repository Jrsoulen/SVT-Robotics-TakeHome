using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SVT_Robotics_TakeHome.Infrastructure;

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
            var repo = new SvtRoboticsRepo();
            var load = JsonConvert.DeserializeObject<Load>(postData);

            var availableRobots = repo.GetAvailableRobotsAsync().Result;

            return RobotMaths.GetOptimalRobotForLoad(availableRobots, load);
        }
    }
}
