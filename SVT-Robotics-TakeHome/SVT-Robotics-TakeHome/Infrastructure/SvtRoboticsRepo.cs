using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace SVT_Robotics_TakeHome.Infrastructure
{
    public class SvtRoboticsRepo
    {
        public async Task<Robot> GetRobotForLoadAsync(Load load)
        {
            var url = "https://60c8ed887dafc90017ffbd56.mockapi.io/robots";

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    // deserialize first since json is your response type
                    var table = Newtonsoft.Json.JsonConvert.DeserializeObject(data);
                }
            }

            return new Robot();
        }
    }
}
