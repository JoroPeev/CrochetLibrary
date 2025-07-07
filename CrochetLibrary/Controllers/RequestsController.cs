using CrochetLibrary.Data;
using CrochetLibrary.DataTransferObject;
using CrochetLibrary.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class RequestsController : ControllerBase
{
    private readonly CrochetDbContext _context;
    private readonly IEmailService _emailService;
    public RequestsController(CrochetDbContext context, IEmailService emailService)
    {
        _context = context;
        _emailService = emailService;
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
            DueDate = requestDto.DueDate
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

    [HttpPost("send-email")]
    public async Task<IActionResult> SendBulkEmail([FromBody] BulkEmailDTO emailDto)
    {
        var emails = await _context.Requests
                                   .Select(r => r.Email)
                                   .Distinct()
                                   .ToListAsync();

        if (emails == null || !emails.Any())
        {
            return NotFound("No emails found to send.");
        }

        foreach (var email in emails)
        {
            _emailService.SendEmail(email, emailDto.Subject, emailDto.Message);
        }

        return Ok("Emails sent successfully!");
    }
}
