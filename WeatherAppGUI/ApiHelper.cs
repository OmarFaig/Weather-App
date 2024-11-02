using System.Net.Http;
using System;
using System.Threading.Tasks; // Add this line

namespace WeatherAppGUI
{
    public class ApiHelper
    {
        /*

        url = ""
        params = {
            "latitude": 48.1374,
            "longitude": 11.5755,
            "current": ["temperature_2m", "apparent_temperature", "is_day", "wind_speed_10m", "wind_direction_10m"],
            "hourly": "temperature_2m",
            "daily": ["sunrise", "sunset"],
	        "timezone": "Europe/Berlin"
}*/
        //private readonly string _apiUrl = "https://api.openweathermap.org/data/2.5/weather?q=Munich&appid=2798747f9cf45697426cfb4dda1d5539";
        private readonly string _apiUrl = "https://api.open-meteo.com/v1/forecast";
        private readonly HttpClient _client;

        public ApiHelper()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(_apiUrl);
        }

        public async Task<string> GetWeatherDataAsync()
        {
            var queryString = "?latitude=48.1374&longitude=11.5755&current=temperature_2m,apparent_temperature,is_day,wind_speed_10m,wind_direction_10m&hourly=temperature_2m&daily=sunrise,sunset&timezone=Europe/Berlin";

            // Send a GET request and await the response asynchronously
            HttpResponseMessage response = await _client.GetAsync(queryString);

            // Ensure the request was successful
            response.EnsureSuccessStatusCode();
            Console.WriteLine(response.Content);
            // Return the response content as a string
            return await response.Content.ReadAsStringAsync();
        }
    }
}
