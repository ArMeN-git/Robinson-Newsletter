namespace RobinsonNewsletter.Core.Services.Email;
public class EmailSettings
{
    public string ApiKey { get; set; }
    public string SenderEmail { get; set; }
    public string TemplateId { get; set; }
    public List<string> Recipients { get; set; }
}
