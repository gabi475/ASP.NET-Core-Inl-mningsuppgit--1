using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreakyFashion1.Entities
{
    public class Product
    {

        public Product(int id, string name, int price, Uri imageUrl)
              : this(name,  price, imageUrl)
        {
            Id = id;
        }

        public Product(string name, int price,  Uri imageUrl)
        {
            Name = name;
            Price = price;
            ImageUrl = imageUrl;
            
            
            
        }

        public int Id { get; protected set; }
        public string Name { get; protected set; }

        




        public int Price { get; protected set; }
        public Uri ImageUrl { get; protected set; }

        public List<ProductCategory> ProductCategories { get; set; }
    }
}





