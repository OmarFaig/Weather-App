using System.Net.Http;
using System;
using System.Threading.Tasks; // Add this line

namespace WeatherAppGUI
{
    public class ApiHelper
    {
        private readonly string _apiUrl = "https://api.openweathermap.org/data/2.5/weather?q=Munich&appid=2798747f9cf45697426cfb4dda1d5539";
        private readonly HttpClient _client;

        public ApiHelper()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(_apiUrl);
        }

        public async Task<string> GetWeatherDataAsync()
        {
            // Send a GET request and await the response asynchronously
            HttpResponseMessage response = await _client.GetAsync("");

            // Ensure the request was successful
            response.EnsureSuccessStatusCode();
            Console.WriteLine(response.Content);
            // Return the response content as a string
            return await response.Content.ReadAsStringAsync();
        }
    }
}
