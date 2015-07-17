using ImprovedEnum.Core.Interfaces;
using System;

namespace ImprovedEnum.Core.Attributes
{
    public class MyAttribute : Attribute, IAttribute
    {
        public string Value { get; set; }

        public MyAttribute(string value)
        {
            Value = value;
        }
    }
}
