// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DevCenter.Inputs;

namespace Pulumi.AzureNative.DevCenter;

public static partial class DevCenterProjectCatalogSettingsArgsExtensions
{
    public static global::Pulumi.AzureNative.DevCenter.Inputs.DevCenterProjectCatalogSettingsArgs WithCatalogItemSyncEnableStatus(this global::Pulumi.AzureNative.DevCenter.Inputs.DevCenterProjectCatalogSettingsArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.DevCenter.CatalogItemSyncEnableStatus> catalogItemSyncEnableStatus)
    {
        @selfRef.CatalogItemSyncEnableStatus = catalogItemSyncEnableStatus;
        return @selfRef;
    }

}
