using EasyMicroservices.UI.BlazorKits.DataTypes;
using Microsoft.AspNetCore.Components;
using System.ComponentModel;

namespace EasyMicroservices.UI.BlazorKits.Components;
public class EasyButtonBase : ComponentBase
{
    public ComponentBase Control { get; set; }

    [Parameter]
    public RenderFragment ChildContent { get; set; }

    [Parameter]
    [Category("Behavior")]
    public bool IsEnabled { get; set; } = true;

    [Parameter]
    [Category("Behavior")]
    public EasyColorType Color { get; set; }

    [Parameter]
    [Category("Behavior")]
    public EasyVariantType Variant { get; set; }
}
