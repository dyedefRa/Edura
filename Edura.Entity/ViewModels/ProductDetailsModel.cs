using Edura.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edura.WebUI.Models
{
    public class ProductDetailsModel
    {
        public Product  Product { get; set; }
        public List<Image> Images { get; set; }
        public List<ProductDetails> ProductDetails { get; set; }
        public List<Category> Categories { get; set; }
    }
}
