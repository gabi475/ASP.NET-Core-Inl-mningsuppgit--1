using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreakyFashion1.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace FreakyFashion1
{
    public class CategoryModel : PageModel
    {

        public IEnumerable<Product> Products{ get; set; } = new List<Product>();

        public void OnGet()
        {
            var serializedBasket = HttpContext.Session.GetString("Basket");

            if (!string.IsNullOrEmpty(serializedBasket))
            {
                Products = JsonConvert.DeserializeObject<List<Product>>(serializedBasket);
            }

        }
    }
}