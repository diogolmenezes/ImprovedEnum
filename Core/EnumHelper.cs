using ImprovedEnum.Core.Attributes;
using ImprovedEnum.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ImprovedEnum.Core
{
    public static class EnumHelper
    {
        public static T GetEnum<T>(this string value)
        {
            try
            {
                value = value.ToLower();

                return (T)ToList<T>().Where(x => x.Value().ToLower() == value || x.Description().ToLower() == value || x.ToString().ToLower() == value)
                           .Select(x => System.Enum.Parse(typeof(T), x.GetHashCode().ToString(), true))
                           .FirstOrDefault();

            }
            catch (Exception ex)
            {
                throw new Exception("Could not found the enum for the value", ex);
            }
        }

        public static string GetAttributeValue<T>(this System.Enum @enum)
        {
            try
            {
                var attribute = (IAttribute) @enum.GetType().GetField(@enum.ToString()).GetCustomAttributes(typeof(T), false).FirstOrDefault();
                return attribute == null ? string.Empty : attribute.Value;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Not found {0} for the enum.", typeof(T).Name), ex);
            }

        }

        public static string Description(this System.Enum @enum)
        {
            return GetAttributeValue<EnumDescriptionAttribute>(@enum);
        }

        public static string Text(this System.Enum @enum)
        {
            var value = GetAttributeValue<EnumTextAttribute>(@enum);
            return String.IsNullOrEmpty(value) ? @enum.ToString() : value;
        }

        public static string Value(this System.Enum @enum)
        {
            var value = GetAttributeValue<EnumValueAttribute>(@enum);
            return String.IsNullOrEmpty(value) ? @enum.GetHashCode().ToString() : value;
        }

        public static IList<System.Enum> ToList<T>()
        {
            return System.Enum.GetValues(typeof(T)).Cast<System.Enum>().ToList();
        }

        //public static IList<SelectListItem> ToSelectList<T>(string selectedValue = null)
        //{
        //    var list = ToList<T>();

        //    return list.Select(x => new SelectListItem()
        //    {
        //        Text        = x.Text(),
        //        Value       = x.Value(),
        //        Selected    = selectedValue != null && selectedValue.ToLower() == x.Value().ToLower()
        //    })
        //    .OrderBy(x => x.Text)
        //    .ToList();
        //}
    }
}
