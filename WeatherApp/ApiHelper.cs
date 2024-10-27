namespace WeatherAPP
{

    public class ApiHelper
    {
        public string API_URL = "https://api.openweathermap.org/data/2.5/weather?q=Munich&appid=2798747f9cf45697426cfb4dda1d5539";

        public HttpClient client;

        public ApiHelper()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(API_URL);
        }
        public string GetWeatherData()
        {
            return client.GetStringAsync(API_URL).Result;
        }

    }
}