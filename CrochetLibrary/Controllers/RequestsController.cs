using CrochetLibrary.Data;
using CrochetLibrary.Models;
using Microsoft.AspNetCore.Mvc;

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
}
