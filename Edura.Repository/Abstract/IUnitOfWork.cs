using System;
using System.Collections.Generic;
using System.Text;

namespace Edura.Repository.Abstract
{
    public interface IUnitOfWork:IDisposable
    {
        IProductRepository Products { get; }
        ICategoryRepository Categories { get; }

        int SaveChanges();

    }
}
