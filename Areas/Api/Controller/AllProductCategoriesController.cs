using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreakyFashion1.Data;
using FreakyFashion1.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FreakyFashion1.Areas.Api.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class AllProductCategoriesController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public AllProductCategoriesController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpPost]
        public ActionResult Created(ProductCategory productCategory)
        {
            context.ProductCategory.Add(productCategory);
            context.SaveChanges();

            return Created("", productCategory);
        }
    }
}
