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
    public class VillageSmartGridsController : ControllerBase
    {
        private readonly SmartgridInfoContext _context;

        public VillageSmartGridsController(SmartgridInfoContext context)
        {
            _context = context;
        }

        // GET: api/VillageSmartGrids
        [HttpGet]
        public IEnumerable<VillageSmartGrid> GetVillageSmartGrid()
        {
            return _context.VillageSmartGrid;
        }

        // GET: api/VillageSmartGrids/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetVillageSmartGrid([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var villageSmartGrid = await _context.VillageSmartGrid.FindAsync(id);

            if (villageSmartGrid == null)
            {
                return NotFound();
            }

            return Ok(villageSmartGrid);
        }

        // PUT: api/VillageSmartGrids/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVillageSmartGrid([FromRoute] long id, [FromBody] VillageSmartGrid villageSmartGrid)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != villageSmartGrid.ID)
            {
                return BadRequest();
            }

            _context.Entry(villageSmartGrid).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VillageSmartGridExists(id))
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

        // POST: api/VillageSmartGrids
        [HttpPost]
        public async Task<IActionResult> PostVillageSmartGrid([FromBody] VillageSmartGrid villageSmartGrid)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.VillageSmartGrid.Add(villageSmartGrid);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVillageSmartGrid", new { id = villageSmartGrid.ID }, villageSmartGrid);
        }

        // DELETE: api/VillageSmartGrids/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVillageSmartGrid([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var villageSmartGrid = await _context.VillageSmartGrid.FindAsync(id);
            if (villageSmartGrid == null)
            {
                return NotFound();
            }

            _context.VillageSmartGrid.Remove(villageSmartGrid);
            await _context.SaveChangesAsync();

            return Ok(villageSmartGrid);
        }

        private bool VillageSmartGridExists(long id)
        {
            return _context.VillageSmartGrid.Any(e => e.ID == id);
        }
    }
}