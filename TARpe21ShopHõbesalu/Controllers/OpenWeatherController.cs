using Microsoft.AspNetCore.Mvc;
using TARpe21ShopHõbesalu.Core.Dto.WeatherDtos;
using TARpe21ShopHõbesalu.Core.ServiceInterface;
using TARpe21ShopHõbesalu.Models.OpenWeather;

namespace TARpe21ShopHõbesalu.Controllers
{
    public class OpenWeatherController : Controller
    {
        private readonly IWeatherForecastsServices _openWeatherServices;
        public OpenWeatherController(IWeatherForecastsServices weatherForecastServices)
        {
            _openWeatherServices = weatherForecastServices;
        }

        public IActionResult Index()
        {
            OpenWeatherViewModel vm = new OpenWeatherViewModel();
            return View(vm);
        }

        [HttpPost]
        public IActionResult ShowWeather()
        {
            string city = Request.Form["City"];

            if (!string.IsNullOrEmpty(city))
            {
                OpenWeatherResultDto dto = new();
                dto.City = city;
                _openWeatherServices.OpenWeatherDetail(dto);

                OpenWeatherViewModel vm = new()
                {
                    City = dto.City,

                    Temperature = dto.Temperature,
                    AirPressure = dto.AirPressure,
                    AirHumidity = dto.AirHumidity,
                    Main = dto.Main,

                    WindSpeed = dto.WindSpeed
                };

                return View("City", vm);
            }

            return View();
        }
    }
}