using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreakyFashion1.Entities
{
    public class CategoryProduct
    {

        public CategoryProduct(string name, string description, int price, Uri imageUrl)
        {
            Name = name;
            Description = description;
            Price = price;
            ImageUrl = imageUrl;
        }

        public CategoryProduct(int id, string name, string description, int price, Uri imageUrl)
            : this(name, description, price, imageUrl)
        {
            Id = id;
        }

        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public int Price { get; protected set; }
        public Uri ImageUrl { get; protected set; }
    }
}



