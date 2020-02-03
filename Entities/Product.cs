using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreakyFashion1.Entities
{
    public class Product
    {

        public Product(int id, int categoryId, int categoryproductId, int price)
                       : this(categoryId, categoryproductId, price)
        {
            Id = id;
        }

        public Product(int categoryId, int categoryproductId, int price)
        {
            CategoryId = categoryId;
            CategoryProductId = categoryproductId;
            Price = price;

        }

        public Product(Category category, CategoryProduct categoryproduct, int price)
        {
            Category = category;
            CategoryProduct =categoryproduct;
            Price = price;

        }

        public Product()
        {

        }

        public int Id { get; protected set; }
        public Category Category { get; protected set; }
        public int CategoryId { get; protected set; }
        public CategoryProduct CategoryProduct { get; protected set; }
        public int CategoryProductId { get; protected set; }
        public int Price { get; protected set; }

    }
}






