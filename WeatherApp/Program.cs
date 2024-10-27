using Newtonsoft.Json;
namespace WeatherAPP
{

    public class Programm
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the WeatherAPP");
            ApiHelper apiHelper = new ApiHelper();
            string json = apiHelper.GetWeatherData();
            Console.WriteLine("==========json================");
            Console.WriteLine(json);

            WeatherData weatherData = JsonConvert.DeserializeObject<WeatherData>(json);
            Console.WriteLine("Temperature: " + weatherData.main.temp);
            Console.WriteLine("Description: " + weatherData.weather[0].description);
            Console.WriteLine("Humidity: " + weatherData.main.humidity);
            Console.WriteLine("Wind Speed: " + weatherData.wind.speed);
        
        
        
        }
    }
}