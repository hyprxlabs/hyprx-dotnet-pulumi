// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.AppConfiguration;

public static partial class ConfigurationStoreArgsExtensions
{
    public static global::Pulumi.AzureNative.AppConfiguration.ConfigurationStoreArgs WithConfigStoreName(this global::Pulumi.AzureNative.AppConfiguration.ConfigurationStoreArgs @selfRef, global::System.String configStoreName)
    {
        @selfRef.ConfigStoreName = configStoreName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppConfiguration.ConfigurationStoreArgs WithCreateMode(this global::Pulumi.AzureNative.AppConfiguration.ConfigurationStoreArgs @selfRef, global::Pulumi.AzureNative.AppConfiguration.CreateMode createMode)
    {
        @selfRef.CreateMode = createMode;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppConfiguration.ConfigurationStoreArgs WithCreateMode(this global::Pulumi.AzureNative.AppConfiguration.ConfigurationStoreArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AppConfiguration.CreateMode> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AzureNative.AppConfiguration.CreateMode>();
        @configure(@item);
        @selfRef.CreateMode = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppConfiguration.ConfigurationStoreArgs WithDataPlaneProxy(this global::Pulumi.AzureNative.AppConfiguration.ConfigurationStoreArgs @selfRef, global::Pulumi.AzureNative.AppConfiguration.Inputs.DataPlaneProxyPropertiesArgs dataPlaneProxy)
    {
        @selfRef.DataPlaneProxy = dataPlaneProxy;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppConfiguration.ConfigurationStoreArgs WithDataPlaneProxy(this global::Pulumi.AzureNative.AppConfiguration.ConfigurationStoreArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AppConfiguration.Inputs.DataPlaneProxyPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AppConfiguration.Inputs.DataPlaneProxyPropertiesArgs();
        @configure(@item);
        @selfRef.DataPlaneProxy = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppConfiguration.ConfigurationStoreArgs WithDisableLocalAuth(this global::Pulumi.AzureNative.AppConfiguration.ConfigurationStoreArgs @selfRef, bool disableLocalAuth = true)
    {
        @selfRef.DisableLocalAuth = disableLocalAuth;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppConfiguration.ConfigurationStoreArgs WithEnablePurgeProtection(this global::Pulumi.AzureNative.AppConfiguration.ConfigurationStoreArgs @selfRef, bool enablePurgeProtection = true)
    {
        @selfRef.EnablePurgeProtection = enablePurgeProtection;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppConfiguration.ConfigurationStoreArgs WithEncryption(this global::Pulumi.AzureNative.AppConfiguration.ConfigurationStoreArgs @selfRef, global::Pulumi.AzureNative.AppConfiguration.Inputs.EncryptionPropertiesArgs encryption)
    {
        @selfRef.Encryption = encryption;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppConfiguration.ConfigurationStoreArgs WithEncryption(this global::Pulumi.AzureNative.AppConfiguration.ConfigurationStoreArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AppConfiguration.Inputs.EncryptionPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AppConfiguration.Inputs.EncryptionPropertiesArgs();
        @configure(@item);
        @selfRef.Encryption = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppConfiguration.ConfigurationStoreArgs WithIdentity(this global::Pulumi.AzureNative.AppConfiguration.ConfigurationStoreArgs @selfRef, global::Pulumi.AzureNative.AppConfiguration.Inputs.ResourceIdentityArgs identity)
    {
        @selfRef.Identity = identity;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppConfiguration.ConfigurationStoreArgs WithIdentity(this global::Pulumi.AzureNative.AppConfiguration.ConfigurationStoreArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AppConfiguration.Inputs.ResourceIdentityArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AppConfiguration.Inputs.ResourceIdentityArgs();
        @configure(@item);
        @selfRef.Identity = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppConfiguration.ConfigurationStoreArgs WithLocation(this global::Pulumi.AzureNative.AppConfiguration.ConfigurationStoreArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppConfiguration.ConfigurationStoreArgs WithPublicNetworkAccess(this global::Pulumi.AzureNative.AppConfiguration.ConfigurationStoreArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AppConfiguration.PublicNetworkAccess> publicNetworkAccess)
    {
        @selfRef.PublicNetworkAccess = publicNetworkAccess;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppConfiguration.ConfigurationStoreArgs WithResourceGroupName(this global::Pulumi.AzureNative.AppConfiguration.ConfigurationStoreArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppConfiguration.ConfigurationStoreArgs WithSku(this global::Pulumi.AzureNative.AppConfiguration.ConfigurationStoreArgs @selfRef, global::Pulumi.AzureNative.AppConfiguration.Inputs.SkuArgs sku)
    {
        @selfRef.Sku = sku;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppConfiguration.ConfigurationStoreArgs WithSku(this global::Pulumi.AzureNative.AppConfiguration.ConfigurationStoreArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AppConfiguration.Inputs.SkuArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AppConfiguration.Inputs.SkuArgs();
        @configure(@item);
        @selfRef.Sku = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppConfiguration.ConfigurationStoreArgs WithSoftDeleteRetentionInDays(this global::Pulumi.AzureNative.AppConfiguration.ConfigurationStoreArgs @selfRef, global::System.Int32 softDeleteRetentionInDays)
    {
        @selfRef.SoftDeleteRetentionInDays = softDeleteRetentionInDays;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppConfiguration.ConfigurationStoreArgs WithTags(this global::Pulumi.AzureNative.AppConfiguration.ConfigurationStoreArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppConfiguration.ConfigurationStoreArgs WithTags(this global::Pulumi.AzureNative.AppConfiguration.ConfigurationStoreArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppConfiguration.ConfigurationStoreArgs WithTags(this global::Pulumi.AzureNative.AppConfiguration.ConfigurationStoreArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
