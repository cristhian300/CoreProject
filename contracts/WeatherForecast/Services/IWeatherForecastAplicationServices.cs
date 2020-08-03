using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contracts.WeatherForecast.Services
{
   public interface IWeatherForecastAplicationServices
    {

        Task<IQueryable> ListCategory(int idCategory);

    }
}
