﻿using Microsoft.AspNetCore.Mvc;
using PatikaSurvivor.Data;
using PatikaSurvivor.Models;

namespace PatikaSurvivor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetitorController : ControllerBase
    {
        private readonly PatikaDbContext _context;

        public CompetitorController(PatikaDbContext context)
        {
            _context = context;
        }

        // GET: /api/Competitor
        [HttpGet]
        public IActionResult GetAllCompetitors()
        {
            var competitors = _context.Competitors.ToList();
            return Ok(competitors);
        }

        // GET: /api/Competitor/{id}
        [HttpGet("{id}")]
        public IActionResult GetCompetitorById(int id)
        {
            var competitor = _context.Competitors.Find(id);
            if (competitor == null) return NotFound();
            return Ok(competitor);
        }

        // GET: /api/Competitor/categories/{categoryId}
        [HttpGet("categories/{categoryId}")]
        public IActionResult GetCompetitorsByCategory(int categoryId)
        {
            var competitors = _context.Competitors.Where(c => c.CategoryId == categoryId).ToList();
            return Ok(competitors);
        }

        // POST: /api/Competitor
        [HttpPost]
        public IActionResult CreateCompetitor([FromBody] Competitor competitor)
        {
            _context.Competitors.Add(competitor);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetCompetitorById), new { id = competitor.Id }, competitor);
        }

        // PUT: /api/Competitor/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateCompetitor(int id, [FromBody] Competitor competitor)
        {
            var value = _context.Competitors.Find(id);
            if (value == null) return NotFound();

            value.FirstName = competitor.FirstName;
            value.LastName = competitor.LastName;
            value.CategoryId = competitor.CategoryId;
            value.ModifiedDate = DateTime.Now;

            _context.SaveChanges();
            return NoContent();
        }

        // DELETE: /api/Competitor/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteCompetitor(int id)
        {
            var competitor = _context.Competitors.Find(id);
            if (competitor == null) return NotFound();

            _context.Competitors.Remove(competitor);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
