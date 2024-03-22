using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RobinsonNewsletter.Core.Helpers;

public static partial class Utils
{
    public static bool IsValidUrl(string url) => UrlRegex().IsMatch(url);

    [GeneratedRegex("^((https?)(:\\/\\/))?(?:www\\.)?[-a-zA-Z0-9@:%._\\+~#=]{1,256}\\.[a-zA-Z0-9()]{1,6}\\b(?:[-a-zA-Z0-9()@:%_\\+.~#?&\\/=]*)$")]
    private static partial Regex UrlRegex();
}
