using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace RobinsonNewsletter.Core.Models;

public class NewsletterModel
{
    [Required(ErrorMessage = ErrorMessages.RequiredMessage)]
    [Range(1, int.MaxValue, ErrorMessage = "Please enter a positive number.")]
    public int RefNumber { get; set; } = 1;

    public List<SingleRubriqueModel> Rubriques { get; set; }
}

public static class ErrorMessages
{
    public const string RequiredMessage = "This field is required.";
    public const string InvalidUrlMessage = "Invalid URL format.";
}

//[Required(ErrorMessage = ErrorMessages.RequiredMessage)]
//[RegularExpression("^((https?)(:\\/\\/))?(?:www\\.)?[-a-zA-Z0-9@:%._\\+~#=]{1,256}\\.[a-zA-Z0-9()]{1,6}\\b(?:[-a-zA-Z0-9()@:%_\\+.~#?&\\/=]*)$", ErrorMessage = ErrorMessages.InvalidUrlMessage)]
//public string ImageBase64 { get; set; }

//[Required(ErrorMessage = ErrorMessages.RequiredMessage)]
//public string Title { get; set; }

//[Required(ErrorMessage = ErrorMessages.RequiredMessage)]
//public string Text { get; set; }

//[Required(ErrorMessage = ErrorMessages.RequiredMessage)]
//[MaxLength(20, ErrorMessage = "Max length of characters exceeded.")]
//public string ButtonText { get; set; }

//[Required(ErrorMessage = ErrorMessages.RequiredMessage)]
//[RegularExpression("^((https?)(:\\/\\/))?(?:www\\.)?[-a-zA-Z0-9@:%._\\+~#=]{1,256}\\.[a-zA-Z0-9()]{1,6}\\b(?:[-a-zA-Z0-9()@:%_\\+.~#?&\\/=]*)$", ErrorMessage = ErrorMessages.InvalidUrlMessage)]
//public string ButtonUrl { get; set; }

//[Required(ErrorMessage = ErrorMessages.RequiredMessage)]
//[RegularExpression("^((https?)(:\\/\\/))?(?:www\\.)?[-a-zA-Z0-9@:%._\\+~#=]{1,256}\\.[a-zA-Z0-9()]{1,6}\\b(?:[-a-zA-Z0-9()@:%_\\+.~#?&\\/=]*)$", ErrorMessage = ErrorMessages.InvalidUrlMessage)]
//public string RubriqueSourceImage { get; set; }
