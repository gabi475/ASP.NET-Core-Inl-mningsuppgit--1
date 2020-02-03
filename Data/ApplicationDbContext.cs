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
        //public DbSet<Category> Category { get; set; }
        //public DbSet<CategoryProduct> CategoryProduct { get; set; }
               
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var categoryproducts = new List<CategoryProduct>
            {
                new CategoryProduct(1, "Sko", "Lorem ipsum dolor", 200,
                    new Uri("https://via.placeholder.com/480x360.png?text=Moonshot", UriKind.Absolute)),
                new CategoryProduct(2, "Jeans", "Lorem ipsum dolor", 2800,
                    new Uri("https://via.placeholder.com/480x360.png?text=Mars+Explorer", UriKind.Absolute)),
            };

            categoryproducts.ForEach(x => modelBuilder.Entity<CategoryProduct>().HasData(x));

            var categorys = new List<Category>
            {
                new Category(1, "Hoodie", "Lorem ipsum dolor",
                    new Uri("https://via.placeholder.com/480x360.png?text=Moon", UriKind.Absolute)),
                new Category(2, "Jacket", "Lorem ipsum dolor",
                    new Uri("https://via.placeholder.com/480x360.png?text=Mars", UriKind.Absolute)),
            };

            categorys.ForEach(x => modelBuilder.Entity<Category>().HasData(x));

            var moonshot = categoryproducts.Find(x => x.Name == "Sko");
            var marsExplorer = categoryproducts.Find(x => x.Name == "Jeans");

            var moon = categorys.Find(x => x.Name == "Hoodie");
            var mars = categorys.Find(x => x.Name == "Jacket");

            var products = new List<Product>
            {
                new Product(1, moon.Id, moonshot.Id, 500),
                new Product(2, mars.Id, marsExplorer.Id, 1800),
            };

            products.ForEach(x => modelBuilder.Entity<Product>().HasData(x));
        }
    }
}






