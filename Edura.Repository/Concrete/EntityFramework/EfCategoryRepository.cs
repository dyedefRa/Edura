using Edura.Entity.Models;
using Edura.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Edura.Repository.Concrete.EntityFramework
{
    public class EfCategoryRepository : EfGenericRepository<Category>,ICategoryRepository
    {
        public EfCategoryRepository(EduraContext context):base(context)
        {

        }

        public EduraContext eduraContext
        {
            get { return context as EduraContext; }
        }
        public Category GetByName(string categoryName)
        {
            return eduraContext
                 .Categories
                 .FirstOrDefault(x => x.Name == categoryName);
        }
    }
}
