using Microsoft.AspNetCore.Mvc;
using SVT_Robotics_TakeHome.Infrastructure;
using System.Numerics;

namespace SVT_Robotics_TakeHome.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RobotRoutingController : ControllerBase
    {
        [HttpPost]
        [Route("GetRobotForLoad")]
        public RobotResponse GetRobotForLoad([FromBody] Load load)
        {
            var repo = new SvtRoboticsRepo();
            var availableRobots = repo.GetAvailableRobotsAsync().Result;

            var optimalRobot = RobotMaths.GetOptimalRobotForLoad(availableRobots, load);

            return new RobotResponse()
            {
                RobotId = optimalRobot.RobotId,
                DistanceToGoal = Vector2.Distance(optimalRobot.Coordinates, load.Coordinates),
                BatteryLevel = optimalRobot.BatteryLevel
            };
        }
        [HttpGet]
        [Route("ping")]
        public string ping()
        {
            return System.DateTime.Now.ToString();
        }
    }
}
