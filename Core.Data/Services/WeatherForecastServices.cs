using Core.Data.Contracts.WeatherForecast.Services;
using Core.Data.Datos.Category;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Data.Services
{
    public class WeatherForecastServices : IWeatherForecastDataServices
    {

        private ICategory _ICategory;

        public WeatherForecastServices(ICategory ICategory)
        {
            _ICategory = ICategory;
        }

        public Task<IQueryable> ListCategory(int idCategory)
        {
            return  Task.FromResult (_ICategory.ListCategory(idCategory));
        }
    }
}
