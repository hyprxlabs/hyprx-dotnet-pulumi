// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.StorageCache;

public static partial class CacheArgsExtensions
{
    public static global::Pulumi.AzureNative.StorageCache.CacheArgs WithCacheName(this global::Pulumi.AzureNative.StorageCache.CacheArgs @selfRef, global::System.String cacheName)
    {
        @selfRef.CacheName = cacheName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorageCache.CacheArgs WithCacheSizeGB(this global::Pulumi.AzureNative.StorageCache.CacheArgs @selfRef, global::System.Int32 cacheSizeGB)
    {
        @selfRef.CacheSizeGB = cacheSizeGB;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorageCache.CacheArgs WithDirectoryServicesSettings(this global::Pulumi.AzureNative.StorageCache.CacheArgs @selfRef, global::Pulumi.AzureNative.StorageCache.Inputs.CacheDirectorySettingsArgs directoryServicesSettings)
    {
        @selfRef.DirectoryServicesSettings = directoryServicesSettings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorageCache.CacheArgs WithDirectoryServicesSettings(this global::Pulumi.AzureNative.StorageCache.CacheArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.StorageCache.Inputs.CacheDirectorySettingsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.StorageCache.Inputs.CacheDirectorySettingsArgs();
        @configure(@item);
        @selfRef.DirectoryServicesSettings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorageCache.CacheArgs WithEncryptionSettings(this global::Pulumi.AzureNative.StorageCache.CacheArgs @selfRef, global::Pulumi.AzureNative.StorageCache.Inputs.CacheEncryptionSettingsArgs encryptionSettings)
    {
        @selfRef.EncryptionSettings = encryptionSettings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorageCache.CacheArgs WithEncryptionSettings(this global::Pulumi.AzureNative.StorageCache.CacheArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.StorageCache.Inputs.CacheEncryptionSettingsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.StorageCache.Inputs.CacheEncryptionSettingsArgs();
        @configure(@item);
        @selfRef.EncryptionSettings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorageCache.CacheArgs WithIdentity(this global::Pulumi.AzureNative.StorageCache.CacheArgs @selfRef, global::Pulumi.AzureNative.StorageCache.Inputs.CacheIdentityArgs identity)
    {
        @selfRef.Identity = identity;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorageCache.CacheArgs WithIdentity(this global::Pulumi.AzureNative.StorageCache.CacheArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.StorageCache.Inputs.CacheIdentityArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.StorageCache.Inputs.CacheIdentityArgs();
        @configure(@item);
        @selfRef.Identity = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorageCache.CacheArgs WithLocation(this global::Pulumi.AzureNative.StorageCache.CacheArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorageCache.CacheArgs WithNetworkSettings(this global::Pulumi.AzureNative.StorageCache.CacheArgs @selfRef, global::Pulumi.AzureNative.StorageCache.Inputs.CacheNetworkSettingsArgs networkSettings)
    {
        @selfRef.NetworkSettings = networkSettings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorageCache.CacheArgs WithNetworkSettings(this global::Pulumi.AzureNative.StorageCache.CacheArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.StorageCache.Inputs.CacheNetworkSettingsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.StorageCache.Inputs.CacheNetworkSettingsArgs();
        @configure(@item);
        @selfRef.NetworkSettings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorageCache.CacheArgs WithResourceGroupName(this global::Pulumi.AzureNative.StorageCache.CacheArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorageCache.CacheArgs WithSecuritySettings(this global::Pulumi.AzureNative.StorageCache.CacheArgs @selfRef, global::Pulumi.AzureNative.StorageCache.Inputs.CacheSecuritySettingsArgs securitySettings)
    {
        @selfRef.SecuritySettings = securitySettings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorageCache.CacheArgs WithSecuritySettings(this global::Pulumi.AzureNative.StorageCache.CacheArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.StorageCache.Inputs.CacheSecuritySettingsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.StorageCache.Inputs.CacheSecuritySettingsArgs();
        @configure(@item);
        @selfRef.SecuritySettings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorageCache.CacheArgs WithSku(this global::Pulumi.AzureNative.StorageCache.CacheArgs @selfRef, global::Pulumi.AzureNative.StorageCache.Inputs.CacheSkuArgs sku)
    {
        @selfRef.Sku = sku;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorageCache.CacheArgs WithSku(this global::Pulumi.AzureNative.StorageCache.CacheArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.StorageCache.Inputs.CacheSkuArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.StorageCache.Inputs.CacheSkuArgs();
        @configure(@item);
        @selfRef.Sku = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorageCache.CacheArgs WithSubnet(this global::Pulumi.AzureNative.StorageCache.CacheArgs @selfRef, global::System.String subnet)
    {
        @selfRef.Subnet = subnet;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorageCache.CacheArgs WithTags(this global::Pulumi.AzureNative.StorageCache.CacheArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorageCache.CacheArgs WithTags(this global::Pulumi.AzureNative.StorageCache.CacheArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorageCache.CacheArgs WithTags(this global::Pulumi.AzureNative.StorageCache.CacheArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorageCache.CacheArgs WithUpgradeSettings(this global::Pulumi.AzureNative.StorageCache.CacheArgs @selfRef, global::Pulumi.AzureNative.StorageCache.Inputs.CacheUpgradeSettingsArgs upgradeSettings)
    {
        @selfRef.UpgradeSettings = upgradeSettings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorageCache.CacheArgs WithUpgradeSettings(this global::Pulumi.AzureNative.StorageCache.CacheArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.StorageCache.Inputs.CacheUpgradeSettingsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.StorageCache.Inputs.CacheUpgradeSettingsArgs();
        @configure(@item);
        @selfRef.UpgradeSettings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorageCache.CacheArgs WithZones(this global::Pulumi.AzureNative.StorageCache.CacheArgs @selfRef, global::System.Collections.Generic.List<global::System.String> zones)
    {
        @selfRef.Zones = zones;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorageCache.CacheArgs WithZones(this global::Pulumi.AzureNative.StorageCache.CacheArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Zones = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorageCache.CacheArgs WithZones(this global::Pulumi.AzureNative.StorageCache.CacheArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Zones = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
