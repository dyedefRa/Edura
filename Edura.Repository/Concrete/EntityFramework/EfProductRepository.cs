using Edura.Entity.Models;
using Edura.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Edura.Repository.Concrete.EntityFramework
{
    public class EfProductRepository : EfGenericRepository<Product>, IProductRepository
    {
        public EfProductRepository(EduraContext context) : base(context)
        {

        }

        public EduraContext eduraContext
        {
            get { return context as EduraContext; }
        }

        public List<Product> GetLast5Products()
        {
            return eduraContext
                .Products
                .OrderByDescending(x => x.Id)
                .Take(5)
                .ToList();
        }
    }
}
