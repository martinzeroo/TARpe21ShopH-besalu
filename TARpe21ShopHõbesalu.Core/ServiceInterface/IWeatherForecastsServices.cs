﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TARpe21ShopHõbesalu.Core.Dto.WeatherDtos;

namespace TARpe21ShopHõbesalu.Core.ServiceInterface
{
    public interface IWeatherForecastsServices
    {
        public Task<WeatherResultDto> WeatherDetail(WeatherResultDto dto);
        public Task<OpenWeatherResultDto> OpenWeatherDetail(OpenWeatherResultDto dto);
    }
}
