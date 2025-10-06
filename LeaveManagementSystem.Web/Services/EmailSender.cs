
using System.Net.Mail;

namespace LeaveManagementSystem.Web.Services
{
    public class EmailSender(IConfiguration _configuration) : IEmailSender
    {
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var formAddress = _configuration["EmailSettings:DefaultEmailAddress"];
            var smtpServer = _configuration["EmailSettings:Server"];
            var smtpPort = _configuration["EmailSettings:Port"];

            var message = new MailMessage
            {
                From = new MailAddress(formAddress),
                Subject = subject,
                Body = htmlMessage,
                IsBodyHtml = true
            };
            message.To.Add(new MailAddress(email));

            using var client = new SmtpClient(smtpServer, int.Parse(smtpPort));
            await client.SendMailAsync(message);
        }
    }
}
