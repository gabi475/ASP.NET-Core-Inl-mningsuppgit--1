using System;
using System.Collections.Generic;
using System.Text;
using FreakyFashion1.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FreakyFashion1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

           public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProductCategory>()
       .HasKey(bc => new { bc.ProductId, bc.CategoryId });
            modelBuilder.Entity<ProductCategory>()
                .HasOne(bc => bc.Product)
                .WithMany(b => b.ProductCategories)
                .HasForeignKey(bc => bc.ProductId);
            modelBuilder.Entity<ProductCategory>()
                .HasOne(bc => bc.Category)
                .WithMany(c => c.ProductCategories)
                .HasForeignKey(bc => bc.CategoryId);

              

            var products = new List<Product>
            {
                new Product(1, "Dress", "Lo",300,
                    new Uri("https://via.placeholder.com/480x360.png?text=Dress", UriKind.Absolute)),
                new Product(2, "Jeans","xcepteur sint occaecat cupidatat non proident", 2300 ,
                    new Uri("https://via.placeholder.com/480x360.png?text=Jeans", UriKind.Absolute)),
                 new Product(3, "Sko","xcepteur sint occaecat cupidatat non proident",  200,
                    new Uri("https://via.placeholder.com/480x360.png?text=Dress", UriKind.Absolute)),
                new Product(4, "T-skirt","rem ipsum dolor sit amet", 2300 ,
                    new Uri("https://via.placeholder.com/480x360.png?text=Jeans", UriKind.Absolute)),
                 new Product(5, "Black jacket ","Neque porro quisquam",  200,
                    new Uri("https://via.placeholder.com/480x360.png?text=Dress", UriKind.Absolute)),
                new Product(6, "Jeans for kid"," Ut enim ad minima veniam", 2300 ,
                    new Uri("https://via.placeholder.com/480x360.png?text=Jeans", UriKind.Absolute)),
            };

            products.ForEach(x => modelBuilder.Entity<Product>().HasData(x));

            var categorys = new List<Category>
            {
                new Category(1, " Red Hoodie", "Lorem ipsum dolor",
                    new Uri("https://via.placeholder.com/480x360.png?text=Hoodie", UriKind.Absolute)),
                new Category(2, "  Green Jacket","Lorem ipsum dolor",
                    new Uri("https://via.placeholder.com/480x360.png?text=Jacket", UriKind.Absolute)),
                  new Category(3, "Hoodie", "Lorem ipsum dolor",
                    new Uri("https://via.placeholder.com/480x360.png?text=Hoodie", UriKind.Absolute)),
                new Category(4, "Jacket","Lorem ipsum dolor",
                    new Uri("https://via.placeholder.com/480x360.png?text=Jacket", UriKind.Absolute)),
                  new Category(5, "Hoodie", "Lorem ipsum dolor",
                    new Uri("https://via.placeholder.com/480x360.png?text=Hoodie", UriKind.Absolute)),
                new Category(6, "Pantd","Lorem ipsum dolor",
                    new Uri("https://via.placeholder.com/480x360.png?text=Jacket", UriKind.Absolute)),
            };

            categorys.ForEach(x => modelBuilder.Entity<Category>().HasData(x));

            var moonshot = products.Find(x => x.Name == "Dress");
            var marsExplorer = products.Find(x => x.Name == "Jeans");

            var moon = categorys.Find(x => x.Name == "Hoodie");
            var mars = categorys.Find(x => x.Name == "Jacket");

            var productcategorys = new List<ProductCategory>
            {
                new ProductCategory( moon.Id, moonshot.Id),
                new ProductCategory( mars.Id, marsExplorer.Id),
            };

            productcategorys.ForEach(x => modelBuilder.Entity<ProductCategory>().HasData(x));
        }
    }
}











