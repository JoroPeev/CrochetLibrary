using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class MailController : ControllerBase
{
    private readonly IEmailService emailService;

    public MailController(IEmailService emailService)
    {
        this.emailService = emailService;
    }

    [HttpPost("Broadcast")]
    public async Task<IActionResult> BroadcastEmail([FromQuery] string subject, [FromQuery] string body)
    {
        try
        {
            await emailService.SendMailToAllRequests(subject, body);
            return Ok("Emails sent to all requesters.");
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = ex.Message });
        }
    }
}
