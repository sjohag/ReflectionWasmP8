using System;
using System.Collections.Generic;
using System.Text;

namespace WasmP8.Shared
{
    public interface IWeatherForecast
    {
        DateTime Date { get; set; }
        global::System.String Summary { get; set; }
        global::System.Int32 TemperatureC { get; set; }
        global::System.Int32 TemperatureF { get; }
    }

    public class WeatherForecast : IWeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }
}
