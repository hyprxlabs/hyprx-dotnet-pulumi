// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.HybridContainerService.Inputs;

namespace Pulumi.AzureNative.HybridContainerService;

public static partial class StorageSpacesPropertiesProvisioningStatusArgsExtensions
{
    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.StorageSpacesPropertiesProvisioningStatusArgs WithError(this global::Pulumi.AzureNative.HybridContainerService.Inputs.StorageSpacesPropertiesProvisioningStatusArgs @selfRef, global::Pulumi.AzureNative.HybridContainerService.Inputs.StorageSpacesPropertiesErrorArgs error)
    {
        @selfRef.Error = error;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.StorageSpacesPropertiesProvisioningStatusArgs WithError(this global::Pulumi.AzureNative.HybridContainerService.Inputs.StorageSpacesPropertiesProvisioningStatusArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.HybridContainerService.Inputs.StorageSpacesPropertiesErrorArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.HybridContainerService.Inputs.StorageSpacesPropertiesErrorArgs();
        @configure(@item);
        @selfRef.Error = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.StorageSpacesPropertiesProvisioningStatusArgs WithOperationId(this global::Pulumi.AzureNative.HybridContainerService.Inputs.StorageSpacesPropertiesProvisioningStatusArgs @selfRef, global::System.String operationId)
    {
        @selfRef.OperationId = operationId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.StorageSpacesPropertiesProvisioningStatusArgs WithPhase(this global::Pulumi.AzureNative.HybridContainerService.Inputs.StorageSpacesPropertiesProvisioningStatusArgs @selfRef, global::System.String phase)
    {
        @selfRef.Phase = phase;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.StorageSpacesPropertiesProvisioningStatusArgs WithStatus(this global::Pulumi.AzureNative.HybridContainerService.Inputs.StorageSpacesPropertiesProvisioningStatusArgs @selfRef, global::System.String status)
    {
        @selfRef.Status = status;
        return @selfRef;
    }

}
