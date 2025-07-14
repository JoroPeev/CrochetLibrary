using CrochetLibrary.Data;
using CrochetLibrary.DataTransferObject;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class RequestsController : ControllerBase
{
    private readonly CrochetDbContext _context;

    public RequestsController(CrochetDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> PostRequest([FromBody] CustomerRequestDTO requestDto)
    {
        var customerRequest = new CustomerRequest
        {
            ToyName = requestDto.ToyName,
            Name = requestDto.Name,
            Email = requestDto.Email,
            Message = requestDto.Message,
            DueDate = requestDto.DueDate,
            SubscribeToNewsletter = requestDto.SubscribeToNewsletter,
        };

        _context.Requests.Add(customerRequest);
        await _context.SaveChangesAsync();
        return Ok();
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<CustomerRequest>>> GetRequests()
    {
        var requests = await _context.Requests.ToListAsync();
        return Ok(requests);
    }

    [HttpGet("subscribed")]
    public async Task<ActionResult<IEnumerable<CustomerRequest>>> GetSubscribedCustomers()
    {
        var subscribedCustomers = await _context.Requests
            .Where(c => c.SubscribeToNewsletter)
            .ToListAsync();

        return Ok(subscribedCustomers);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteRequest(int id)
    {
        var request = await _context.Requests.FindAsync(id);

        if (request == null)
        {
            return NotFound();
        }

        _context.Requests.Remove(request);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}
