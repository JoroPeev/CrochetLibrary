using CrochetLibrary.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CrochetLibrary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToysController : ControllerBase
    {
        private readonly CrochetDbContext _context;

        public ToysController(CrochetDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Toy>>> GetToys()
        {
            return await _context.Toys.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Toy>> GetToy(int id)
        {
            var toy = await _context.Toys.FindAsync(id);

            if (toy == null)
            {
                return NotFound();
            }

            return toy;
        }

        [HttpPost]
        public async Task<ActionResult<Toy>> PostToy(Toy toy)
        {
            _context.Toys.Add(toy);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetToy), new { id = toy.Id }, toy);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutToy(int id, Toy toy)
        {
            if (id != toy.Id)
            {
                return BadRequest();
            }

            _context.Entry(toy).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ToyExists(id))
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

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteToy(int id)
        {
            var toy = await _context.Toys.FindAsync(id);
            if (toy == null)
            {
                return NotFound();
            }

            _context.Toys.Remove(toy);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ToyExists(int id)
        {
            return _context.Toys.Any(e => e.Id == id);
        }
    }
}
