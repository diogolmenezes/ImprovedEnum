
using ImprovedEnum.Core.Attributes;
namespace ImprovedEnum.Test.SampleEnums
{
    public enum ItemStatus
    {       
        [EnumText("Item is Open")]
        [EnumDescription("Status used when item is open")]
        [EnumValue("O")]
        Open,

        [EnumText("Item is Pending")]
        [EnumDescription("Status used when item is pending")]
        [EnumValue("P")]
        Pending,

        [EnumText("Item is Canceled")]
        [EnumDescription("Status used when item is canceled")]
        [EnumValue("C")]
        Canceled,

        [EnumText("Item is Done")]
        [EnumDescription("Status used when item is done")]
        [EnumValue("D")]
        Done
    }
}
