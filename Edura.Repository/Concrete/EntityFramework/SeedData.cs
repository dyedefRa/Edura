using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Edura.Entity.Models;

namespace Edura.Repository.Concrete.EntityFramework
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            var context = app.ApplicationServices.GetRequiredService<EduraContext>();

            context.Database.EnsureCreated();
            if (!context.Products.Any())
            {
           

                var categories = new[]
                {
                    new Category(){ Name="Electronics"},
                     new Category(){ Name="Accessories"},
                      new Category(){ Name="Furniture"}
                };

                context.Categories.AddRange(categories);

                var product = new[]
           {
                    new Product(){ Name="Camera", Price=1000,Categories=new List<Category>(){categories[0],categories[1]} },
                     new Product(){ Name="Phone", Price=3000,Categories=new List<Category>(){categories[1],categories[2]} },
                      new Product(){ Name="HeadPhone", Price=300,Categories = new List<Category>() { categories[0], categories[1] } },
                       new Product(){ Name="Sofa", Price=500,Categories = new List<Category>() { categories[1], categories[2] } }
                };

                context.Products.AddRange(product);

                context.SaveChanges();
            }
        }
    }
}
