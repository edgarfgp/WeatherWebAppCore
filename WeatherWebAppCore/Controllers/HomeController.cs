using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherWebAppCore.Constants;
using WeatherWebAppCore.Extensions;
using WeatherWebAppCore.IService;
using WeatherWebAppCore.Models;
using WeatherWebAppCore.ViewModels;

namespace WeatherWebAppCore.Controllers
{
    public class HomeController : Controller
    {
        private IWeatherService weatherService;

        public HomeController(IWeatherService weatherService)
        {
            this.weatherService = weatherService;


        }

        public async Task<IActionResult> Index()
        {
           
            ViewBag.Title = "Home";

            HomeViewModel homeViewModel = new HomeViewModel();

            var CitiesFromApi = await weatherService.GetCities();

            homeViewModel = new HomeViewModel()
            {
                
                Title = "Cities",
                Cities = CitiesFromApi

            };

            return View(homeViewModel);
        }

        

        
    }
}
