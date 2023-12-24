using EasyMicroservices.UI.BlazorKits.DataTypes;
using Radzen;

namespace EasyMicroservices.UI.BlazorKits.RadzenBlazorUI.Converters;
internal static class DataTypeConverter
{
    public static Variant ConvertVariant(EasyVariantType easyVariantType)
    {
        switch (easyVariantType)
        {
            case EasyVariantType.Text:
                return Variant.Text;

            case EasyVariantType.Filled:
                return Variant.Filled;

            case EasyVariantType.Outlined:
                return Variant.Outlined;

            default:
                throw new ArgumentOutOfRangeException(nameof(easyVariantType), easyVariantType, null);
        }
    }

    public static ButtonStyle ConvertButtonStyle(EasyColorType easyColorType)
    {
        switch (easyColorType)
        {
            case EasyColorType.Primary:
                return ButtonStyle.Primary;
            case EasyColorType.Secondary:
                return ButtonStyle.Secondary;
            case EasyColorType.Success:
                return ButtonStyle.Success;
            case EasyColorType.Warning:
                return ButtonStyle.Warning;
            case EasyColorType.Error:
                return ButtonStyle.Danger;
            case EasyColorType.Info:
                return ButtonStyle.Info;
            case EasyColorType.Dark:
                return ButtonStyle.Dark;
            case EasyColorType.Transparent:
            case EasyColorType.Inherit:
            case EasyColorType.Surface:
            case EasyColorType.Tertiary:
            case EasyColorType.Default:
                return ButtonStyle.Light;
            default:
                // Handle any cases that don't have a direct mapping.
                throw new ArgumentOutOfRangeException(nameof(easyColorType), easyColorType, null);
        }
    }
}
