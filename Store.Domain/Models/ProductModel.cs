using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain.Models
{
    public class ProductModel
    {
        public int product_id { get; set; }
        public string name { get; set; }
        public string manufacturer { get; set; }
        public int sellingPrice { get; set; }
        public int costPrice { get; set; }
        public int category_id { get; set; }
        public CategoryModel category { get; set; }
    }
}
