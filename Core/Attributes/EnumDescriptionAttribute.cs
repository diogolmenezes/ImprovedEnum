using System;

namespace ImprovedEnum.Core.Attributes
{
    public class EnumDescriptionAttribute : Attribute
    {
        public string Value { get; protected set; }

        public EnumDescriptionAttribute(string value)
        {
            Value = value;
        }
    }
}
