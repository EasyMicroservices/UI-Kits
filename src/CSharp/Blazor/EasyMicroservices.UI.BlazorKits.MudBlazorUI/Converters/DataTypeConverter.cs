using EasyMicroservices.UI.BlazorKits.DataTypes;
using MudBlazor;

namespace EasyMicroservices.UI.BlazorKits.MudBlazorUI.Converters;
internal static class DataTypeConverter
{
    public static Color ConvertColor(EasyColorType easyColorType)
    {
        return (Color)easyColorType;
    }

    public static Variant ConvertVariant(EasyVariantType easyVariantType)
    {
        return (Variant)easyVariantType;
    }
}
