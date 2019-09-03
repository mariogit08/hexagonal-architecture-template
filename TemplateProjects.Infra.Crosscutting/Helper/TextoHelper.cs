using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  $safeprojectname$.Helper
{
    public static class TextoHelper
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

        public static string RemoverAcentosv2(string texto)
        {
            if (texto == null) return string.Empty;

            const string comAcentos = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇç";
            const string semAcentos = "AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuuCc";

            for (var i = 0; i < comAcentos.Length; i++)
                texto = texto.Replace(comAcentos[i].ToString(), semAcentos[i].ToString());

            return texto;
        }

        public static string FormatarTextoParaUrl(string texto)
        {
            texto = RemoverAcentos(texto);

            var textoretorno = texto.Replace(" ", "");

            const string permitidos = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmonopqrstuvwxyz0123456789-_";

            for (var i = 0; i < texto.Length; i++)
                if (!permitidos.Contains(texto.Substring(i, 1))) { textoretorno = textoretorno.Replace(texto.Substring(i, 1), ""); }

            return textoretorno;
        }

        public static string GetNumeros(string texto)
        {
            return string.IsNullOrEmpty(texto) ? "" : new String(texto.Where(Char.IsDigit).ToArray());
        }

        public static string AjustarTexto(string valor, int tamanho)
        {
            if (valor.Length > tamanho)
            {
                valor = valor.Substring(1, tamanho);
            }
            return valor;
        }

        public static string ToTitleCase(string texto)
        {
            return ToTitleCase(texto, false);
        }

        public static string ToTitleCase(string texto, bool manterOqueJaEstiverMaiusculo)
        {
            texto = texto.Trim();

            if (!manterOqueJaEstiverMaiusculo)
                texto = texto.ToLower();

            var textInfo = new CultureInfo("pt-BR", false).TextInfo;
            return textInfo.ToTitleCase(texto);
        }
    }
}
