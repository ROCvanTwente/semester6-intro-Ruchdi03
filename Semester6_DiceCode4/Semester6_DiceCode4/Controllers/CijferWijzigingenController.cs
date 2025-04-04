using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Semester6_DiceCode4.Data;
using Semester6_DiceCode4.Models; 
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semester6_DiceCode4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CijferWijzigingenController : ControllerBase
    {
        private readonly ASPEC06DBContext _context;

        public CijferWijzigingenController(ASPEC06DBContext context)
        {
            _context = context;
        }

        // GET: api/CijferWijzigingen
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CijferWijziging>>> GetCijferWijzigingen()
        {
            return await _context.CijferWijzigingen.ToListAsync();
        }

        // GET: api/CijferWijzigingen/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CijferWijziging>> GetCijferWijziging(int id)
        {
            var cijferWijziging = await _context.CijferWijzigingen.FindAsync(id);

            if (cijferWijziging == null)
            {
                return NotFound();
            }

            return cijferWijziging;
        }

        // POST: api/CijferWijzigingen
        [HttpPost]
        public async Task<ActionResult<CijferWijziging>> PostCijferWijziging(CijferWijziging cijferWijziging)
        {
            _context.CijferWijzigingen.Add(cijferWijziging);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCijferWijziging), new { id = cijferWijziging.Id }, cijferWijziging);
        }

        // PUT: api/CijferWijzigingen/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCijferWijziging(int id, CijferWijziging cijferWijziging)
        {
            if (id != cijferWijziging.Id)
            {
                return BadRequest();
            }

            _context.Entry(cijferWijziging).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CijferWijzigingExists(id))
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

        // DELETE: api/CijferWijzigingen/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCijferWijziging(int id)
        {
            var cijferWijziging = await _context.CijferWijzigingen.FindAsync(id);
            if (cijferWijziging == null)
            {
                return NotFound();
            }

            _context.CijferWijzigingen.Remove(cijferWijziging);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CijferWijzigingExists(int id)
        {
            return _context.CijferWijzigingen.Any(e => e.Id == id);
        }
    }
}
