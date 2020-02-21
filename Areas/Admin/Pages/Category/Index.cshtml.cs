using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FreakyFashion1.Data;
using FreakyFashion1.Entities;

namespace FreakyFashion1.Areas.Admin.Pages.Category
{
    public class IndexModel1 : PageModel
    {
        private readonly FreakyFashion1.Data.ApplicationDbContext _context;

        public IndexModel1(FreakyFashion1.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Entities.Category> Category { get;set; }

        public async Task OnGetAsync()
        {
            Category = await _context.Category
              .Include(x=>x.ProductCategories).ToListAsync();
        }
    }
}
