using RobinsonNewsletter.Core.Constants;
using System.ComponentModel.DataAnnotations;

namespace RobinsonNewsletter.Core.Models;

public class NewsletterModel
{
    [Required(ErrorMessage = ErrorMessages.RequiredMessage)]
    [Range(1, int.MaxValue, ErrorMessage = "Please enter a positive number.")]
    public int RefNumber { get; set; } = 1;

    [Required(ErrorMessage = ErrorMessages.RequiredMessage)]
    public string FilePlaceHolder { get; set; }

    public List<SingleRubriqueModel> Rubriques { get; set; }

    [Required(ErrorMessage = ErrorMessages.RequiredMessage)]
    public string Subject { get; set; }
}