using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherWebAppCore.Model;

namespace WeatherWebAppCore.IService
{
   public  interface IWeatherService
    {
        Task<WeatherObject> GetWeatherByLocation(string city);
    }
}
