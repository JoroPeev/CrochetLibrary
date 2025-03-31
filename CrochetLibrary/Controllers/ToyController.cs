using CrochetLibrary.Services;
using Microsoft.AspNetCore.Mvc;

namespace CrochetLibrary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToysController : ControllerBase
    {
        private readonly ToyService _toyService;

        public ToysController(ToyService toyService)
        {
            _toyService = toyService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Toy>>> GetToys()
        {
            return Ok(await _toyService.GetToysAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Toy>> GetToy(int id)
        {
            var toy = await _toyService.GetToyByIdAsync(id);
            if (toy == null)
                return NotFound();

            return Ok(toy);
        }

        [HttpPost]
        public async Task<ActionResult<Toy>> PostToy(Toy toy)
        {
            var createdToy = await _toyService.AddToyAsync(toy);
            return CreatedAtAction(nameof(GetToy), new { id = createdToy.Id }, createdToy);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutToy(int id, Toy toy)
        {
            var updated = await _toyService.UpdateToyAsync(id, toy);
            if (!updated)
                return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteToy(int id)
        {
            var deleted = await _toyService.DeleteToyAsync(id);
            if (!deleted)
                return NotFound();

            return NoContent();
        }
    }
}
