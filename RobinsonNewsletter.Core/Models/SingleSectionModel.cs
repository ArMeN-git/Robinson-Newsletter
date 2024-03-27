using RobinsonNewsletter.Core.Constants;
using System.ComponentModel.DataAnnotations;

namespace RobinsonNewsletter.Core.Models;

public class SingleSectionModel
{
    [Required(ErrorMessage = ErrorMessages.RequiredMessage)]
    [RegularExpression("^((https?)(:\\/\\/))?(?:www\\.)?[-a-zA-Z0-9@:%._\\+~#=]{1,256}\\.[a-zA-Z0-9()]{1,6}\\b(?:[-a-zA-Z0-9()@:%_\\+.~#?&\\/=]*)$", ErrorMessage = ErrorMessages.InvalidUrlMessage)]
    public string ImageBase64 { get; set; }

    [Required(ErrorMessage = ErrorMessages.RequiredMessage)]
    public string Title { get; set; }

    [Required(ErrorMessage = ErrorMessages.RequiredMessage)]
    public string Text { get; set; }

    [Required(ErrorMessage = ErrorMessages.RequiredMessage)]
    [MaxLength(20, ErrorMessage = "Max length of characters exceeded.")]
    public string ButtonText { get; set; }

    [Required(ErrorMessage = ErrorMessages.RequiredMessage)]
    [RegularExpression("^((https?)(:\\/\\/))?(?:www\\.)?[-a-zA-Z0-9@:%._\\+~#=]{1,256}\\.[a-zA-Z0-9()]{1,6}\\b(?:[-a-zA-Z0-9()@:%_\\+.~#?&\\/=]*)$", ErrorMessage = ErrorMessages.InvalidUrlMessage)]
    public string ButtonUrl { get; set; }

    [Required(ErrorMessage = ErrorMessages.RequiredMessage)]
    public bool ButtonDisplay { get; set; }

    public bool IsSaved { get; set; }
}