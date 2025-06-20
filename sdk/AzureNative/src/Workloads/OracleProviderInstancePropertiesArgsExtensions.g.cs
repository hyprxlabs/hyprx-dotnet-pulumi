// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Workloads.Inputs;

namespace Pulumi.AzureNative.Workloads;

public static partial class OracleProviderInstancePropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.Workloads.Inputs.OracleProviderInstancePropertiesArgs WithDbName(this global::Pulumi.AzureNative.Workloads.Inputs.OracleProviderInstancePropertiesArgs @selfRef, global::System.String dbName)
    {
        @selfRef.DbName = dbName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Workloads.Inputs.OracleProviderInstancePropertiesArgs WithDbPassword(this global::Pulumi.AzureNative.Workloads.Inputs.OracleProviderInstancePropertiesArgs @selfRef, global::System.String dbPassword)
    {
        @selfRef.DbPassword = dbPassword;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Workloads.Inputs.OracleProviderInstancePropertiesArgs WithDbPasswordUri(this global::Pulumi.AzureNative.Workloads.Inputs.OracleProviderInstancePropertiesArgs @selfRef, global::System.String dbPasswordUri)
    {
        @selfRef.DbPasswordUri = dbPasswordUri;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Workloads.Inputs.OracleProviderInstancePropertiesArgs WithDbPort(this global::Pulumi.AzureNative.Workloads.Inputs.OracleProviderInstancePropertiesArgs @selfRef, global::System.String dbPort)
    {
        @selfRef.DbPort = dbPort;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Workloads.Inputs.OracleProviderInstancePropertiesArgs WithDbUsername(this global::Pulumi.AzureNative.Workloads.Inputs.OracleProviderInstancePropertiesArgs @selfRef, global::System.String dbUsername)
    {
        @selfRef.DbUsername = dbUsername;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Workloads.Inputs.OracleProviderInstancePropertiesArgs WithHostname(this global::Pulumi.AzureNative.Workloads.Inputs.OracleProviderInstancePropertiesArgs @selfRef, global::System.String hostname)
    {
        @selfRef.Hostname = hostname;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Workloads.Inputs.OracleProviderInstancePropertiesArgs WithProviderType(this global::Pulumi.AzureNative.Workloads.Inputs.OracleProviderInstancePropertiesArgs @selfRef, global::System.String providerType)
    {
        @selfRef.ProviderType = providerType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Workloads.Inputs.OracleProviderInstancePropertiesArgs WithSapSid(this global::Pulumi.AzureNative.Workloads.Inputs.OracleProviderInstancePropertiesArgs @selfRef, global::System.String sapSid)
    {
        @selfRef.SapSid = sapSid;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Workloads.Inputs.OracleProviderInstancePropertiesArgs WithSslCertificateUri(this global::Pulumi.AzureNative.Workloads.Inputs.OracleProviderInstancePropertiesArgs @selfRef, global::System.String sslCertificateUri)
    {
        @selfRef.SslCertificateUri = sslCertificateUri;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Workloads.Inputs.OracleProviderInstancePropertiesArgs WithSslPreference(this global::Pulumi.AzureNative.Workloads.Inputs.OracleProviderInstancePropertiesArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Workloads.SslPreference> sslPreference)
    {
        @selfRef.SslPreference = sslPreference;
        return @selfRef;
    }

}
