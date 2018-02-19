using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherWebAppCore.Extensions;
using WeatherWebAppCore.IService;
using WeatherWebAppCore.ViewModels;

namespace WeatherWebAppCore.Controllers
{
    public class HomeController : Controller
    {
        private  IWeatherService weatherService;
        public HomeController(IWeatherService weatherService)
        {
            this.weatherService = weatherService;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.Title = "Weather Console App";

            var CitiesFromApi = await weatherService.GetCities();

            var homeViewModel = new HomeViewModel()
            {
                Title = "Welcome",
                Cities = CitiesFromApi

            };
            return View(homeViewModel);
        }
    }
}
