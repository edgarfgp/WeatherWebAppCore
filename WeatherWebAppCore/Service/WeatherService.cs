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
        private ApiService apiService;

        public WeatherService()
        {
           apiService = new ApiService();
        }

        public async void CreateCity(CityDto cityDto)
        {
            try
            {
              await  apiService.PostAsync<CityDto>(cityDto);
            }
            catch (Exception)
            {

                throw;
            }
        }

        async Task<List<City>> IWeatherService.GetCities()
        {
            try
            {

                return await apiService.GetApi<City>();
            }
            catch (Exception cex)
            {

                throw cex;
            }

        }

       
    }
}
