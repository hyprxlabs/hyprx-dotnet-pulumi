// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Migrate.Inputs;

namespace Pulumi.AzureNative.Migrate;

public static partial class NetworkSettingsArgsExtensions
{
    public static global::Pulumi.AzureNative.Migrate.Inputs.NetworkSettingsArgs WithHardwareSoftwareCostPercentage(this global::Pulumi.AzureNative.Migrate.Inputs.NetworkSettingsArgs @selfRef, global::System.Double hardwareSoftwareCostPercentage)
    {
        @selfRef.HardwareSoftwareCostPercentage = hardwareSoftwareCostPercentage;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.NetworkSettingsArgs WithMaintenanceCostPercentage(this global::Pulumi.AzureNative.Migrate.Inputs.NetworkSettingsArgs @selfRef, global::System.Double maintenanceCostPercentage)
    {
        @selfRef.MaintenanceCostPercentage = maintenanceCostPercentage;
        return @selfRef;
    }

}
