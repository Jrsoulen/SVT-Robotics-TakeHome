using Newtonsoft.Json;
using System;

namespace SVT_Robotics_TakeHome
{
    public class Robot
    {
        [JsonProperty("robotId")]
        public int RobotId { get; set; }

        [JsonProperty("x")]
        public double XCoordinate { get; set; }

        [JsonProperty("y")]
        public double YCoordinate { get; set; }
    }
}
