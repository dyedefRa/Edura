using Edura.Entity.Models;
using Edura.Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Edura.Repository.Abstract
{
    public interface ICategoryRepository:IGenericRepository<Category>
    {
        Category GetByName(string categoryName);
        IEnumerable<CategoryModel> GetAllWithProductCount();
    }
}
