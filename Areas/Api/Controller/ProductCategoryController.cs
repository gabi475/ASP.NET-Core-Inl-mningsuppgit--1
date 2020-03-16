using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

using FreakyFashion1.Data;
using FreakyFashion1.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        [HttpPut("{id}")]
        public ActionResult Replace(int id, Product prod)
        {
            if (id != prod.Id)
            {
                return BadRequest(new { reason = "Product id does not match" }); // 400 Bad Request
            }

            context.Entry(prod).State = EntityState.Modified;

            try
            {
                context.SaveChanges();
            }
            catch
            {
                if (!context.Product.Any(x => x.Id == id))
                {
                    return NotFound(); // 404 Not Found
                }
                else
                {
                    throw;
                }
            }

            return NoContent(); // 204 No Content
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)

        {

            var product = context.Product.FirstOrDefault(x => x.Id == id);


            if (product == null)
            {
                return NotFound(); // 404 Not Found
            }

            context.Product.Remove(product);

            context.SaveChanges();

            return NoContent(); // 204 No Content


        }





        //  [HttpDelete("{id}")]
        //  public ActionResult Delete(int id)
        //  {
        //    using (var product = new HttpClient())
        //   {
        //       product.BaseAddress = new Uri("https://localhost:44343/api/productcategory");

        //      var deleteTask = product.DeleteAsync("product/" + id.ToString());
        //     deleteTask.Wait();

        //    var result = deleteTask.Result;
        //   if(result.IsSuccessStatusCode)
        //   {
        //      return RedirectToAction("Index");

    }

}
