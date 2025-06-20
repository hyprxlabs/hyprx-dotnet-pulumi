// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Synapse.Inputs;

namespace Pulumi.AzureNative.Synapse;

public static partial class IntegrationRuntimeSsisCatalogInfoArgsExtensions
{
    public static global::Pulumi.AzureNative.Synapse.Inputs.IntegrationRuntimeSsisCatalogInfoArgs WithCatalogAdminPassword(this global::Pulumi.AzureNative.Synapse.Inputs.IntegrationRuntimeSsisCatalogInfoArgs @selfRef, global::Pulumi.AzureNative.Synapse.Inputs.SecureStringArgs catalogAdminPassword)
    {
        @selfRef.CatalogAdminPassword = catalogAdminPassword;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Synapse.Inputs.IntegrationRuntimeSsisCatalogInfoArgs WithCatalogAdminPassword(this global::Pulumi.AzureNative.Synapse.Inputs.IntegrationRuntimeSsisCatalogInfoArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Synapse.Inputs.SecureStringArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Synapse.Inputs.SecureStringArgs();
        @configure(@item);
        @selfRef.CatalogAdminPassword = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Synapse.Inputs.IntegrationRuntimeSsisCatalogInfoArgs WithCatalogAdminUserName(this global::Pulumi.AzureNative.Synapse.Inputs.IntegrationRuntimeSsisCatalogInfoArgs @selfRef, global::System.String catalogAdminUserName)
    {
        @selfRef.CatalogAdminUserName = catalogAdminUserName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Synapse.Inputs.IntegrationRuntimeSsisCatalogInfoArgs WithCatalogPricingTier(this global::Pulumi.AzureNative.Synapse.Inputs.IntegrationRuntimeSsisCatalogInfoArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Synapse.IntegrationRuntimeSsisCatalogPricingTier> catalogPricingTier)
    {
        @selfRef.CatalogPricingTier = catalogPricingTier;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Synapse.Inputs.IntegrationRuntimeSsisCatalogInfoArgs WithCatalogServerEndpoint(this global::Pulumi.AzureNative.Synapse.Inputs.IntegrationRuntimeSsisCatalogInfoArgs @selfRef, global::System.String catalogServerEndpoint)
    {
        @selfRef.CatalogServerEndpoint = catalogServerEndpoint;
        return @selfRef;
    }

}
