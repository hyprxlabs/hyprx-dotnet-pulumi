// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.ProviderHub.Inputs;

namespace Pulumi.AzureNative.ProviderHub;

public static partial class ProviderHubMetadataThirdPartyProviderAuthorizationArgsExtensions
{
    public static global::Pulumi.AzureNative.ProviderHub.Inputs.ProviderHubMetadataThirdPartyProviderAuthorizationArgs WithAuthorizations(this global::Pulumi.AzureNative.ProviderHub.Inputs.ProviderHubMetadataThirdPartyProviderAuthorizationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.ProviderHub.Inputs.LightHouseAuthorizationArgs> authorizations)
    {
        @selfRef.Authorizations = authorizations;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ProviderHub.Inputs.ProviderHubMetadataThirdPartyProviderAuthorizationArgs WithAuthorizations(this global::Pulumi.AzureNative.ProviderHub.Inputs.ProviderHubMetadataThirdPartyProviderAuthorizationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.ProviderHub.Inputs.LightHouseAuthorizationArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.ProviderHub.Inputs.LightHouseAuthorizationArgs>();
        @configure(@list);
        @selfRef.Authorizations = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ProviderHub.Inputs.ProviderHubMetadataThirdPartyProviderAuthorizationArgs WithAuthorizations(this global::Pulumi.AzureNative.ProviderHub.Inputs.ProviderHubMetadataThirdPartyProviderAuthorizationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.ProviderHub.Inputs.LightHouseAuthorizationArgs>> @create)
    {
        @selfRef.Authorizations = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ProviderHub.Inputs.ProviderHubMetadataThirdPartyProviderAuthorizationArgs WithManagedByTenantId(this global::Pulumi.AzureNative.ProviderHub.Inputs.ProviderHubMetadataThirdPartyProviderAuthorizationArgs @selfRef, global::System.String managedByTenantId)
    {
        @selfRef.ManagedByTenantId = managedByTenantId;
        return @selfRef;
    }

}
