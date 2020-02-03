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

namespace FreakyFashion1.Pages
{
    public class IndexModel : PageModel
    {

        private readonly ILogger<IndexModel> logger;
        private readonly ApplicationDbContext context;

        public IList<Product> ProductList = new List<Product>();

        public IndexModel(ApplicationDbContext context, ILogger<IndexModel> logger)
        {
            this.logger = logger;
            this.context = context;
        }

        // HTTP GET /
        // HTTP GET /index
        public void OnGet()
        {
            ProductList = context.Product
                .Include(x => x.Category)
                .ToList();
        }
    }
}




