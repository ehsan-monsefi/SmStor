﻿using System.Collections.Generic;

namespace Domain.Entittes
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<Product> Products { get; set; }
    }
}
