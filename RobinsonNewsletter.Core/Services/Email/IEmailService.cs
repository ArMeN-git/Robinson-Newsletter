namespace RobinsonNewsletter.Core.Services.Email;

public interface IEmailService
{
    Task SendMailFromTemplateAsync<T>(T model, CancellationToken cancellationToken = default);
}