// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.ProviderHub;

public static partial class SkusArgsExtensions
{
    public static global::Pulumi.AzureNative.ProviderHub.SkusArgs WithProperties(this global::Pulumi.AzureNative.ProviderHub.SkusArgs @selfRef, global::Pulumi.AzureNative.ProviderHub.Inputs.SkuResourcePropertiesArgs properties)
    {
        @selfRef.Properties = properties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ProviderHub.SkusArgs WithProperties(this global::Pulumi.AzureNative.ProviderHub.SkusArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ProviderHub.Inputs.SkuResourcePropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ProviderHub.Inputs.SkuResourcePropertiesArgs();
        @configure(@item);
        @selfRef.Properties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ProviderHub.SkusArgs WithProviderNamespace(this global::Pulumi.AzureNative.ProviderHub.SkusArgs @selfRef, global::System.String providerNamespace)
    {
        @selfRef.ProviderNamespace = providerNamespace;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ProviderHub.SkusArgs WithResourceType(this global::Pulumi.AzureNative.ProviderHub.SkusArgs @selfRef, global::System.String resourceType)
    {
        @selfRef.ResourceType = resourceType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ProviderHub.SkusArgs WithSku(this global::Pulumi.AzureNative.ProviderHub.SkusArgs @selfRef, global::System.String sku)
    {
        @selfRef.Sku = sku;
        return @selfRef;
    }

}
