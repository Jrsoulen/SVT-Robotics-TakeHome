using System.Collections.Generic;
using System.Linq;
using System.Numerics;
// Vector2.Distance is better than writing my own distance calc since I get guaranteed best practices
// But, just for the record, I do know how to do that if needed :)

namespace SVT_Robotics_TakeHome.Infrastructure
{
    public static class RobotMaths
    {
        public static Robot GetOptimalRobotForLoad(List<Robot> robots, Load load)
        {
            // Set optimal to any robot
            Robot optimalRobot = robots.First();

            // Use Vector2 for x,y plane maths library
            optimalRobot.Coordinates = new Vector2(optimalRobot.X, optimalRobot.Y);
            load.Coordinates = new Vector2(load.X, load.Y);

            float bestDistance = Vector2.Distance(optimalRobot.Coordinates, load.Coordinates);

            foreach (Robot currentRobot in robots)
            {
                currentRobot.Coordinates = new Vector2(currentRobot.X, currentRobot.Y);                
                var currentDistance = Vector2.Distance(currentRobot.Coordinates, load.Coordinates);

                // If distances less than 10, choose better battery
                if (currentDistance < 10 && bestDistance < 10)
                {
                    if (optimalRobot.BatteryLevel > currentRobot.BatteryLevel) break;
                    else optimalRobot = currentRobot;
                }
                // Otherwise if the bestDistance is beat, use the currentRobot
                else if (currentDistance < bestDistance)
                {
                    optimalRobot = currentRobot;
                    bestDistance = currentDistance;
                }
            }

            return optimalRobot;
        }
    }
}
