// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AppPlatform.Inputs;

namespace Pulumi.AzureNative.AppPlatform;

public static partial class ClusterResourcePropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.AppPlatform.Inputs.ClusterResourcePropertiesArgs WithInfraResourceGroup(this global::Pulumi.AzureNative.AppPlatform.Inputs.ClusterResourcePropertiesArgs @selfRef, global::System.String infraResourceGroup)
    {
        @selfRef.InfraResourceGroup = infraResourceGroup;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppPlatform.Inputs.ClusterResourcePropertiesArgs WithMaintenanceScheduleConfiguration(this global::Pulumi.AzureNative.AppPlatform.Inputs.ClusterResourcePropertiesArgs @selfRef, global::Pulumi.AzureNative.AppPlatform.Inputs.WeeklyMaintenanceScheduleConfigurationArgs maintenanceScheduleConfiguration)
    {
        @selfRef.MaintenanceScheduleConfiguration = maintenanceScheduleConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppPlatform.Inputs.ClusterResourcePropertiesArgs WithMaintenanceScheduleConfiguration(this global::Pulumi.AzureNative.AppPlatform.Inputs.ClusterResourcePropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AppPlatform.Inputs.WeeklyMaintenanceScheduleConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AppPlatform.Inputs.WeeklyMaintenanceScheduleConfigurationArgs();
        @configure(@item);
        @selfRef.MaintenanceScheduleConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppPlatform.Inputs.ClusterResourcePropertiesArgs WithManagedEnvironmentId(this global::Pulumi.AzureNative.AppPlatform.Inputs.ClusterResourcePropertiesArgs @selfRef, global::System.String managedEnvironmentId)
    {
        @selfRef.ManagedEnvironmentId = managedEnvironmentId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppPlatform.Inputs.ClusterResourcePropertiesArgs WithMarketplaceResource(this global::Pulumi.AzureNative.AppPlatform.Inputs.ClusterResourcePropertiesArgs @selfRef, global::Pulumi.AzureNative.AppPlatform.Inputs.MarketplaceResourceArgs marketplaceResource)
    {
        @selfRef.MarketplaceResource = marketplaceResource;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppPlatform.Inputs.ClusterResourcePropertiesArgs WithMarketplaceResource(this global::Pulumi.AzureNative.AppPlatform.Inputs.ClusterResourcePropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AppPlatform.Inputs.MarketplaceResourceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AppPlatform.Inputs.MarketplaceResourceArgs();
        @configure(@item);
        @selfRef.MarketplaceResource = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppPlatform.Inputs.ClusterResourcePropertiesArgs WithNetworkProfile(this global::Pulumi.AzureNative.AppPlatform.Inputs.ClusterResourcePropertiesArgs @selfRef, global::Pulumi.AzureNative.AppPlatform.Inputs.NetworkProfileArgs networkProfile)
    {
        @selfRef.NetworkProfile = networkProfile;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppPlatform.Inputs.ClusterResourcePropertiesArgs WithNetworkProfile(this global::Pulumi.AzureNative.AppPlatform.Inputs.ClusterResourcePropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AppPlatform.Inputs.NetworkProfileArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AppPlatform.Inputs.NetworkProfileArgs();
        @configure(@item);
        @selfRef.NetworkProfile = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppPlatform.Inputs.ClusterResourcePropertiesArgs WithVnetAddons(this global::Pulumi.AzureNative.AppPlatform.Inputs.ClusterResourcePropertiesArgs @selfRef, global::Pulumi.AzureNative.AppPlatform.Inputs.ServiceVNetAddonsArgs vnetAddons)
    {
        @selfRef.VnetAddons = vnetAddons;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppPlatform.Inputs.ClusterResourcePropertiesArgs WithVnetAddons(this global::Pulumi.AzureNative.AppPlatform.Inputs.ClusterResourcePropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AppPlatform.Inputs.ServiceVNetAddonsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AppPlatform.Inputs.ServiceVNetAddonsArgs();
        @configure(@item);
        @selfRef.VnetAddons = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppPlatform.Inputs.ClusterResourcePropertiesArgs WithZoneRedundant(this global::Pulumi.AzureNative.AppPlatform.Inputs.ClusterResourcePropertiesArgs @selfRef, bool zoneRedundant = true)
    {
        @selfRef.ZoneRedundant = zoneRedundant;
        return @selfRef;
    }

}
