using Newtonsoft.Json;

namespace SVT_Robotics_TakeHome
{
    public class RobotResponse
    {
        [JsonProperty("robotId")]
        public int RobotId { get; set; }
        
        [JsonProperty("distanceToGoal")]
        public float DistanceToGoal { get; set; }

        [JsonProperty("batteryLevel")]
        public float BatteryLevel { get; set; }
    }
}
