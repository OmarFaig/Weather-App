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
            set => SetField(ref _temperature, value);
        }

        public string? Description
        {
            get => _description;
            set => SetField(ref _description, value);
        }

        public string? Humidity
        {
            get => _humidity;
            set => SetField(ref _humidity, value);
        }

        public string? WindSpeed
        {
            get => _windSpeed;
            set => SetField(ref _windSpeed, value);
        }

        // PropertyChanged event implementation
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
