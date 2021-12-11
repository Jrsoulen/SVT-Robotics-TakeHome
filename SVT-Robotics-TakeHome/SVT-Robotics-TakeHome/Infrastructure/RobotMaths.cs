using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace SVT_Robotics_TakeHome.Infrastructure
{
    public static class RobotMaths
    {
        public static Robot GetOptimalRobotForLoad(List<Robot> robots, Load load)
        {
            Robot optimalRobot = robots.First();
            optimalRobot.Coordinates = new Vector2(optimalRobot.X, optimalRobot.Y);

            float bestDistance;
            foreach (Robot currentRobot in robots)
            {
                currentRobot.Coordinates = new Vector2(currentRobot.X, currentRobot.Y);
                bestDistance = Vector2.Distance(optimalRobot.Coordinates, load.Coordinates);
                var currentDistance = Vector2.Distance(currentRobot.Coordinates, load.Coordinates);
                if (currentDistance < 10)
                {
                    if (optimalRobot.BatteryLevel > currentRobot.BatteryLevel) break;
                    else optimalRobot = currentRobot;
                }
                else if (currentDistance < bestDistance)
                {
                    optimalRobot = currentRobot;
                }
            }

            return optimalRobot;
        }
    }
}
