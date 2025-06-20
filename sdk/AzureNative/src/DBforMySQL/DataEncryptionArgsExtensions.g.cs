// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DBforMySQL.Inputs;

namespace Pulumi.AzureNative.DBforMySQL;

public static partial class DataEncryptionArgsExtensions
{
    public static global::Pulumi.AzureNative.DBforMySQL.Inputs.DataEncryptionArgs WithGeoBackupKeyURI(this global::Pulumi.AzureNative.DBforMySQL.Inputs.DataEncryptionArgs @selfRef, global::System.String geoBackupKeyURI)
    {
        @selfRef.GeoBackupKeyURI = geoBackupKeyURI;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DBforMySQL.Inputs.DataEncryptionArgs WithGeoBackupUserAssignedIdentityId(this global::Pulumi.AzureNative.DBforMySQL.Inputs.DataEncryptionArgs @selfRef, global::System.String geoBackupUserAssignedIdentityId)
    {
        @selfRef.GeoBackupUserAssignedIdentityId = geoBackupUserAssignedIdentityId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DBforMySQL.Inputs.DataEncryptionArgs WithPrimaryKeyURI(this global::Pulumi.AzureNative.DBforMySQL.Inputs.DataEncryptionArgs @selfRef, global::System.String primaryKeyURI)
    {
        @selfRef.PrimaryKeyURI = primaryKeyURI;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DBforMySQL.Inputs.DataEncryptionArgs WithPrimaryUserAssignedIdentityId(this global::Pulumi.AzureNative.DBforMySQL.Inputs.DataEncryptionArgs @selfRef, global::System.String primaryUserAssignedIdentityId)
    {
        @selfRef.PrimaryUserAssignedIdentityId = primaryUserAssignedIdentityId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DBforMySQL.Inputs.DataEncryptionArgs WithType(this global::Pulumi.AzureNative.DBforMySQL.Inputs.DataEncryptionArgs @selfRef, global::Pulumi.AzureNative.DBforMySQL.DataEncryptionType type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DBforMySQL.Inputs.DataEncryptionArgs WithType(this global::Pulumi.AzureNative.DBforMySQL.Inputs.DataEncryptionArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DBforMySQL.DataEncryptionType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AzureNative.DBforMySQL.DataEncryptionType>();
        @configure(@item);
        @selfRef.Type = @item;
        return @selfRef;
    }

}
