namespace RobinsonNewsletter.Core.Services.Email;
public class EmailSettings
{
    public string ApiKey { get; set; }
    public string SenderEmail { get; set; }
    public string NewsLetterTemplateID { get; set; }

    public string TwoFactorTemplateID { get; set; }

}
