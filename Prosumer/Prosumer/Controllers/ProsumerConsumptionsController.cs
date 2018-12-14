using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProsumerInfo.Models;

namespace ProsumerInfo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProsumerConsumptionsController : ControllerBase
    {
        private readonly ProsumerInfoContext _context;

        public ProsumerConsumptionsController(ProsumerInfoContext context)
        {
            _context = context;
        }

        // GET: api/ProsumerConsumptions
        [HttpGet]
        public IEnumerable<ProsumerConsumption> GetProsumerConsumption()
        {
            return _context.ProsumerConsumption;
        }

        // GET: api/ProsumerConsumptions/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProsumerConsumption([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var prosumerConsumption = await _context.ProsumerConsumption.FindAsync(id);

            if (prosumerConsumption == null)
            {
                return NotFound();
            }

            return Ok(prosumerConsumption);
        }

        // PUT: api/ProsumerConsumptions/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProsumerConsumption([FromRoute] long id, [FromBody] ProsumerConsumption prosumerConsumption)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != prosumerConsumption.id)
            {
                return BadRequest();
            }

            _context.Entry(prosumerConsumption).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProsumerConsumptionExists(id))
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

        // POST: api/ProsumerConsumptions
        [HttpPost]
        public async Task<IActionResult> PostProsumerConsumption([FromBody] ProsumerConsumption prosumerConsumption)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.ProsumerConsumption.Add(prosumerConsumption);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProsumerConsumption", new { id = prosumerConsumption.id }, prosumerConsumption);
        }

        // DELETE: api/ProsumerConsumptions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProsumerConsumption([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var prosumerConsumption = await _context.ProsumerConsumption.FindAsync(id);
            if (prosumerConsumption == null)
            {
                return NotFound();
            }

            _context.ProsumerConsumption.Remove(prosumerConsumption);
            await _context.SaveChangesAsync();

            return Ok(prosumerConsumption);
        }

        private bool ProsumerConsumptionExists(long id)
        {
            return _context.ProsumerConsumption.Any(e => e.id == id);
        }
    }
}