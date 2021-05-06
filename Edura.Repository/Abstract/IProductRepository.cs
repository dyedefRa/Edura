using Edura.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Edura.Repository.Abstract
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        List<Product> GetLast5Products();
    }
}
