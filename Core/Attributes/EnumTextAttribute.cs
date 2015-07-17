using System;

namespace ImprovedEnum.Core.Attributes
{
    public class EnumTextAttribute : Attribute
    {
        public string Value { get; protected set; }

        public EnumTextAttribute(string value)
        {
            Value = value;
        }
    }
}
