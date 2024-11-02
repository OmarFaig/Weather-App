using Avalonia.Controls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Threading.Tasks;

namespace WeatherAppGUI
{
    public partial class MainWindow : Window
    {
        private readonly MainWindowViewModel _viewModel;

        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new MainWindowViewModel();
            DataContext = _viewModel; // Set the DataContext to the ViewModel
            FetchWeatherData();
        }

        private async void FetchWeatherData()
        {
            try
            {
                ApiHelper apiHelper = new ApiHelper();
                string json = await apiHelper.GetWeatherDataAsync();
                Console.WriteLine("json " + json);
                WeatherData weatherData = JsonConvert.DeserializeObject<WeatherData>(json);

                // Update the ViewModel properties, which will automatically update the UI
                _viewModel.Temperature = $"Temperature: {weatherData.current.temperature_2m}°C";
                _viewModel.Description = $"Description: {weatherData.current.apparent_temperature}°C";
                _viewModel.Humidity = $"Day/Night: {weatherData.current.is_day}%";
                _viewModel.WindSpeed = $"Wind Speed: {weatherData.current.wind_speed_10m} m/s";

                // Update the daily weather data
                var dailyWeather = new List<DailyWeather>();
                for (int i = 0; i < weatherData.daily.time.Count; i++)
                {
                    dailyWeather.Add(new DailyWeather
                    {
                        Day = weatherData.daily.time[i],
                        Temperature = $"{weatherData.hourly.temperature_2m[i]}°C",
                        Sunrise = weatherData.daily.sunrise[i],
                        Sunset = weatherData.daily.sunset[i]
                    });
                    Console.WriteLine($"Day {i + 1}: {weatherData.daily.time[i]}, Temperature: {weatherData.hourly.temperature_2m[i]}°C, Sunrise: {weatherData.daily.sunrise[i]}, Sunset: {weatherData.daily.sunset[i]}");
                }

                _viewModel.DailyWeather = dailyWeather;

                Console.WriteLine("Temperature " + _viewModel.Temperature);
                Console.WriteLine("Description " + _viewModel.Description);
                Console.WriteLine("Humidity " + _viewModel.Humidity);
                Console.WriteLine("WindSpeed " + _viewModel.WindSpeed);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching weather data: {ex.Message}");
            }
        }
    }
}
