// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AzureFleet.Inputs;

namespace Pulumi.AzureNative.AzureFleet;

public static partial class DiffDiskSettingsArgsExtensions
{
    public static global::Pulumi.AzureNative.AzureFleet.Inputs.DiffDiskSettingsArgs WithOption(this global::Pulumi.AzureNative.AzureFleet.Inputs.DiffDiskSettingsArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AzureFleet.DiffDiskOptions> option)
    {
        @selfRef.Option = option;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.DiffDiskSettingsArgs WithPlacement(this global::Pulumi.AzureNative.AzureFleet.Inputs.DiffDiskSettingsArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AzureFleet.DiffDiskPlacement> placement)
    {
        @selfRef.Placement = placement;
        return @selfRef;
    }

}
