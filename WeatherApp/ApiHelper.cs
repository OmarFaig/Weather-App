namespace WeatherAPP
{

    public class ApiHelper
    {
        public string API_URL = "";

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