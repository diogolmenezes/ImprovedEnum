using System;

namespace ImprovedEnum.Core.Attributes
{
    public class EnumValueAttribute : Attribute
    {
        public string Value { get; protected set; }

        public EnumValueAttribute(string value)
        {
            Value = value;
        }
    }
}
