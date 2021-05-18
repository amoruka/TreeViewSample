﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TreeViewSample
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public Category Parent { get; set; }

        public List<Category> Subcategories { get; set; }

        public List<Product> Products { get; set; }
    }
}
