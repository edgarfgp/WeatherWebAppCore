using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherWebAppCore.Models;

namespace WeatherWebAppCore.IService
{
    public interface IWeatherService
    {
        Task<List<City>> GetCities();
        void CreateCity(CityDto cityDto);
        Task<City> GetCityById(Guid id);
    }
}
