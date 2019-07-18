using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BasketballTracking;
using BasketballTracking.Models;

namespace BasketballTracking.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConferencesController : ControllerBase
    {
        private readonly SiteContext _context;

        public ConferencesController(SiteContext context)
        {
            _context = context;
        }

        // GET: api/Conferences
        [HttpGet]
        public IEnumerable<Conference> GetConferences()
        {
            return _context.Conferences;
        }

        // GET: api/Conferences/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetConference([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var conference = await _context.Conferences.FindAsync(id);

            if (conference == null)
            {
                return NotFound();
            }

            return Ok(conference);
        }

        // PUT: api/Conferences/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConference([FromRoute] int id, [FromBody] Conference conference)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != conference.ConferenceID)
            {
                return BadRequest();
            }

            _context.Entry(conference).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConferenceExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Conferences
        [HttpPost]
        public async Task<IActionResult> PostConference([FromBody] Conference conference)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Conferences.Add(conference);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetConference", new { id = conference.ConferenceID }, conference);
        }

        // DELETE: api/Conferences/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConference([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var conference = await _context.Conferences.FindAsync(id);
            if (conference == null)
            {
                return NotFound();
            }

            _context.Conferences.Remove(conference);
            await _context.SaveChangesAsync();

            return Ok(conference);
        }

        private bool ConferenceExists(int id)
        {
            return _context.Conferences.Any(e => e.ConferenceID == id);
        }
    }
}