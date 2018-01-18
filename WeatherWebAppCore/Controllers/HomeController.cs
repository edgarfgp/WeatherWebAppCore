using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherWebAppCore.Extensions;
using WeatherWebAppCore.IService;

namespace WeatherWebAppCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWeatherService weatherService;
        public HomeController(IWeatherService weatherService)
        {
            this.weatherService = weatherService;
        }

        public   ViewResult Index()
        {
            ViewBag.Title = "Home View Page";

            var weatherTask = weatherService.GetWeatherByLocation("Madrid");
            
           Task.WhenAll(weatherTask);

            var currentWeather = weatherTask.Result;

            return  View( currentWeather);
        }
    }
}
