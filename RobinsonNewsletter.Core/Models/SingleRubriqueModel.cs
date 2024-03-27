using RobinsonNewsletter.Core.Constants;
using System.ComponentModel.DataAnnotations;

namespace RobinsonNewsletter.Core.Models;

public class SingleRubriqueModel
{
    [Required(ErrorMessage = ErrorMessages.RequiredMessage)]
    [RegularExpression("^((https?)(:\\/\\/))?(?:www\\.)?[-a-zA-Z0-9@:%._\\+~#=]{1,256}\\.[a-zA-Z0-9()]{1,6}\\b(?:[-a-zA-Z0-9()@:%_\\+.~#?&\\/=]*)$", ErrorMessage = ErrorMessages.InvalidUrlMessage)]
    public string RubriqueSourceImage { get; set; }
    public List<SingleSectionModel> Sections { get; set; }
    public bool IsSaved { get; set; }
}
