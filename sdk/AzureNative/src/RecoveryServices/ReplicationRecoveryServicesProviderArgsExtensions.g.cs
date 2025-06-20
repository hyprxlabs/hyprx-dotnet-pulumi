// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.RecoveryServices;

public static partial class ReplicationRecoveryServicesProviderArgsExtensions
{
    public static global::Pulumi.AzureNative.RecoveryServices.ReplicationRecoveryServicesProviderArgs WithFabricName(this global::Pulumi.AzureNative.RecoveryServices.ReplicationRecoveryServicesProviderArgs @selfRef, global::System.String fabricName)
    {
        @selfRef.FabricName = fabricName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.ReplicationRecoveryServicesProviderArgs WithProperties(this global::Pulumi.AzureNative.RecoveryServices.ReplicationRecoveryServicesProviderArgs @selfRef, global::Pulumi.AzureNative.RecoveryServices.Inputs.AddRecoveryServicesProviderInputPropertiesArgs properties)
    {
        @selfRef.Properties = properties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.ReplicationRecoveryServicesProviderArgs WithProperties(this global::Pulumi.AzureNative.RecoveryServices.ReplicationRecoveryServicesProviderArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.RecoveryServices.Inputs.AddRecoveryServicesProviderInputPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.RecoveryServices.Inputs.AddRecoveryServicesProviderInputPropertiesArgs();
        @configure(@item);
        @selfRef.Properties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.ReplicationRecoveryServicesProviderArgs WithProviderName(this global::Pulumi.AzureNative.RecoveryServices.ReplicationRecoveryServicesProviderArgs @selfRef, global::System.String providerName)
    {
        @selfRef.ProviderName = providerName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.ReplicationRecoveryServicesProviderArgs WithResourceGroupName(this global::Pulumi.AzureNative.RecoveryServices.ReplicationRecoveryServicesProviderArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.ReplicationRecoveryServicesProviderArgs WithResourceName(this global::Pulumi.AzureNative.RecoveryServices.ReplicationRecoveryServicesProviderArgs @selfRef, global::System.String resourceName)
    {
        @selfRef.ResourceName = resourceName;
        return @selfRef;
    }

}
