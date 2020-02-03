using FreakyFashion1.Data;
using FreakyFashion1.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace FreakyFashion1

{
    public class ProductModel : PageModel
    {

        private ApplicationDbContext context;

        public Product Product { get; set; }

        public ProductModel(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult OnGet(int id)
        {
            Product = context.Product
                .Include(x => x.Category)
                .FirstOrDefault(x => x.Id == id);

            if (Product == null)
            {
                return NotFound(); // HTTP 404
            }

            return Page();
        }
    }
}