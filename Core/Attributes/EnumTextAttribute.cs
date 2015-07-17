using ImprovedEnum.Core.Interfaces;
using System;

namespace ImprovedEnum.Core.Attributes
{
    public class EnumTextAttribute : Attribute, IAttribute
    {
        public string Value { get; set; }

        public EnumTextAttribute(string value)
        {
            Value = value;
        }
    }
}
