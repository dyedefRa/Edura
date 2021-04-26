using Edura.Entity.Models;
using Edura.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Edura.Repository.Concrete.EntityFramework
{
    public class EfProductRepository : IProductRepository
    {
        private EduraContext _ctx;

        public EfProductRepository(EduraContext ctx)
        {
            _ctx = ctx;
        }
        public IQueryable<Product> Products => _ctx.Products;
    }
}
