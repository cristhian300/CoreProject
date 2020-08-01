﻿using Core.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Core.Data.Datos.Category
{
   public class CategoryComand
    {

        private CoreContext _CoreContext;

        public CategoryComand(CoreContext CoreContext)
        {
            _CoreContext = CoreContext;
        }

        public IQueryable ListCategory(int idCategory) {

            var lstCategory = (from ca in _CoreContext.Categories where ca.CategoryId == idCategory
                                select new {
                                        ca.CategoryId,
                                        ca.Description
                                       });
            return lstCategory;
        }

    }
}
