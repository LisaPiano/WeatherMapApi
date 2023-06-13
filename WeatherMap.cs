using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace WeatherMapApi
{
    public class WeatherMap
    {
        public static double GetTemp(string apiCall)
       {
            //Creating a new instance of a "browser" objects, which allows us to uses Http on the web
            var client = new HttpClient();
            //==================================================================================


            var response = client.GetStringAsync(apiCall).Result;
            //=====================================================================================


            //retreiving an object, turning it to a string, and then parsing it as a double
            var temp = double.Parse(JObject.Parse(response)["main"]["temp"].ToString());
            return temp;
        }
    }
}
