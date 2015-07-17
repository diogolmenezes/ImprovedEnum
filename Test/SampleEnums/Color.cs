
using ImprovedEnum.Core.Attributes;
namespace ImprovedEnum.Test.SampleEnums
{
    public enum Color
    {
        [MyAttribute("Custom attribute in color red")]
        Red,

        [MyAttribute("Custom attribute in color blue")]
        Blue,

        [MyAttribute("Custom attribute in color black")]
        Black
    }
}
