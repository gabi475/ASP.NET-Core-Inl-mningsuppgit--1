using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreakyFashion1.Entities
{
    public class Product
    {
        public Product()
        {

        }

        public Product(int id, string name, string description, int price, Uri imageUrl)
              : this(name,  price,description, imageUrl)
        {
            Id = id;
        }

        public Product(string name, int price,string description,  Uri imageUrl)
        {
            Name = name;
            Price = price;
            ImageUrl = imageUrl;
            Description = description;
            
            
        }

        public int Id { get;  set; }
        public string Name { get;  set; }
        public string Description { get;  set; }
        public int Price { get;  set; }
        public Uri ImageUrl { get;  set; }

        public List<ProductCategory> ProductCategories { get; set; }
    }
}





