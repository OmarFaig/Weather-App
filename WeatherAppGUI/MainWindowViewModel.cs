using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

namespace WeatherAppGUI
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private string? _temperature;
        private string? _description;
        private string? _humidity;
        private string? _windSpeed;

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

        // PropertyChanged event implementation
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string? propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        // Sample data for testing
      //public MainWindowViewModel()
      //{
      //    Temperature = "25°C";
      //    Description = "Clear Sky";
      //    Humidity = "40%";
      //    WindSpeed = "10 km/h";
      //}
      // protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
      // {
      //     if (EqualityComparer<T>.Default.Equals(field, value)) return false;
      //     field = value;
      //     OnPropertyChanged(propertyName);
      //     return true;
      // }
    }
}
