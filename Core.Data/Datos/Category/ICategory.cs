using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Data.Datos.Category
{
    public interface ICategory
    {

         IQueryable ListCategory(int idCategory);
    }
}
