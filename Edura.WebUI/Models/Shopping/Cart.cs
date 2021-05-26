using Edura.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edura.WebUI.Models.Shopping
{
    public class Cart
    {
        private List<CartLine> products { get; set; } = new List<CartLine>();
        public List<CartLine> Products => products;

        public void AddProduct(Product product,int quantity)
        {
            var currentProduct = products.Where(x => x.Id == product.Id).FirstOrDefault();
            if (currentProduct==null)
            {
                var cartLine = new CartLine()
                {
                    Product = product,
                    Quantity = quantity
                };
                products.Add(cartLine);
            }
            else
                currentProduct.Quantity += quantity;             
        }
        
        public void RemoveProduct(Product product)
        {
            products.RemoveAll(x => x.Id == product.Id);
        }
        
        public double TotalPrice()
        {
            return products.Sum(x => x.Product.Price * x.Quantity);
        }

        public void ClearAll()
        {
            products.Clear();
        }
    }

    public class CartLine
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }

    }
}
