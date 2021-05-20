using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Edura.Entity.Models
{
    public class ProductDetails
    {
        public int Id { get; set; }
        public string Details { get; set; }
        public string Value { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
