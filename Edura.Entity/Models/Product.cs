﻿using System;
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
        public bool isHome { get; set; }
        public bool isFeatured { get; set; }

        public List<Category> Categories { get; set; }
    }
}
