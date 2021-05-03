using Edura.Entity.Models;
using Edura.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Edura.Repository.Concrete.EntityFramework
{
    public class EfCategoryRepository : ICategoryRepository
    {
        private EduraContext context;
        public EfCategoryRepository(EduraContext _context)
        {
            context = _context;
        }
        public void Add(Category entity)
        {
            context.Categories.Add(entity);
        }

        public void Delete(Category entity)
        {
            context.Categories.Remove(entity);
        }

        public void Edit(Category entity)
        {
            context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        public IQueryable<Category> Find(Expression<Func<Category, bool>> predicate)
        {
            return context.Categories.Where(predicate);
        }

        public Category Get(int id)
        {
            return context.Categories.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<Category> GetAll()
        {
            return context.Categories;
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
