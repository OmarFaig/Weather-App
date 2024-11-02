using System.Collections.Generic;
using System.ComponentModel;

namespace WeatherAppGUI
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private string? _temperature;
        private string? _description;
        private string? _humidity;
        private string? _windSpeed;
        private List<DailyWeather> _dailyWeather;

        public string? Temperature
        {
            get => _temperature;
            set
            {
                _temperature = value;
                OnPropertyChanged(nameof(Temperature));
            }
        }

        public string? Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }

        public string? Humidity
        {
            get => _humidity;
            set
            {
                _humidity = value;
                OnPropertyChanged(nameof(Humidity));
            }
        }

        public string? WindSpeed
        {
            get => _windSpeed;
            set
            {
                _windSpeed = value;
                OnPropertyChanged(nameof(WindSpeed));
            }
        }

        public List<DailyWeather> DailyWeather
        {
            get => _dailyWeather;
            set
            {
                _dailyWeather = value;
                OnPropertyChanged(nameof(DailyWeather));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class DailyWeather
    {
        public string Day { get; set; }
        public string Temperature { get; set; }
        public string Sunrise { get; set; }
        public string Sunset { get; set; }
    }
}