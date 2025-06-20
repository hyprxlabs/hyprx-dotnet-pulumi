// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DBforPostgreSQL.Inputs;

namespace Pulumi.AzureNative.DBforPostgreSQL;

public static partial class ServerPropertiesForDefaultCreateArgsExtensions
{
    public static global::Pulumi.AzureNative.DBforPostgreSQL.Inputs.ServerPropertiesForDefaultCreateArgs WithAdministratorLogin(this global::Pulumi.AzureNative.DBforPostgreSQL.Inputs.ServerPropertiesForDefaultCreateArgs @selfRef, global::System.String administratorLogin)
    {
        @selfRef.AdministratorLogin = administratorLogin;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DBforPostgreSQL.Inputs.ServerPropertiesForDefaultCreateArgs WithAdministratorLoginPassword(this global::Pulumi.AzureNative.DBforPostgreSQL.Inputs.ServerPropertiesForDefaultCreateArgs @selfRef, global::System.String administratorLoginPassword)
    {
        @selfRef.AdministratorLoginPassword = administratorLoginPassword;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DBforPostgreSQL.Inputs.ServerPropertiesForDefaultCreateArgs WithCreateMode(this global::Pulumi.AzureNative.DBforPostgreSQL.Inputs.ServerPropertiesForDefaultCreateArgs @selfRef, global::System.String createMode)
    {
        @selfRef.CreateMode = createMode;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DBforPostgreSQL.Inputs.ServerPropertiesForDefaultCreateArgs WithInfrastructureEncryption(this global::Pulumi.AzureNative.DBforPostgreSQL.Inputs.ServerPropertiesForDefaultCreateArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.DBforPostgreSQL.InfrastructureEncryption> infrastructureEncryption)
    {
        @selfRef.InfrastructureEncryption = infrastructureEncryption;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DBforPostgreSQL.Inputs.ServerPropertiesForDefaultCreateArgs WithMinimalTlsVersion(this global::Pulumi.AzureNative.DBforPostgreSQL.Inputs.ServerPropertiesForDefaultCreateArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.DBforPostgreSQL.MinimalTlsVersionEnum> minimalTlsVersion)
    {
        @selfRef.MinimalTlsVersion = minimalTlsVersion;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DBforPostgreSQL.Inputs.ServerPropertiesForDefaultCreateArgs WithPublicNetworkAccess(this global::Pulumi.AzureNative.DBforPostgreSQL.Inputs.ServerPropertiesForDefaultCreateArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.DBforPostgreSQL.PublicNetworkAccessEnum> publicNetworkAccess)
    {
        @selfRef.PublicNetworkAccess = publicNetworkAccess;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DBforPostgreSQL.Inputs.ServerPropertiesForDefaultCreateArgs WithSslEnforcement(this global::Pulumi.AzureNative.DBforPostgreSQL.Inputs.ServerPropertiesForDefaultCreateArgs @selfRef, global::Pulumi.AzureNative.DBforPostgreSQL.SslEnforcementEnum sslEnforcement)
    {
        @selfRef.SslEnforcement = sslEnforcement;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DBforPostgreSQL.Inputs.ServerPropertiesForDefaultCreateArgs WithSslEnforcement(this global::Pulumi.AzureNative.DBforPostgreSQL.Inputs.ServerPropertiesForDefaultCreateArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DBforPostgreSQL.SslEnforcementEnum> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AzureNative.DBforPostgreSQL.SslEnforcementEnum>();
        @configure(@item);
        @selfRef.SslEnforcement = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DBforPostgreSQL.Inputs.ServerPropertiesForDefaultCreateArgs WithStorageProfile(this global::Pulumi.AzureNative.DBforPostgreSQL.Inputs.ServerPropertiesForDefaultCreateArgs @selfRef, global::Pulumi.AzureNative.DBforPostgreSQL.Inputs.StorageProfileArgs storageProfile)
    {
        @selfRef.StorageProfile = storageProfile;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DBforPostgreSQL.Inputs.ServerPropertiesForDefaultCreateArgs WithStorageProfile(this global::Pulumi.AzureNative.DBforPostgreSQL.Inputs.ServerPropertiesForDefaultCreateArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DBforPostgreSQL.Inputs.StorageProfileArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DBforPostgreSQL.Inputs.StorageProfileArgs();
        @configure(@item);
        @selfRef.StorageProfile = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DBforPostgreSQL.Inputs.ServerPropertiesForDefaultCreateArgs WithVersion(this global::Pulumi.AzureNative.DBforPostgreSQL.Inputs.ServerPropertiesForDefaultCreateArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.DBforPostgreSQL.SingleServerVersion> version)
    {
        @selfRef.Version = version;
        return @selfRef;
    }

}
