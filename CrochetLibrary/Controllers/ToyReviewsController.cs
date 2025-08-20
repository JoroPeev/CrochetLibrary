using CrochetLibrary.DataTransferObject;
using CrochetLibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrochetLibrary.Controllers
{
    [Route("api/toys/{id:guid}/reviews")]
    [ApiController]
    public class ToyReviewsController : ControllerBase
    {
        private readonly IToyService _toyService;

        public ToyReviewsController(IToyService toyService)
        {
            _toyService = toyService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Review>>> GetReviews([FromRoute] Guid id)
        {
            var reviews = await _toyService.GetToyReviewsAsync(id);
            return Ok(reviews ?? new List<Review>());
        }

        [HttpPost]
        public async Task<ActionResult<Review>> AddReviewToToy([FromRoute] Guid id, [FromBody] ReviewDto reviewDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var review = new Review
            {
                EmailAddress = reviewDto.EmailAddress,
                Name = reviewDto.Name,
                Comment = reviewDto.Comment,
                ReviewDate = reviewDto.ReviewDate,
                ToyId = id
            };

            var result = await _toyService.AddReviewToToyAsync(id, review);
            if (!result)
                return NotFound();

            return CreatedAtAction(nameof(GetReviews), new { id = id }, review);
        }


        [HttpDelete("{reviewId:guid}")]
        public async Task<IActionResult> DeleteReview([FromRoute] Guid id, [FromRoute] Guid reviewId)
        {
            var deleted = await _toyService.DeleteReviewAsync(reviewId);
            if (!deleted)
                return NotFound();

            return NoContent();
        }
    }
}