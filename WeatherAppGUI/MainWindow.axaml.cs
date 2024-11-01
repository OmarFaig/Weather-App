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
                _viewModel.Temperature = $"Temperature: {weatherData.main.temp}°C";
                _viewModel.Description = $"Description: {weatherData.weather[0].description}";
                _viewModel.Humidity = $"Humidity: {weatherData.main.humidity}%";
                _viewModel.WindSpeed = $"Wind Speed: {weatherData.wind.speed} m/s";

                Console.WriteLine("Temperature " + _viewModel.Temperature);
                Console.WriteLine("Description " + _viewModel.Description);
                Console.WriteLine("Humidity " + _viewModel.Humidity);
                Console.WriteLine("WindSpeed " + _viewModel.WindSpeed);
                // Trigger the UI to update
                //this.DataContext = null;
                // this.DataContext = this;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching weather data: {ex.Message}");
            }
        }
    }
}
