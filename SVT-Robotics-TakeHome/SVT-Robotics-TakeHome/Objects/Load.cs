using Newtonsoft.Json;
using System.Numerics;

namespace SVT_Robotics_TakeHome
{
    public class Load
    {
        [JsonProperty("loadId")]
        public int LoadId { get; set; }
        [JsonProperty("x")]
        public float X { get; set; }
        [JsonProperty("y")]
        public float Y { get; set; }
        public Vector2 Coordinates { get; set; }
    }
}
