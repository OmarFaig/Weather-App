using Avalonia;
using System;
using Newtonsoft.Json;
namespace WeatherAppGUI{


public class Programm
    {
            [STAThread]
    public static void Main(string[] args) => BuildAvaloniaApp()
        .StartWithClassicDesktopLifetime(args);
        
          // Console.WriteLine("Welcome to the WeatherAPP");
          // ApiHelper apiHelper = new ApiHelper();
          // string json = apiHelper.GetWeatherData();
          // Console.WriteLine("==========json================");
          // Console.WriteLine(json);

          // WeatherData weatherData = JsonConvert.DeserializeObject<WeatherData>(json);
          // Console.WriteLine("Temperature: " + weatherData.main.temp);
          // Console.WriteLine("Description: " + weatherData.weather[0].description);
          // Console.WriteLine("Humidity: " + weatherData.main.humidity);
          // Console.WriteLine("Wind Speed: " + weatherData.wind.speed);
       
    // Avalonia configuration, don't remove; also used by visual designer.
    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>()
            .UsePlatformDetect()
            .WithInterFont()
            .LogToTrace();
     
    }
}