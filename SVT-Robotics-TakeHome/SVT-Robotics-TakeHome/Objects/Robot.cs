using Newtonsoft.Json;
using System.Numerics;

namespace SVT_Robotics_TakeHome
{
    public class Robot
    {
        [JsonProperty("robotId")]
        public int RobotId { get; set; }

        [JsonProperty("batteryLevel")]
        public int BatteryLevel { get; set; }        

        [JsonProperty("x")]
        public float X { get; set; }

        [JsonProperty("y")]
        public float Y { get; set; }
        public Vector2 Coordinates { get; set; }
    }
}
