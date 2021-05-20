using System;
using System.Collections.Generic;
using System.Text;

namespace Edura.Entity.Models
{
   public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public bool IsApproved { get; set; }
        public bool IsHome { get; set; }
        public bool IsFeatured { get; set; }
        public string Description { get; set; }
        public string HtmlContent { get; set; }
        public DateTime AddingDate { get; set; }

        public List<Category> Categories { get; set; }
        public List<Image> Images { get; set; }
        public List<ProductDetails> ProductDetails { get; set; }
    }
}
