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
    public class ProductCategoryController : ControllerBase
    {



        private readonly ApplicationDbContext context;

        public ProductCategoryController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Product> GetAll()
        {
            var products = context.Product.ToList();

            return products;
        }

        // GET /api/product/{id}
        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id)
        {
            var product = context.Product.FirstOrDefault(x => x.Id == id);

            if (product == null)
            {
                return NotFound(); // 404 Not Found
            }

            return product; // 200 OK
        }

        [HttpPost]
        public ActionResult Created(Product product)
        {
            context.Product.Add(product);

            context.SaveChanges();

            return Created($"/api/product/{product.Id}", product); // 201 Created (Location: ...)
        }

    }
}
