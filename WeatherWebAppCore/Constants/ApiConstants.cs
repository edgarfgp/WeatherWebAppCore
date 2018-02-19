using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherWebAppCore.Constants
{
    public enum ApiUris
    {
        DaysForCity_GET,
        Cities_GET

    }
    public class ApiConstants
    {
        public const string GET_CITIES = "https://weatherapicore.azurewebsites.net/api/cities?PageNumber=1&PageSize=20";
        public const string POST_CITY = "https://weatherapicore.azurewebsites.net/api/cities";



    }

    public class CacheConstants
    {
        public static readonly string Entry = "_Entry";
    }
}
