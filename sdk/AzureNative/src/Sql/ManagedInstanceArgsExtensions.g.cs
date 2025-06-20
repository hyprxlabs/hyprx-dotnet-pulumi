// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Sql;

public static partial class ManagedInstanceArgsExtensions
{
    public static global::Pulumi.AzureNative.Sql.ManagedInstanceArgs WithAdministratorLogin(this global::Pulumi.AzureNative.Sql.ManagedInstanceArgs @selfRef, global::System.String administratorLogin)
    {
        @selfRef.AdministratorLogin = administratorLogin;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.ManagedInstanceArgs WithAdministratorLoginPassword(this global::Pulumi.AzureNative.Sql.ManagedInstanceArgs @selfRef, global::System.String administratorLoginPassword)
    {
        @selfRef.AdministratorLoginPassword = administratorLoginPassword;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.ManagedInstanceArgs WithAdministrators(this global::Pulumi.AzureNative.Sql.ManagedInstanceArgs @selfRef, global::Pulumi.AzureNative.Sql.Inputs.ManagedInstanceExternalAdministratorArgs administrators)
    {
        @selfRef.Administrators = administrators;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.ManagedInstanceArgs WithAdministrators(this global::Pulumi.AzureNative.Sql.ManagedInstanceArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Sql.Inputs.ManagedInstanceExternalAdministratorArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Sql.Inputs.ManagedInstanceExternalAdministratorArgs();
        @configure(@item);
        @selfRef.Administrators = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.ManagedInstanceArgs WithAuthenticationMetadata(this global::Pulumi.AzureNative.Sql.ManagedInstanceArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Sql.AuthMetadataLookupModes> authenticationMetadata)
    {
        @selfRef.AuthenticationMetadata = authenticationMetadata;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.ManagedInstanceArgs WithCollation(this global::Pulumi.AzureNative.Sql.ManagedInstanceArgs @selfRef, global::System.String collation)
    {
        @selfRef.Collation = collation;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.ManagedInstanceArgs WithDatabaseFormat(this global::Pulumi.AzureNative.Sql.ManagedInstanceArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Sql.ManagedInstanceDatabaseFormat> databaseFormat)
    {
        @selfRef.DatabaseFormat = databaseFormat;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.ManagedInstanceArgs WithDnsZonePartner(this global::Pulumi.AzureNative.Sql.ManagedInstanceArgs @selfRef, global::System.String dnsZonePartner)
    {
        @selfRef.DnsZonePartner = dnsZonePartner;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.ManagedInstanceArgs WithHybridSecondaryUsage(this global::Pulumi.AzureNative.Sql.ManagedInstanceArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Sql.HybridSecondaryUsage> hybridSecondaryUsage)
    {
        @selfRef.HybridSecondaryUsage = hybridSecondaryUsage;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.ManagedInstanceArgs WithIdentity(this global::Pulumi.AzureNative.Sql.ManagedInstanceArgs @selfRef, global::Pulumi.AzureNative.Sql.Inputs.ResourceIdentityArgs identity)
    {
        @selfRef.Identity = identity;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.ManagedInstanceArgs WithIdentity(this global::Pulumi.AzureNative.Sql.ManagedInstanceArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Sql.Inputs.ResourceIdentityArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Sql.Inputs.ResourceIdentityArgs();
        @configure(@item);
        @selfRef.Identity = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.ManagedInstanceArgs WithInstancePoolId(this global::Pulumi.AzureNative.Sql.ManagedInstanceArgs @selfRef, global::System.String instancePoolId)
    {
        @selfRef.InstancePoolId = instancePoolId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.ManagedInstanceArgs WithIsGeneralPurposeV2(this global::Pulumi.AzureNative.Sql.ManagedInstanceArgs @selfRef, bool isGeneralPurposeV2 = true)
    {
        @selfRef.IsGeneralPurposeV2 = isGeneralPurposeV2;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.ManagedInstanceArgs WithKeyId(this global::Pulumi.AzureNative.Sql.ManagedInstanceArgs @selfRef, global::System.String keyId)
    {
        @selfRef.KeyId = keyId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.ManagedInstanceArgs WithLicenseType(this global::Pulumi.AzureNative.Sql.ManagedInstanceArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Sql.ManagedInstanceLicenseType> licenseType)
    {
        @selfRef.LicenseType = licenseType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.ManagedInstanceArgs WithLocation(this global::Pulumi.AzureNative.Sql.ManagedInstanceArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.ManagedInstanceArgs WithMaintenanceConfigurationId(this global::Pulumi.AzureNative.Sql.ManagedInstanceArgs @selfRef, global::System.String maintenanceConfigurationId)
    {
        @selfRef.MaintenanceConfigurationId = maintenanceConfigurationId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.ManagedInstanceArgs WithManagedInstanceCreateMode(this global::Pulumi.AzureNative.Sql.ManagedInstanceArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Sql.ManagedServerCreateMode> managedInstanceCreateMode)
    {
        @selfRef.ManagedInstanceCreateMode = managedInstanceCreateMode;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.ManagedInstanceArgs WithManagedInstanceName(this global::Pulumi.AzureNative.Sql.ManagedInstanceArgs @selfRef, global::System.String managedInstanceName)
    {
        @selfRef.ManagedInstanceName = managedInstanceName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.ManagedInstanceArgs WithMinimalTlsVersion(this global::Pulumi.AzureNative.Sql.ManagedInstanceArgs @selfRef, global::System.String minimalTlsVersion)
    {
        @selfRef.MinimalTlsVersion = minimalTlsVersion;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.ManagedInstanceArgs WithPricingModel(this global::Pulumi.AzureNative.Sql.ManagedInstanceArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Sql.PricingModel> pricingModel)
    {
        @selfRef.PricingModel = pricingModel;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.ManagedInstanceArgs WithPrimaryUserAssignedIdentityId(this global::Pulumi.AzureNative.Sql.ManagedInstanceArgs @selfRef, global::System.String primaryUserAssignedIdentityId)
    {
        @selfRef.PrimaryUserAssignedIdentityId = primaryUserAssignedIdentityId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.ManagedInstanceArgs WithProxyOverride(this global::Pulumi.AzureNative.Sql.ManagedInstanceArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Sql.ManagedInstanceProxyOverride> proxyOverride)
    {
        @selfRef.ProxyOverride = proxyOverride;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.ManagedInstanceArgs WithPublicDataEndpointEnabled(this global::Pulumi.AzureNative.Sql.ManagedInstanceArgs @selfRef, bool publicDataEndpointEnabled = true)
    {
        @selfRef.PublicDataEndpointEnabled = publicDataEndpointEnabled;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.ManagedInstanceArgs WithRequestedBackupStorageRedundancy(this global::Pulumi.AzureNative.Sql.ManagedInstanceArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Sql.BackupStorageRedundancy> requestedBackupStorageRedundancy)
    {
        @selfRef.RequestedBackupStorageRedundancy = requestedBackupStorageRedundancy;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.ManagedInstanceArgs WithResourceGroupName(this global::Pulumi.AzureNative.Sql.ManagedInstanceArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.ManagedInstanceArgs WithRestorePointInTime(this global::Pulumi.AzureNative.Sql.ManagedInstanceArgs @selfRef, global::System.String restorePointInTime)
    {
        @selfRef.RestorePointInTime = restorePointInTime;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.ManagedInstanceArgs WithServicePrincipal(this global::Pulumi.AzureNative.Sql.ManagedInstanceArgs @selfRef, global::Pulumi.AzureNative.Sql.Inputs.ServicePrincipalArgs servicePrincipal)
    {
        @selfRef.ServicePrincipal = servicePrincipal;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.ManagedInstanceArgs WithServicePrincipal(this global::Pulumi.AzureNative.Sql.ManagedInstanceArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Sql.Inputs.ServicePrincipalArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Sql.Inputs.ServicePrincipalArgs();
        @configure(@item);
        @selfRef.ServicePrincipal = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.ManagedInstanceArgs WithSku(this global::Pulumi.AzureNative.Sql.ManagedInstanceArgs @selfRef, global::Pulumi.AzureNative.Sql.Inputs.SkuArgs sku)
    {
        @selfRef.Sku = sku;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.ManagedInstanceArgs WithSku(this global::Pulumi.AzureNative.Sql.ManagedInstanceArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Sql.Inputs.SkuArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Sql.Inputs.SkuArgs();
        @configure(@item);
        @selfRef.Sku = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.ManagedInstanceArgs WithSourceManagedInstanceId(this global::Pulumi.AzureNative.Sql.ManagedInstanceArgs @selfRef, global::System.String sourceManagedInstanceId)
    {
        @selfRef.SourceManagedInstanceId = sourceManagedInstanceId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.ManagedInstanceArgs WithStorageIOps(this global::Pulumi.AzureNative.Sql.ManagedInstanceArgs @selfRef, global::System.Int32 storageIOps)
    {
        @selfRef.StorageIOps = storageIOps;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.ManagedInstanceArgs WithStorageSizeInGB(this global::Pulumi.AzureNative.Sql.ManagedInstanceArgs @selfRef, global::System.Int32 storageSizeInGB)
    {
        @selfRef.StorageSizeInGB = storageSizeInGB;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.ManagedInstanceArgs WithStorageThroughputMBps(this global::Pulumi.AzureNative.Sql.ManagedInstanceArgs @selfRef, global::System.Int32 storageThroughputMBps)
    {
        @selfRef.StorageThroughputMBps = storageThroughputMBps;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.ManagedInstanceArgs WithSubnetId(this global::Pulumi.AzureNative.Sql.ManagedInstanceArgs @selfRef, global::System.String subnetId)
    {
        @selfRef.SubnetId = subnetId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.ManagedInstanceArgs WithTags(this global::Pulumi.AzureNative.Sql.ManagedInstanceArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.ManagedInstanceArgs WithTags(this global::Pulumi.AzureNative.Sql.ManagedInstanceArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.ManagedInstanceArgs WithTags(this global::Pulumi.AzureNative.Sql.ManagedInstanceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.ManagedInstanceArgs WithTimezoneId(this global::Pulumi.AzureNative.Sql.ManagedInstanceArgs @selfRef, global::System.String timezoneId)
    {
        @selfRef.TimezoneId = timezoneId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.ManagedInstanceArgs WithVCores(this global::Pulumi.AzureNative.Sql.ManagedInstanceArgs @selfRef, global::System.Int32 vCores)
    {
        @selfRef.VCores = vCores;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.ManagedInstanceArgs WithZoneRedundant(this global::Pulumi.AzureNative.Sql.ManagedInstanceArgs @selfRef, bool zoneRedundant = true)
    {
        @selfRef.ZoneRedundant = zoneRedundant;
        return @selfRef;
    }

}
