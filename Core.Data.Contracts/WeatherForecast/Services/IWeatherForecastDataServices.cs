using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using transport.WeatherForecast.Response;

namespace Core.Data.Contracts.WeatherForecast.Services
{
    public  interface IWeatherForecastDataServices
    {

        Task<ListadoCategoriaResponse> ListCategory(int? idCategory);
    }
}
