using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherWebAppCore.IService;
using WeatherWebAppCore.Models;

namespace WeatherWebAppCore.Controllers
{
    public class ApiController : Controller
    {
        private IWeatherService weatherService;

        public ApiController(IWeatherService weatherService)
        {
            this.weatherService = weatherService;
        }

        public IActionResult Index()

        {
            ViewBag.Title = "Api";
            return View();
        }

        [HttpPost()]
        public IActionResult Index(CityDto cityDto)
        {

            if (ModelState.IsValid)
            {
                weatherService.CreateCity(cityDto);
                return RedirectToAction("Index", "Home");

            }
            else
            {
                return View(cityDto);

            }



        }

    }
}
