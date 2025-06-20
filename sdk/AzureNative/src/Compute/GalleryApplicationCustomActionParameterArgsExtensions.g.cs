// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Compute.Inputs;

namespace Pulumi.AzureNative.Compute;

public static partial class GalleryApplicationCustomActionParameterArgsExtensions
{
    public static global::Pulumi.AzureNative.Compute.Inputs.GalleryApplicationCustomActionParameterArgs WithDefaultValue(this global::Pulumi.AzureNative.Compute.Inputs.GalleryApplicationCustomActionParameterArgs @selfRef, global::System.String defaultValue)
    {
        @selfRef.DefaultValue = defaultValue;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.GalleryApplicationCustomActionParameterArgs WithDescription(this global::Pulumi.AzureNative.Compute.Inputs.GalleryApplicationCustomActionParameterArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.GalleryApplicationCustomActionParameterArgs WithName(this global::Pulumi.AzureNative.Compute.Inputs.GalleryApplicationCustomActionParameterArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.GalleryApplicationCustomActionParameterArgs WithRequired(this global::Pulumi.AzureNative.Compute.Inputs.GalleryApplicationCustomActionParameterArgs @selfRef, bool required = true)
    {
        @selfRef.Required = required;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.GalleryApplicationCustomActionParameterArgs WithType(this global::Pulumi.AzureNative.Compute.Inputs.GalleryApplicationCustomActionParameterArgs @selfRef, global::Pulumi.AzureNative.Compute.GalleryApplicationCustomActionParameterType type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.GalleryApplicationCustomActionParameterArgs WithType(this global::Pulumi.AzureNative.Compute.Inputs.GalleryApplicationCustomActionParameterArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Compute.GalleryApplicationCustomActionParameterType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AzureNative.Compute.GalleryApplicationCustomActionParameterType>();
        @configure(@item);
        @selfRef.Type = @item;
        return @selfRef;
    }

}
