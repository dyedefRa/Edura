using System;
using System.Collections.Generic;
using System.Text;

namespace Edura.Entity.Models
{
   public class Order
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public double Total { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
