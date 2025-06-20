// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.ContainerService.Inputs;

namespace Pulumi.AzureNative.ContainerService;

public static partial class ManagedClusterUpdateArgsExtensions
{
    public static global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterUpdateArgs WithNodeImageSelection(this global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterUpdateArgs @selfRef, global::Pulumi.AzureNative.ContainerService.Inputs.NodeImageSelectionArgs nodeImageSelection)
    {
        @selfRef.NodeImageSelection = nodeImageSelection;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterUpdateArgs WithNodeImageSelection(this global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterUpdateArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ContainerService.Inputs.NodeImageSelectionArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ContainerService.Inputs.NodeImageSelectionArgs();
        @configure(@item);
        @selfRef.NodeImageSelection = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterUpdateArgs WithUpgrade(this global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterUpdateArgs @selfRef, global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterUpgradeSpecArgs upgrade)
    {
        @selfRef.Upgrade = upgrade;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterUpdateArgs WithUpgrade(this global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterUpdateArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterUpgradeSpecArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterUpgradeSpecArgs();
        @configure(@item);
        @selfRef.Upgrade = @item;
        return @selfRef;
    }

}
