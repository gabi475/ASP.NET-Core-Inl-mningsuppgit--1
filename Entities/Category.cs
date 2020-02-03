using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreakyFashion1.Entities
{
    public class Category
    {

        public Category(int id, string name, string description, Uri imageUrl)
        : this(name, description, imageUrl)
        {
            Id = id;
        }

        public Category(string name, string description, Uri imageUrl)
        {
            Name = name;
            Description = description;
            ImageUrl = imageUrl;
        }

        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public Uri ImageUrl { get; protected set; }
    }
}
