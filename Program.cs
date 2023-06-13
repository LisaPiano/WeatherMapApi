using Newtonsoft.Json.Linq;
using System.Text.Json.Nodes;
using static System.Net.WebRequestMethods;

namespace WeatherMapApi
{

    class Program
    {

        static void Main(string[] args)
        {
            //var lat = 37.270500;
            //var lon = -107.878700;
    
            var city = "durango";

            var client = new HttpClient();
            var weatherURL = "https://api.openweathermap.org/data/2.5/forecast?q={city}&appid={api}&units=imperial";
            var weatherResponse = client.GetAsync(weatherURL).Result;
            Console.WriteLine(weatherResponse);
            //JObject parsedResponse = JObject.Parse(weatherResponse);
            //var temp = parsedResponse["list"][0]["main"]["temp"];
            //Console.WriteLine(temp);


    }//end main method
  }//end class
}//end namespace