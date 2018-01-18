using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherWebAppCore.Constants
{
    public enum Units
    {
        Imperial,
        Metric
    }
    public enum ApiUris
    {
        WeatherByCity_GET
    }
    public class ApiConstants
    {
        public const string API_HOST = "api.openweathermap.org";

        public const string API_PROTOCOL = "http";


        public const string GetWeatherByCity = "data/2.5/weather?q=";

        public const string ApiKey = "4ac6eecbe9be59305202d72c6baa2a78";

    }
}
