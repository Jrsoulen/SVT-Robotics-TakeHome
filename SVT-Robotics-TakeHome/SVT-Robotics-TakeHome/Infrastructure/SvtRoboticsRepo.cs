using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Numerics;
using System.Threading.Tasks;

namespace SVT_Robotics_TakeHome.Infrastructure
{
    public class SvtRoboticsRepo
    {
        public async Task<List<Robot>> GetAvailableRobotsAsync()
        {
            var url = "https://60c8ed887dafc90017ffbd56.mockapi.io/robots";
            List<Robot> availableRobots = new List<Robot>();

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    availableRobots = JsonConvert.DeserializeObject<List<Robot>>(data);
                }
            }

            return availableRobots;
        }
    }
}
