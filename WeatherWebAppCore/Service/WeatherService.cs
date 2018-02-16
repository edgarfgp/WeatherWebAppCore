using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherWebAppCore.Constants;
using WeatherWebAppCore.IService;
using WeatherWebAppCore.Models;

namespace WeatherWebAppCore.Service
{
    public class WeatherService : IWeatherService
    {
        private ApiService _apiService;

        public WeatherService()
        {
            _apiService = new ApiService();
        }

        async Task<City> IWeatherService.GetCities()
        {
            try
            {

                return await _apiService.GetApi<City>(ApiUris.Cities_GET);
            }
            catch (Exception cex)
            {

                throw cex;
            }

        }

        async Task<Day> IWeatherService.GetDaysForCity(string cityName)
        {
            try
            {

               return  await _apiService.GetApi<Day>(ApiUris.DaysForCity_GET, cityName);
            }
            catch (Exception cex)
            {

                throw cex;
            }
        }

     
    }
}
