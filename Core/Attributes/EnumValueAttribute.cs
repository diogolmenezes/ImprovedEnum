using ImprovedEnum.Core.Interfaces;
using System;

namespace ImprovedEnum.Core.Attributes
{
    public class EnumValueAttribute : Attribute, IAttribute
    {
        public string Value { get; set; }

        public EnumValueAttribute(string value)
        {
            Value = value;
        }
    }
}
