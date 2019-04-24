using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$.Helper
{
    public static class StringHelper
    {
        public static string RemoverCaractersEspecias(this string text)
        {
            text = text.Replace(".", "").Replace(",", "").Replace("-", "").Replace("'", "").Replace("´", "").Replace("`", "").Replace("^", "").Replace("~", "").Replace("{", "").Replace("}", "")
                        .Replace("[", "").Replace("]", "").Replace("/", "").Replace(";", "").Replace(":", "").Replace(">", "").Replace("<", "").Replace("|", "").Replace(@"\", "").Replace(@"""", "")
                        .Replace("(", "").Replace(")", "").Replace("*", "").Replace("¨", "").Replace("%", "").Replace("$", "").Replace("#", "").Replace("@", "").Replace("!", "").Replace("?", "")
                        .Replace("°", "").Replace("₢", "").Replace("¹", "").Replace("²", "").Replace("³", "").Replace("£", "").Replace("¢", "").Replace("¬", "").Replace("+", "").Replace("-", "")
                        .Replace("_", "").Replace("=", "");

            text = text.Trim();

            return text;

        }

        public static string RemoverAcentos(this string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }
    }
}