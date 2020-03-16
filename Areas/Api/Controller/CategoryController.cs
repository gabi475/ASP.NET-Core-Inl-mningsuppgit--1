using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreakyFashion1.Data;
using FreakyFashion1.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FreakyFashion1.Areas
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public CategoryController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Category> GetAll()
        {
            var categories = context.Category.ToList();

            return categories;
        }
        [HttpPost]
        public ActionResult Created(Category category)
        {
            context.Category.Add(category);
            context.SaveChanges();

            return Created($"/api/category/{category.Id}", category);
        }

        [HttpPut("{id}")]
        public ActionResult Replace(int id, Category category)
        {
            if (id != category.Id)
            {
                return BadRequest(new { reason = "Category id does not match" }); // 400 Bad Request
            }

            context.Entry(category).State = EntityState.Modified;

            try
            {
                context.SaveChanges();
            }
            catch
            {
                if (!context.Category.Any(x => x.Id == id))
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
            var category = context.Category.FirstOrDefault(x => x.Id == id);

            if (category== null)
            {
                return NotFound(); // 404 Not Found
            }

            context.Category.Remove(category);

            context.SaveChanges();

            return NoContent(); // 204 No Content
        }
    }
}



