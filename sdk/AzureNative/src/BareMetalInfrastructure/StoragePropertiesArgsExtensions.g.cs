// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.BareMetalInfrastructure.Inputs;

namespace Pulumi.AzureNative.BareMetalInfrastructure;

public static partial class StoragePropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.BareMetalInfrastructure.Inputs.StoragePropertiesArgs WithGeneration(this global::Pulumi.AzureNative.BareMetalInfrastructure.Inputs.StoragePropertiesArgs @selfRef, global::System.String generation)
    {
        @selfRef.Generation = generation;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BareMetalInfrastructure.Inputs.StoragePropertiesArgs WithHardwareType(this global::Pulumi.AzureNative.BareMetalInfrastructure.Inputs.StoragePropertiesArgs @selfRef, global::System.String hardwareType)
    {
        @selfRef.HardwareType = hardwareType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BareMetalInfrastructure.Inputs.StoragePropertiesArgs WithOfferingType(this global::Pulumi.AzureNative.BareMetalInfrastructure.Inputs.StoragePropertiesArgs @selfRef, global::System.String offeringType)
    {
        @selfRef.OfferingType = offeringType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BareMetalInfrastructure.Inputs.StoragePropertiesArgs WithProvisioningState(this global::Pulumi.AzureNative.BareMetalInfrastructure.Inputs.StoragePropertiesArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.BareMetalInfrastructure.ProvisioningState> provisioningState)
    {
        @selfRef.ProvisioningState = provisioningState;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BareMetalInfrastructure.Inputs.StoragePropertiesArgs WithStorageBillingProperties(this global::Pulumi.AzureNative.BareMetalInfrastructure.Inputs.StoragePropertiesArgs @selfRef, global::Pulumi.AzureNative.BareMetalInfrastructure.Inputs.StorageBillingPropertiesArgs storageBillingProperties)
    {
        @selfRef.StorageBillingProperties = storageBillingProperties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BareMetalInfrastructure.Inputs.StoragePropertiesArgs WithStorageBillingProperties(this global::Pulumi.AzureNative.BareMetalInfrastructure.Inputs.StoragePropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.BareMetalInfrastructure.Inputs.StorageBillingPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.BareMetalInfrastructure.Inputs.StorageBillingPropertiesArgs();
        @configure(@item);
        @selfRef.StorageBillingProperties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BareMetalInfrastructure.Inputs.StoragePropertiesArgs WithStorageType(this global::Pulumi.AzureNative.BareMetalInfrastructure.Inputs.StoragePropertiesArgs @selfRef, global::System.String storageType)
    {
        @selfRef.StorageType = storageType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BareMetalInfrastructure.Inputs.StoragePropertiesArgs WithWorkloadType(this global::Pulumi.AzureNative.BareMetalInfrastructure.Inputs.StoragePropertiesArgs @selfRef, global::System.String workloadType)
    {
        @selfRef.WorkloadType = workloadType;
        return @selfRef;
    }

}
