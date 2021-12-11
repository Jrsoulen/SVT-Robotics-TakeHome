using Newtonsoft.Json;
using System;

namespace SVT_Robotics_TakeHome
{
    public class Load
    {
        [JsonProperty("loadId")]
        public int LoadId { get; set; }
        [JsonProperty("x")]

        public double XCoordinate { get; set; }
        [JsonProperty("y")]
        public double YCoordinate { get; set; }
    }
}
