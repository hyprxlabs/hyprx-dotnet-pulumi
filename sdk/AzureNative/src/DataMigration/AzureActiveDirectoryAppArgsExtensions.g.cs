// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataMigration.Inputs;

namespace Pulumi.AzureNative.DataMigration;

public static partial class AzureActiveDirectoryAppArgsExtensions
{
    public static global::Pulumi.AzureNative.DataMigration.Inputs.AzureActiveDirectoryAppArgs WithAppKey(this global::Pulumi.AzureNative.DataMigration.Inputs.AzureActiveDirectoryAppArgs @selfRef, global::System.String appKey)
    {
        @selfRef.AppKey = appKey;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.Inputs.AzureActiveDirectoryAppArgs WithApplicationId(this global::Pulumi.AzureNative.DataMigration.Inputs.AzureActiveDirectoryAppArgs @selfRef, global::System.String applicationId)
    {
        @selfRef.ApplicationId = applicationId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.Inputs.AzureActiveDirectoryAppArgs WithIgnoreAzurePermissions(this global::Pulumi.AzureNative.DataMigration.Inputs.AzureActiveDirectoryAppArgs @selfRef, bool ignoreAzurePermissions = true)
    {
        @selfRef.IgnoreAzurePermissions = ignoreAzurePermissions;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.Inputs.AzureActiveDirectoryAppArgs WithTenantId(this global::Pulumi.AzureNative.DataMigration.Inputs.AzureActiveDirectoryAppArgs @selfRef, global::System.String tenantId)
    {
        @selfRef.TenantId = tenantId;
        return @selfRef;
    }

}
