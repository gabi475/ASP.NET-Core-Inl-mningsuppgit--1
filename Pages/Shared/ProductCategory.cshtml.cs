﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreakyFashion1.Data;
using FreakyFashion1.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FreakyFashion1
{
    public class ProductCategoryModel : PageModel
    {

        public ApplicationDbContext context;

        public ProductCategory ProductCategory { get; set; }

        public ProductCategoryModel(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult OnGet(int id)
        {

            ProductCategory = context.ProductCategory
                .Include(x => x.Product)
                  .FirstOrDefault(x => x.Id == id);




            if (ProductCategory == null)
            {
                return NotFound(); // HTTP 404
            }

            return Page();
        }
    }
}