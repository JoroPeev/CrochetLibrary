using CrochetLibrary.Data;
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
    public async Task<IActionResult> PostRequest([FromBody] CustomerRequest request)
    {
        _context.Requests.Add(request);
        await _context.SaveChangesAsync();
        return Ok();
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<CustomerRequest>>> GetRequests()
    {
        var requests = await _context.Requests.ToListAsync();
        return Ok(requests);
    }

    [HttpGet("with-toys")]
    public async Task<ActionResult<IEnumerable<CustomerRequest>>> GetRequestsWithToys()
    {
        var requests = await _context.Requests
                                     .Include(r => r.Toy)
                                     .ToListAsync();
        return Ok(requests);
    }
}
