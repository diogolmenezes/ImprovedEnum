# ImprovedEnum
ImprovedEnum adds functionality to .net Enum as ToList and recovery data from annotation attributes

## Getting Started

Add [ImprovedEnum.dll](https://github.com/diogolmenezes/ImprovedEnum/tree/master/Binary) as reference on your test project.

or use the [NuGet repository](https://www.nuget.org/packages/ImprovedEnum):

```
PM> Install-Package ImprovedEnum
```

## Using ToList

You can convert an enum to a list os system enum and use all .net list features.

```c#
public enum Gender
{
    Male,
    Female
}
```

```c#
using ImprovedEnum.Core;

// convert enum in a list of System.Enum
var list = EnumHelper.ToList<Gender>();

// filter the list
var male = list.Where(x => x.ToString().Equals("Male")).FirstOrDefault();
```

## Getting Attributes

You can get the values of  your enum attributes

```c#
using ImprovedEnum.Core;

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
```

```c#
using ImprovedEnum.Core;

// get text
var text = ItemStatus.Open.Text();

// get description
var text = ItemStatus.Open.Description();

// get value
var text = ItemStatus.Open.Value();
```

## Using custom attibutes

You can use your custom Attribute  only implementing IAttribute interface.

```c#
using ImprovedEnum.Core;

public class MyAttribute : Attribute, IAttribute
{
    public string Value { get; set; }

    public MyAttribute(string value)
    {
        Value = value;
    }
}
```

```c#
public enum Color
{
    [MyAttribute("Custom attribute in color red")]
    Red,

    [MyAttribute("Custom attribute in color blue")]
    Blue,

    [MyAttribute("Custom attribute in color black")]
    Black
}
```

```c#
var value = Color.Red.GetAttributeValue<MyAttribute>();
```

## Tests

ImprovedEnum has many tests in the test project if you want take a look.

## Pull Requests

ImprovedEnum is open to improve, send your pull request and help ImprovedEnum to be the best improved enum ever :)