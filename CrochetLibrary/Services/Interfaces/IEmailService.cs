public interface IEmailService
{
    Task SendMailToAllRequests(string subject, string body);
}
