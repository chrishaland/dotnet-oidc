using System;

namespace Host
{
    public class WeatherForecastRequest
    {

    }

    public class WeatherForecastResponse
    {
        public WeatherForecast[]? WeatherForecasts { get; set; }
    }

    public class WeatherForecast
    {
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
        public string? Summary { get; set; }
    }
}