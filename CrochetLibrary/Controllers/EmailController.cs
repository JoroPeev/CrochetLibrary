using CrochetLibrary.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("[controller]")]
public class MailController : Controller
{
    private readonly EmailService _emailService;
    private readonly CrochetDbContext _context;

    public MailController(EmailService emailService, CrochetDbContext context)
    {
        _emailService = emailService;
        _context = context;
    }

    [HttpPost("send-email-individual")]
    public async Task<IActionResult> SendEmailIndividual([FromBody] BulkEmailDTO emailDto)
    {
        var emails = await _context.Requests
                                   .Select(r => r.Email)
                                   .Distinct()
                                   .ToListAsync();

        if (!emails.Any())
            return NotFound("No emails found to send.");

        var emailTasks = emails.Select(email =>
            _emailService.SendEmailAsync(email, emailDto.Subject, emailDto.Message));

        await Task.WhenAll(emailTasks);

        return Ok("Individual emails sent successfully!");
    }

    [HttpPost("send-email-bcc")]
    public async Task<IActionResult> SendEmailBcc([FromBody] BulkEmailDTO emailDto)
    {
        var emails = await _context.Requests
                                   .Select(r => r.Email)
                                   .Distinct()
                                   .ToListAsync();

        if (!emails.Any())
            return NotFound("No emails found to send.");

        await _emailService.SendBulkEmailBccAsync(emails, emailDto.Subject, emailDto.Message);

        return Ok("Single email sent via BCC successfully!");
    }
}
