using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsommiTounsi.Models
{
    public class Category
    {
        public int IdCategory { get; set; }
        public string Name { get; set; }

        public virtual List<Product>Products{ get; set; }

        public Category ()
        {

        }
        public Category(int idCategory, string name, List<Product> products)
        {
            IdCategory = idCategory;
            Name = name;
            Products = products;
        }
    }
}