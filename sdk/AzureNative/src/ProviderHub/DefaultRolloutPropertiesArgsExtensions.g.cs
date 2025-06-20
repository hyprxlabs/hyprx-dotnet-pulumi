// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.ProviderHub.Inputs;

namespace Pulumi.AzureNative.ProviderHub;

public static partial class DefaultRolloutPropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.ProviderHub.Inputs.DefaultRolloutPropertiesArgs WithProvisioningState(this global::Pulumi.AzureNative.ProviderHub.Inputs.DefaultRolloutPropertiesArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.ProviderHub.ProvisioningState> provisioningState)
    {
        @selfRef.ProvisioningState = provisioningState;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ProviderHub.Inputs.DefaultRolloutPropertiesArgs WithSpecification(this global::Pulumi.AzureNative.ProviderHub.Inputs.DefaultRolloutPropertiesArgs @selfRef, global::Pulumi.AzureNative.ProviderHub.Inputs.DefaultRolloutPropertiesSpecificationArgs specification)
    {
        @selfRef.Specification = specification;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ProviderHub.Inputs.DefaultRolloutPropertiesArgs WithSpecification(this global::Pulumi.AzureNative.ProviderHub.Inputs.DefaultRolloutPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ProviderHub.Inputs.DefaultRolloutPropertiesSpecificationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ProviderHub.Inputs.DefaultRolloutPropertiesSpecificationArgs();
        @configure(@item);
        @selfRef.Specification = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ProviderHub.Inputs.DefaultRolloutPropertiesArgs WithStatus(this global::Pulumi.AzureNative.ProviderHub.Inputs.DefaultRolloutPropertiesArgs @selfRef, global::Pulumi.AzureNative.ProviderHub.Inputs.DefaultRolloutPropertiesStatusArgs status)
    {
        @selfRef.Status = status;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ProviderHub.Inputs.DefaultRolloutPropertiesArgs WithStatus(this global::Pulumi.AzureNative.ProviderHub.Inputs.DefaultRolloutPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ProviderHub.Inputs.DefaultRolloutPropertiesStatusArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ProviderHub.Inputs.DefaultRolloutPropertiesStatusArgs();
        @configure(@item);
        @selfRef.Status = @item;
        return @selfRef;
    }

}
