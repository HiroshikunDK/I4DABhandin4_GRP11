using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartgridInfo.Models;

namespace SmartgridInfo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SmartmetersController : ControllerBase
    {
        private readonly SmartgridInfoContext _context;

        public SmartmetersController(SmartgridInfoContext context)
        {
            _context = context;
        }

        // GET: api/Smartmeters
        [HttpGet]
        public IEnumerable<Smartmeter> GetSmartmeter()
        {
            return _context.Smartmeter;
        }

        // GET: api/Smartmeters/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSmartmeter([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var smartmeter = await _context.Smartmeter.FindAsync(id);

            if (smartmeter == null)
            {
                return NotFound();
            }

            return Ok(smartmeter);
        }

        // PUT: api/Smartmeters/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSmartmeter([FromRoute] long id, [FromBody] Smartmeter smartmeter)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != smartmeter.ID)
            {
                return BadRequest();
            }

            _context.Entry(smartmeter).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SmartmeterExists(id))
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

        // POST: api/Smartmeters
        [HttpPost]
        public async Task<IActionResult> PostSmartmeter([FromBody] Smartmeter smartmeter)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Smartmeter.Add(smartmeter);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSmartmeter", new { id = smartmeter.ID }, smartmeter);
        }

        // DELETE: api/Smartmeters/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSmartmeter([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var smartmeter = await _context.Smartmeter.FindAsync(id);
            if (smartmeter == null)
            {
                return NotFound();
            }

            _context.Smartmeter.Remove(smartmeter);
            await _context.SaveChangesAsync();

            return Ok(smartmeter);
        }

        private bool SmartmeterExists(long id)
        {
            return _context.Smartmeter.Any(e => e.ID == id);
        }
    }
}