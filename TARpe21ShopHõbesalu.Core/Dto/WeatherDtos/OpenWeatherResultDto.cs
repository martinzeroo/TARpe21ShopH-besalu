using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARpe21ShopHõbesalu.Core.Dto.WeatherDtos
{
    public class OpenWeatherResultDto
    {
        public string City { get; set; }
        public string Name { get; set; }
        public double Temperature { get; set; }
        public double Feelslike { get; set; }
        public int AirPressure { get; set; }
        public int AirHumidity { get; set; }
        public string Main { get; set; }

        public double WindSpeed { get; set; }

    }

}