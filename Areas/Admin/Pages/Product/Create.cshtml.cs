﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FreakyFashion1.Data;
using FreakyFashion1.Entities;
using Microsoft.EntityFrameworkCore;

namespace FreakyFashion1
{
    public class CreateModel : PageModel
    {
        private readonly FreakyFashion1.Data.ApplicationDbContext _context;

        public CreateModel(FreakyFashion1.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public  IActionResult OnGet()
        {
            Categories = new SelectList(_context.Category.Include(x => x.ProductCategories).ToList(), nameof(Category.Id), nameof(Category.Name)); 
            return Page();
        }

        [BindProperty]
        public Product Product { get; set; }
        public SelectList Categories { get; set; }
        [BindProperty]
        public int SelectedCategory { get; set; }


        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            ProductCategory prodCategory = new ProductCategory(SelectedCategory, Product.Id);
            Product.ProductCategories = new List<ProductCategory>();
            Product.ProductCategories.Add(prodCategory);
            _context.Product.Add(Product);

            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
