// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.AppSync.Inputs;

namespace Pulumi.AwsNative.AppSync;

public static partial class DataSourceRdsHttpEndpointConfigArgsExtensions
{
    public static global::Pulumi.AwsNative.AppSync.Inputs.DataSourceRdsHttpEndpointConfigArgs WithAwsRegion(this global::Pulumi.AwsNative.AppSync.Inputs.DataSourceRdsHttpEndpointConfigArgs @selfRef, global::System.String awsRegion)
    {
        @selfRef.AwsRegion = awsRegion;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppSync.Inputs.DataSourceRdsHttpEndpointConfigArgs WithAwsSecretStoreArn(this global::Pulumi.AwsNative.AppSync.Inputs.DataSourceRdsHttpEndpointConfigArgs @selfRef, global::System.String awsSecretStoreArn)
    {
        @selfRef.AwsSecretStoreArn = awsSecretStoreArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppSync.Inputs.DataSourceRdsHttpEndpointConfigArgs WithDatabaseName(this global::Pulumi.AwsNative.AppSync.Inputs.DataSourceRdsHttpEndpointConfigArgs @selfRef, global::System.String databaseName)
    {
        @selfRef.DatabaseName = databaseName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppSync.Inputs.DataSourceRdsHttpEndpointConfigArgs WithDbClusterIdentifier(this global::Pulumi.AwsNative.AppSync.Inputs.DataSourceRdsHttpEndpointConfigArgs @selfRef, global::System.String dbClusterIdentifier)
    {
        @selfRef.DbClusterIdentifier = dbClusterIdentifier;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppSync.Inputs.DataSourceRdsHttpEndpointConfigArgs WithSchema(this global::Pulumi.AwsNative.AppSync.Inputs.DataSourceRdsHttpEndpointConfigArgs @selfRef, global::System.String schema)
    {
        @selfRef.Schema = schema;
        return @selfRef;
    }

}
