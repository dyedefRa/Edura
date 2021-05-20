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
                    new Product(){ IsHome=true,IsApproved=true,
                    Name="Camera", Price=1000,Image="product1.jpg",Categories=new List<Category>(){categories[0],categories[1]} ,Description="test 1 ttalşamshmahmah hmhmhhh",HtmlContent="gsamgamgmagm <b> gag1 </b>"},
                     new Product(){IsHome=true,IsApproved=true, Name="Phone", Price=3000,Image="product2.jpg",Categories=new List<Category>(){categories[1],categories[2]},Description="test 1 ttalşamshmahmah hmhmhhh",HtmlContent="gsamgamgmagm <b> gag2 </b>" },
                      new Product(){IsHome=true,IsApproved=true, Name="HeadPhone", Price=300,Image="product3.jpg",Categories = new List<Category>() { categories[0], categories[1] } ,Description="test 1 ttalşamshmahmah hmhmhhh",HtmlContent="gsamgamgmagm <b> gag3</b>"},
                       new Product(){IsHome=true,IsApproved=true, Name="Sofa", Price=500,Image="product4.jpg",Categories = new List<Category>() { categories[1], categories[2] },Description="test 1 ttalşamshmahmah hmhmhhh",HtmlContent="gsamgamgmagm <b> gag4 </b>" }
                };

                context.Products.AddRange(product);

                var images = new[]
                {
                    new Image(){ Name="product1.jpg",Product=product[0] },
                    new Image(){ Name="product2.jpg",Product=product[0] },
                    new Image(){ Name="product3.jpg",Product=product[0] },
                    new Image(){ Name="product4.jpg",Product=product[0] },

                    new Image(){ Name="product1.jpg",Product=product[1] },
                    new Image(){ Name="product2.jpg",Product=product[1] },
                    new Image(){ Name="product3.jpg",Product=product[1] },
                    new Image(){ Name="product4.jpg",Product=product[1] },

                    new Image(){ Name="product1.jpg",Product=product[2] },
                    new Image(){ Name="product2.jpg",Product=product[2] },
                    new Image(){ Name="product3.jpg",Product=product[2] },
                    new Image(){ Name="product4.jpg",Product=product[2] },

                    new Image(){ Name="product1.jpg",Product=product[3] },
                    new Image(){ Name="product2.jpg",Product=product[3] },
                    new Image(){ Name="product3.jpg",Product=product[3] },
                    new Image(){ Name="product4.jpg",Product=product[3] },
                };
                context.Images.AddRange(images);


            var productDetails = new[]
            {
                    new ProductDetails(){ Details="Display",Value="15.6",Product=product[0]},
                    new ProductDetails(){ Details="Process",Value="i7",Product=product[0]},
                    new ProductDetails(){ Details="rrr",Value="152.6",Product=product[0]},
                    new ProductDetails(){ Details="ag",Value="15421.6",Product=product[0]},

                    new ProductDetails(){ Details="Display",Value="15.6",Product=product[1]},
                    new ProductDetails(){ Details="asg",Value="155.6",Product=product[1]},
                    new ProductDetails(){ Details="45",Value="15526",Product=product[1]},
                    new ProductDetails(){ Details="125",Value="15.16",Product=product[1]},

                    new ProductDetails(){ Details="Display",Value="15.6",Product=product[2]},
                    new ProductDetails(){ Details="Disp2lay",Value="155.6",Product=product[2]},
                    new ProductDetails(){ Details="asg",Value="15.6",Product=product[2]},
                    new ProductDetails(){ Details="ga",Value="1a5.6",Product=product[2]},

                    new ProductDetails(){ Details="Dispglay",Value="15g6",Product=product[3]},
                    new ProductDetails(){ Details="Dispsaglay",Value="15gsa.6",Product=product[3]},
                    new ProductDetails(){ Details="Dispasglay",Value="15ga.6",Product=product[3]},
                    new ProductDetails(){ Details="Dispagay",Value="15gsa.6",Product=product[3]}
                };

            context.ProductDetails.AddRange(productDetails);
            context.SaveChanges();

            }
        }
    }
}
