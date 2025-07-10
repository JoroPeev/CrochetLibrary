using CrochetLibrary.Data;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Net.Mail;

public class EmailService : IEmailService
{
    private readonly IConfiguration configuration;
    private readonly CrochetDbContext dbContext;

    public EmailService(IConfiguration configuration, CrochetDbContext dbContext)
    {
        this.configuration = configuration;
        this.dbContext = dbContext;
    }

    public async Task SendMailToAllRequests(string subject, string body)
    {
        var email = configuration.GetValue<string>("EMAIL_CONFIGURATION:EMAIL");
        var pass = configuration.GetValue<string>("EMAIL_CONFIGURATION:PASSWORD");
        var host = configuration.GetValue<string>("EMAIL_CONFIGURATION:HOST");
        var port = configuration.GetValue<int>("EMAIL_CONFIGURATION:PORT");

        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(host) || port == 0)
            throw new Exception("SMTP configuration missing or invalid.");

        var smtpClient = new SmtpClient(host, port)
        {
            EnableSsl = true,
            UseDefaultCredentials = false,
            Credentials = new NetworkCredential(email, pass)
        };

        var emails = await dbContext.Requests
                         .Select(r => r.Email)
                         .Distinct()
                         .ToListAsync();

        if (!emails.Any())
            throw new Exception("No email addresses found.");

        foreach (var recipient in emails)
        {
            var message = new MailMessage(email, recipient, subject, body);
            await smtpClient.SendMailAsync(message);
        }
    }
}
