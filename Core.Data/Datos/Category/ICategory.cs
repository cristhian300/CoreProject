using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using transport.WeatherForecast.Response;

namespace Core.Data.Datos.Category
{
    public interface ICategory
    {

        ListadoCategoriaResponse ListCategory(int? idCategory);
    }
}
