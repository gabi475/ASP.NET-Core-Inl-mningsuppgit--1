using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FreakyFashion1.Data;
using FreakyFashion1.Entities;

namespace FreakyFashion1
{
    public class IndexModel : PageModel
    {
        private readonly FreakyFashion1.Data.ApplicationDbContext _context;

        public IndexModel(FreakyFashion1.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Product.Include(x=> x.ProductCategories).ThenInclude(x=> x.Category).ToListAsync();
        }
    }
}
