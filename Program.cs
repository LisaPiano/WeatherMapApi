using Newtonsoft.Json.Linq;
using System.Text.Json.Nodes;
using static System.Net.WebRequestMethods;
using File = System.IO.File;
using System.Net.Http;
using System.IO;
namespace WeatherMapApi
{

    class Program
    {

        static void Main(string[] args)
        {
            //successfully stores the value of the key in the variable, APIKey without alerting github 
            string key = File.ReadAllText("appsettings.json");
            string APIKey = JObject.Parse(key).GetValue("APIKey").ToString();
            //=========================================================================================

            //Get the zipcode from the user and store it in the string variable zipCode
            Console.WriteLine("Please enter your zipcode: ");
            string zipCode = Console.ReadLine();
            //=========================================================================================

            //Built in API request by Zipcode. I have made this URL work on Postman
            var apiCall = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&appid={APIKey}&units=imperial";
            Console.WriteLine("");//add space
                                  //===============================================================================================


            Console.WriteLine($"It is currently {WeatherMap.GetTemp(apiCall)} degrees Farenhiet where you are located! I wish that I were someplace warm and humid!!!");
        
        
        }//end main method



  }//end class
}//end namespace