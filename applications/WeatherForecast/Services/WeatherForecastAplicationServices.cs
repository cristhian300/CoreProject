﻿using contracts.WeatherForecast.Services;
using Core.Data.Contracts.WeatherForecast.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using transport.WeatherForecast.Response;

namespace applications.WeatherForecast.Services
{
    public class WeatherForecastAplicationServices : IWeatherForecastAplicationServices
    {

        private IWeatherForecastDataServices _IWeatherForecastDataServices;

        public WeatherForecastAplicationServices(IWeatherForecastDataServices IWeatherForecastDataServices)
        {
            _IWeatherForecastDataServices = IWeatherForecastDataServices;
        }
        public Task<ListadoCategoriaResponse> ListCategory(int? idCategory)
        {
            return _IWeatherForecastDataServices.ListCategory(idCategory);
        }
    }
}
