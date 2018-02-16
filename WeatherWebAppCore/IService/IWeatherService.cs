using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherWebAppCore.Models;

namespace WeatherWebAppCore.IService
{
   public  interface IWeatherService
    {
        Task<City> GetCities();
        Task<Day> GetDaysForCity(string cityName);



    }
}
