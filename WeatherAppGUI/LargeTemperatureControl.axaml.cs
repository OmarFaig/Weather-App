using Avalonia;
using Avalonia.Controls.Primitives;

namespace WeatherAppGUI;

public class LargeTemperatureControl : TemplatedControl
{
    public static readonly StyledProperty<string> TemperatureProperty =
       AvaloniaProperty.Register<LargeTemperatureControl, string>(nameof(Temperature),"10");

    public string Temperature
    {
        get => GetValue(TemperatureProperty);
        set => SetValue(TemperatureProperty, value);
    }

}
