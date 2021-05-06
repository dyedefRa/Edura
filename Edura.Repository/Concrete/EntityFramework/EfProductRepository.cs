using Edura.Entity.Models;
using Edura.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Edura.Repository.Concrete.EntityFramework
{
    public class EfProductRepository : IProductRepository
    {
        private EduraContext context;

        public EfProductRepository(EduraContext ctx)
        {
            context = ctx;
        }

        public void Add(Product entity)
        {
            context.Products.Add(entity);
        }

        public void Delete(Product entity)
        {
            context.Products.Remove(entity);
        }

        public void Edit(Product entity)
        {
            context.Entry<Product>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        public IQueryable<Product> Find(Expression<Func<Product, bool>> predicate)
        {
            return context.Products.Where(predicate);
        }

        public Product Get(int id)
        {
            return context.Products.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<Product> GetAll()
        {
            return context.Products;
        }

        public List<Product> GetLast5Products()
        {
            return context.Products
                .OrderByDescending(x => x.Id)
                .Take(5)
                .ToList();
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
