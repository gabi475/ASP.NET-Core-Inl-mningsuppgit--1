using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreakyFashion1.Data;
using FreakyFashion1.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FreakyFashion1.Entities.Pages

{
    public class SearchModel : PageModel
    {

        public string SearchString { get; set; }

      //  public Product Product { get; set; }//

        public List<Product> Products { get; set; }

        public ApplicationDbContext Context { get; set; }

        public SearchModel(ApplicationDbContext context)
        {
            this.Context = context;
        }
        public void OnGet(string searchString)
        {
            SearchString = searchString;


            Products = Context.Product.Where(x => x.Name.Contains(searchString)).ToList();
        }
    }
}


   

        