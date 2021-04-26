using Edura.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Edura.Repository.Abstract
{
   public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
    }
}
