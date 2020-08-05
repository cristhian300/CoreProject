using System;
using System.Collections.Generic;
using System.Text;
using transport.WeatherForecast.QueryEntity;

namespace transport.WeatherForecast.Response
{
   public class ListadoCategoriaResponse
    {

        public IList<ListCategoryQueryEntity> ListCategory { get; set; }
        public ListadoCategoriaResponse()
        {
            ListCategory = new List<ListCategoryQueryEntity>();
        }

    }
} 
