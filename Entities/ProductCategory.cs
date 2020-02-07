namespace FreakyFashion1.Entities
{
    public class ProductCategory
    {






        public ProductCategory( int categoryId, int productId)
        {
            
            CategoryId = categoryId;
            ProductId = productId;


        }
       
        public Category Category { get; protected set; }
        public int CategoryId { get; protected set; }
        public Product Product { get; protected set; }
        public int ProductId { get; protected set; }

        public int Id { get; protected set; }


    }
}




