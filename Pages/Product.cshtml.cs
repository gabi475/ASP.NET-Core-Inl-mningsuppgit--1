using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreakyFashion1.Data;
using FreakyFashion1.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace FreakyFashion1.Entities
{


    public class ProductModel : PageModel
    {
        public Product Products { get; set; }

        private ApplicationDbContext _context { get; set; }

        public ProductModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet(string urlSlug)
        {
            Products = _context.Product.FirstOrDefault(x => x.UrlSlug == urlSlug);

            if(Products == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }
    }
}