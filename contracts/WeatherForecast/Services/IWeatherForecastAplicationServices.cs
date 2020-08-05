using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using transport.WeatherForecast.Response;

namespace contracts.WeatherForecast.Services
{
   public interface IWeatherForecastAplicationServices
    {

        Task<ListadoCategoriaResponse> ListCategory(int? idCategory);

    }
}
