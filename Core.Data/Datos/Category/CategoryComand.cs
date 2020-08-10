using Core.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using transport.WeatherForecast.Response;
using transport.WeatherForecast.QueryEntity;

namespace Core.Data.Datos.Category
{
   public class CategoryComand : ICategory
    {

        private CoreContext _CoreContext;

        public CategoryComand(CoreContext CoreContext)
        {
            _CoreContext = CoreContext;
        }

        public ListadoCategoriaResponse ListCategory(int? idCategory) {

            var lstCategory = (from ca in _CoreContext.Categories where ca.CategoryId == idCategory
                                select new ListCategoryQueryEntity {
                                     CategoryId=   ca.CategoryId,
                                     Name=ca.Name,
                                    Description=  ca.Description
                                       }).ToList();

            return new ListadoCategoriaResponse  {
                ListCategory= lstCategory
            };
        }

    }
}
