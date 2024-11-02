using Newtonsoft.Json;
using System.Net.Http;  // For HttpClient
using System.Collections.Generic;  // For List<>

namespace WeatherAppGUI
{
    public class WeatherData
    {
        public double latitude { get; set; }
        public double longitude { get; set; }
        public double generationtime_ms { get; set; }
        public int utc_offset_seconds { get; set; }
        public string timezone { get; set; }
        public string timezone_abbreviation { get; set; }
        public double elevation { get; set; }
        public CurrentUnits current_units { get; set; }
        public Current current { get; set; }
        public HourlyUnits hourly_units { get; set; }
        public Hourly hourly { get; set; }
        public DailyUnits daily_units { get; set; }
        public Daily daily { get; set; }
    }    public class Current
    {
        public string time { get; set; }
        public int interval { get; set; }
        public double temperature_2m { get; set; }
        public double apparent_temperature { get; set; }
        public int is_day { get; set; }
        public double wind_speed_10m { get; set; }
        public int wind_direction_10m { get; set; }
    }

    public class CurrentUnits
    {
        public string time { get; set; }
        public string interval { get; set; }
        public string temperature_2m { get; set; }
        public string apparent_temperature { get; set; }
        public string is_day { get; set; }
        public string wind_speed_10m { get; set; }
        public string wind_direction_10m { get; set; }
    }

    public class Daily
    {
        public List<string> time { get; set; }
        public List<string> sunrise { get; set; }
        public List<string> sunset { get; set; }
    }

    public class DailyUnits
    {
        public string time { get; set; }
        public string sunrise { get; set; }
        public string sunset { get; set; }
    }

    public class Hourly
    {
        public List<string> time { get; set; }
        public List<double> temperature_2m { get; set; }
    }

    public class HourlyUnits
    {
        public string time { get; set; }
        public string temperature_2m { get; set; }
    }



    public class Main
    {
        public double? temp { get; set; }
        public double? feels_like { get; set; }
        public double? temp_min { get; set; }
        public double? temp_max { get; set; }
        public int? pressure { get; set; }
        public int? humidity { get; set; }
        public int? sea_level { get; set; }
        public int? grnd_level { get; set; }
    }

}
