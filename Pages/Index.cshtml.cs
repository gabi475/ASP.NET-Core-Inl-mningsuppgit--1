using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreakyFashion1.Data;
using FreakyFashion1.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace FreakyFashion1
{
    public class IndexModel : PageModel
    {

        private readonly ILogger<IndexModel> logger;
        private readonly ApplicationDbContext context;

        public IList<Product> ProductCategoryList = new List<Product>();

        
         //public IList<ProductCategory> ProductCategoryList = new List<ProductCategory>();

        public IList<Category> CategoryList { get; set; }

        public IndexModel(ApplicationDbContext context, ILogger<IndexModel> logger)
        {
            this.logger = logger;
            this.context = context;
        }

        // HTTP GET /
        // HTTP GET /index
        public void OnGet()
        {
            ProductCategoryList = context.Product
          .ToList();

           CategoryList = context.Category.ToList();

          // ProductCategoryList = context.ProductCategory
           //  .Include(x => x.Category)
            //  .ToList();

        }
    }
}



