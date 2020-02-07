using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreakyFashion1.Entities
{
    public class Category
    {
      


        public Category( int id, string name, string description, Uri imageUrl)
        {
            Id = id;
            Name = name;
            Description = description;
            
            ImageUrl = imageUrl;
        }

        public int Id { get; protected set; }
        public string Name { get; protected set; }

        public string Description { get; protected set; }


        
        public Uri ImageUrl { get; protected set; }

        public List<ProductCategory> ProductCategories { get; set; }
    }
}



    

