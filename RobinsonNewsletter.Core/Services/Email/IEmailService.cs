namespace RobinsonNewsletter.Core.Services.Email;

public interface IEmailService
{
    Task SendMailFromTemplateAsync<T>(T model, List<string> emails, CancellationToken cancellationToken = default);
}