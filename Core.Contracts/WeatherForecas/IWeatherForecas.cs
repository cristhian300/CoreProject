using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Contracts.WeatherForecas
{
   public interface IWeatherForecas
    {

        public List<Category> ListCategory { get; set; }
    }
}
