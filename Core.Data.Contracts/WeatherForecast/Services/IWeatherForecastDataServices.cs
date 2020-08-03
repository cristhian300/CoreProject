using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Contracts.WeatherForecast.Services
{
    public  interface IWeatherForecastDataServices
    {

        Task<IQueryable> ListCategory(int idCategory);
    }
}
