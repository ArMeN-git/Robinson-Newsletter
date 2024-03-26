using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace RobinsonNewsletter.Core.Services.Email;

internal class EmailService(IOptionsMonitor<EmailSettings> emailOptionsMonitor, ISendGridClient sendGridClient) : IEmailService
{
    public async Task SendMailFromTemplateAsync<T>(T model,List<string> emails,CancellationToken cancellationToken = default)
    {
        var emailSettings = emailOptionsMonitor.CurrentValue;
        var msg = MailHelper.CreateSingleTemplateEmailToMultipleRecipients(new EmailAddress(emailSettings.SenderEmail, emailSettings.SenderEmail),
                                                                           emails.Select(e => new EmailAddress(e)).ToList(),
                                                                           emailSettings.TemplateId,
                                                                           model);


        var response = await sendGridClient.SendEmailAsync(msg, cancellationToken);
        if (!response.IsSuccessStatusCode)
        {
            throw new Exception();
        }
    }
}