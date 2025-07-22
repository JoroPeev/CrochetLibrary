using CrochetLibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrochetLibrary.Controllers
{
    [Route("api/toys/{id:guid}/images")]
    [ApiController]
    public class ToyImagesController : ControllerBase
    {
        private readonly IToyService _toyService;

        public ToyImagesController(IToyService toyService)
        {
            _toyService = toyService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ToyImage>>> GetImages([FromRoute] Guid id)
        {
            var images = await _toyService.GetToyImagesAsync(id);
            return Ok(images ?? new List<ToyImage>());
        }

        [HttpPost]
        public async Task<IActionResult> AddImagesToToy([FromRoute] Guid id, [FromBody] List<string> imageUrls)
        {
            var result = await _toyService.AddImagesToToyAsync(id, imageUrls);
            if (!result)
                return NotFound();

            return NoContent();
        }

        [HttpPut("{imageId:guid}")]
        public async Task<IActionResult> UpdateImage([FromRoute] Guid id, [FromRoute] Guid imageId, [FromBody] ToyImageDto dto)
        {
            var result = await _toyService.UpdateImageAsync(imageId, dto.ImageUrl, dto.DisplayOrder);
            if (!result)
                return NotFound();

            return NoContent();
        }

        [HttpDelete("{imageId:guid}")]
        public async Task<IActionResult> DeleteImage([FromRoute] Guid id, [FromRoute] Guid imageId)
        {
            var result = await _toyService.DeleteImageAsync(imageId);
            if (!result)
                return NotFound();

            return NoContent();
        }
    }
}