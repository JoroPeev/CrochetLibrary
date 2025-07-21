using Microsoft.AspNetCore.Mvc;

namespace CrochetLibrary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToysController : ControllerBase
    {
        private readonly IToyService _toyService;

        public ToysController(IToyService toyService)
        {
            _toyService = toyService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Toy>>> GetToys()
        {
            return Ok(await _toyService.GetToysAsync());
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<Toy>> GetToy([FromRoute] Guid id)
        {
            var toy = await _toyService.GetToyByIdAsync(id);
            if (toy == null)
                return NotFound();

            return Ok(toy);
        }

        [HttpPost]
        public async Task<ActionResult<Toy>> PostToy([FromBody] Toy toy)
        {
            var createdToy = await _toyService.AddToyAsync(toy);
            return CreatedAtAction(nameof(GetToy), new { id = createdToy.Id }, createdToy);
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> PutToy([FromRoute] Guid id, [FromBody] Toy toy)
        {
            var updated = await _toyService.UpdateToyAsync(id, toy);
            if (!updated)
                return NotFound();

            return NoContent();
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteToy([FromRoute] Guid id)
        {
            var deleted = await _toyService.DeleteToyAsync(id);
            if (!deleted)
                return NotFound();

            return NoContent();
        }
    }
}