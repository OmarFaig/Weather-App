using Avalonia.Controls;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace WeatherAppGUI
{
    public partial class MainWindow : Window
    {
        public string? Temperature { get; set; }
        public string? Description { get; set; }
        public string? Humidity { get; set; }
        public string? WindSpeed { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            FetchWeatherData();
            DataContext = new MainWindowViewModel(); // Set the DataContext to the ViewModel
        }

        private async void FetchWeatherData()
        {
            try
            {
                ApiHelper apiHelper = new ApiHelper();
                string json = await apiHelper.GetWeatherDataAsync();

                WeatherData weatherData = JsonConvert.DeserializeObject<WeatherData>(json);
                Temperature = $"Temperature: {weatherData.main.temp}°C";
                Description = $"Description: {weatherData.weather[0].description}";
                Humidity = $"Humidity: {weatherData.main.humidity}%";
                WindSpeed = $"Wind Speed: {weatherData.wind.speed} m/s";

                // Trigger the UI to update
                this.DataContext = null;
                this.DataContext = this;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching weather data: {ex.Message}");
            }
        }
    }
}
