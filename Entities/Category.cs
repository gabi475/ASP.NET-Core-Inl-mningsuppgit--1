using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreakyFashion1.Entities
{
    public class Category
    {

        public Category()
        {

        }

        public Category( int id, string name, Uri imageUrl)
             : this(name, imageUrl)
        {
            Id = id;
        }

        public Category( string name, Uri imageUrl)
        {
            Name = name;
            UrlSlug = name.Trim().ToLower();

            ImageUrl = imageUrl;
        }

        public int Id { get;  set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public string UrlSlug { get; set; }


        
        public Uri ImageUrl { get; set; }

        public List<ProductCategory> ProductCategories { get; set; }
    }
}



    

