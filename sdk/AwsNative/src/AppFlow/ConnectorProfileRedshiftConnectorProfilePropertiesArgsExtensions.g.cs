// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.AppFlow.Inputs;

namespace Pulumi.AwsNative.AppFlow;

public static partial class ConnectorProfileRedshiftConnectorProfilePropertiesArgsExtensions
{
    public static global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfileRedshiftConnectorProfilePropertiesArgs WithBucketName(this global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfileRedshiftConnectorProfilePropertiesArgs @selfRef, global::System.String bucketName)
    {
        @selfRef.BucketName = bucketName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfileRedshiftConnectorProfilePropertiesArgs WithBucketPrefix(this global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfileRedshiftConnectorProfilePropertiesArgs @selfRef, global::System.String bucketPrefix)
    {
        @selfRef.BucketPrefix = bucketPrefix;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfileRedshiftConnectorProfilePropertiesArgs WithClusterIdentifier(this global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfileRedshiftConnectorProfilePropertiesArgs @selfRef, global::System.String clusterIdentifier)
    {
        @selfRef.ClusterIdentifier = clusterIdentifier;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfileRedshiftConnectorProfilePropertiesArgs WithDataApiRoleArn(this global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfileRedshiftConnectorProfilePropertiesArgs @selfRef, global::System.String dataApiRoleArn)
    {
        @selfRef.DataApiRoleArn = dataApiRoleArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfileRedshiftConnectorProfilePropertiesArgs WithDatabaseName(this global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfileRedshiftConnectorProfilePropertiesArgs @selfRef, global::System.String databaseName)
    {
        @selfRef.DatabaseName = databaseName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfileRedshiftConnectorProfilePropertiesArgs WithDatabaseUrl(this global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfileRedshiftConnectorProfilePropertiesArgs @selfRef, global::System.String databaseUrl)
    {
        @selfRef.DatabaseUrl = databaseUrl;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfileRedshiftConnectorProfilePropertiesArgs WithIsRedshiftServerless(this global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfileRedshiftConnectorProfilePropertiesArgs @selfRef, bool isRedshiftServerless = true)
    {
        @selfRef.IsRedshiftServerless = isRedshiftServerless;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfileRedshiftConnectorProfilePropertiesArgs WithRoleArn(this global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfileRedshiftConnectorProfilePropertiesArgs @selfRef, global::System.String roleArn)
    {
        @selfRef.RoleArn = roleArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfileRedshiftConnectorProfilePropertiesArgs WithWorkgroupName(this global::Pulumi.AwsNative.AppFlow.Inputs.ConnectorProfileRedshiftConnectorProfilePropertiesArgs @selfRef, global::System.String workgroupName)
    {
        @selfRef.WorkgroupName = workgroupName;
        return @selfRef;
    }

}
