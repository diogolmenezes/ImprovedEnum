using ImprovedEnum.Core;
using ImprovedEnum.Core.Attributes;
using ImprovedEnum.Test.SampleEnums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace ImprovedEnum.Test
{
    [TestClass]
    public class EnumTest
    {
        [TestMethod]
        public void Can_Convert_Enum_To_List_Of_System_Enum()
        {
            var list = EnumHelper.ToList<Gender>();
            
            Assert.AreEqual(2, list.Count);
        }

        [TestMethod]
        public void Can_Use_Normal_Linq_Queries_With_ToList_List()
        {
            var list = EnumHelper.ToList<Gender>();
            var male = list.Where(x => x.ToString().Equals("Male")).FirstOrDefault();
            
            Assert.IsNotNull(male);
        }

        [TestMethod]
        public void Can_GetHashCode_In_Value()
        {
            var list = EnumHelper.ToList<Gender>();
            var male = list.Where(x => x.ToString().Equals("Male")).FirstOrDefault();
            Assert.AreEqual("0", male.Value());
        }

        [TestMethod]
        public void Can_Get_ToString_In_Text_When_No_EnumTextAttribute_Is_Set()
        {
            var list = EnumHelper.ToList<Gender>();
            var male = list.Where(x => x.ToString().Equals("Male")).FirstOrDefault();

            Assert.AreEqual("Male", male.Text());
        }

        [TestMethod]
        public void Can_Get_EnumTextAttribute()
        {
            Assert.AreEqual("Item is Open", ItemStatus.Open.Text());
            Assert.AreEqual("Item is Pending", ItemStatus.Pending.Text());
            Assert.AreEqual("Item is Canceled", ItemStatus.Canceled.Text());
            Assert.AreEqual("Item is Done", ItemStatus.Done.Text());
        }

        [TestMethod]
        public void Can_Get_EnumDescriptionAttribute()
        {
            Assert.AreEqual("Status used when item is open", ItemStatus.Open.Description());
            Assert.AreEqual("Status used when item is pending", ItemStatus.Pending.Description());
            Assert.AreEqual("Status used when item is canceled", ItemStatus.Canceled.Description());
            Assert.AreEqual("Status used when item is done", ItemStatus.Done.Description());
        }

        [TestMethod]
        public void Can_Get_CustomAttributes()
        {
            // yes, you can get your custom attributes
            Assert.AreEqual("Custom attribute in color red", Color.Red.GetAttributeValue<MyAttribute>());
            Assert.AreEqual("Custom attribute in color black", Color.Black.GetAttributeValue<MyAttribute>());
            Assert.AreEqual("Custom attribute in color blue", Color.Blue.GetAttributeValue<MyAttribute>());
        }

    }
}
