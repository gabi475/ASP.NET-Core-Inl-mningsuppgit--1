using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreakyFashion1.Entities
{
    public class ProductCategory
    {

        public ProductCategory()
        {

        }
        public ProductCategory( int categoryId, int productId)
        {
            
            CategoryId = categoryId;
            ProductId = productId;

        }
       
        public Category Category { get; set ; }
        public int CategoryId { get;  set; }
        public Product Product { get;  set; }
        public int ProductId { get;  set; }

        public int Id { get;  set; }


    }
}




