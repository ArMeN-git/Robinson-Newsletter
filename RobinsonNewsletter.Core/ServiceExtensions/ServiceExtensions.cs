using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RobinsonNewsletter.Core.Services.Email;
using SendGrid.Extensions.DependencyInjection;

namespace RobinsonNewsletter.Core.ServiceExtensions;

public static class ServiceExtensions
{
    public static void AddEmail(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSendGrid(options =>
        options.ApiKey = configuration.GetSection(nameof(EmailSettings))
            .GetValue<string>(nameof(EmailSettings.ApiKey)));

        services.Configure<EmailSettings>(configuration.GetSection(nameof(EmailSettings)));
        services.AddScoped<IEmailService, EmailService>();
    }
}
