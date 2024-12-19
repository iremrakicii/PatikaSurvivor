﻿using Microsoft.AspNetCore.Mvc;
using PatikaSurvivor.Data;
using PatikaSurvivor.Models;

namespace PatikaSurvivor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly PatikaDbContext _context;

        public CategoryController(PatikaDbContext context)
        {
            _context = context;
        }

        // GET: /api/Category
        [HttpGet]
        public IActionResult GetAllCategories()
        {
            var categories = _context.Categories.ToList();
            return Ok(categories);
        }

        // GET: /api/Category/{id}
        [HttpGet("{id}")]
        public IActionResult GetCategoryById(int id)
        {
            var category = _context.Categories.Find(id);
            if (category == null) return NotFound();
            return Ok(category);
        }

        // POST: /api/Category
        [HttpPost]
        public IActionResult CreateCategory([FromBody] Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetCategoryById), new { id = category.Id }, category);
        }

        // PUT: /api/Category/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateCategory(int id, [FromBody] Category category)
        {
            var value = _context.Categories.Find(id);
            if (value == null) return NotFound();

            value.Name = category.Name;
            value.ModifiedDate = DateTime.Now;

            _context.SaveChanges();
            return NoContent();
        }

        // DELETE: /api/Category/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            var category = _context.Categories.Find(id);
            if (category == null) return NotFound();

            _context.Categories.Remove(category);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
