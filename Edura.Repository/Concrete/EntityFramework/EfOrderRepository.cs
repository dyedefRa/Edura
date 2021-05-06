using Edura.Entity.Models;
using Edura.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Edura.Repository.Concrete.EntityFramework
{
    public class EfOrderRepository : IOrderRepository
    {
        private EduraContext context;

        public EfOrderRepository(EduraContext _context)
        {
            context = _context;
        }

        public void Add(Order entity)
        {
            context.Orders.Add(entity);
        }

        public void Delete(Order entity)
        {
            context.Orders.Remove(entity);
        }

        public void Edit(Order entity)
        {
            context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        public IQueryable<Order> Find(Expression<Func<Order, bool>> predicate)
        {
            return context.Orders.Where(predicate);
        }

        public Order Get(int id)
        {
            return context.Orders.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<Order> GetAll()
        {
            return context.Orders;
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
