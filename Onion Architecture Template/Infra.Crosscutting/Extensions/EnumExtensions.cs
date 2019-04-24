using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$.Extensions
{
    public static class EnumExtensions
    {
        public static List<KeyValuePair<int, string>> ToKeyValuePair(this Type type)
        {
            if (!type.IsEnum)
                throw new ArgumentException("O tipo passado em parâmetro não corresponde a um Enum.");
            var dict = new List<KeyValuePair<int, string>>();
            foreach (var name in Enum.GetNames(type))
            {
                dict.Add(new KeyValuePair<int, string>((int)Enum.Parse(type, name), ((Enum)Enum.Parse(type, name)).GetDescription()));
            }
            return dict;
        }

        public static string GetDescription(this Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute),
                false);

            if (attributes != null &&
                attributes.Length > 0)
                return attributes[0].Description.ToUpper();
            else
                return value.ToString();
        }
    }
}

