// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.DynamoDb.Inputs;

namespace Pulumi.AwsNative.DynamoDb;

public static partial class GlobalTableReplicaGlobalSecondaryIndexSpecificationArgsExtensions
{
    public static global::Pulumi.AwsNative.DynamoDb.Inputs.GlobalTableReplicaGlobalSecondaryIndexSpecificationArgs WithContributorInsightsSpecification(this global::Pulumi.AwsNative.DynamoDb.Inputs.GlobalTableReplicaGlobalSecondaryIndexSpecificationArgs @selfRef, global::Pulumi.AwsNative.DynamoDb.Inputs.GlobalTableContributorInsightsSpecificationArgs contributorInsightsSpecification)
    {
        @selfRef.ContributorInsightsSpecification = contributorInsightsSpecification;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DynamoDb.Inputs.GlobalTableReplicaGlobalSecondaryIndexSpecificationArgs WithContributorInsightsSpecification(this global::Pulumi.AwsNative.DynamoDb.Inputs.GlobalTableReplicaGlobalSecondaryIndexSpecificationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.DynamoDb.Inputs.GlobalTableContributorInsightsSpecificationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.DynamoDb.Inputs.GlobalTableContributorInsightsSpecificationArgs();
        @configure(@item);
        @selfRef.ContributorInsightsSpecification = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DynamoDb.Inputs.GlobalTableReplicaGlobalSecondaryIndexSpecificationArgs WithIndexName(this global::Pulumi.AwsNative.DynamoDb.Inputs.GlobalTableReplicaGlobalSecondaryIndexSpecificationArgs @selfRef, global::System.String indexName)
    {
        @selfRef.IndexName = indexName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DynamoDb.Inputs.GlobalTableReplicaGlobalSecondaryIndexSpecificationArgs WithReadOnDemandThroughputSettings(this global::Pulumi.AwsNative.DynamoDb.Inputs.GlobalTableReplicaGlobalSecondaryIndexSpecificationArgs @selfRef, global::Pulumi.AwsNative.DynamoDb.Inputs.GlobalTableReadOnDemandThroughputSettingsArgs readOnDemandThroughputSettings)
    {
        @selfRef.ReadOnDemandThroughputSettings = readOnDemandThroughputSettings;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DynamoDb.Inputs.GlobalTableReplicaGlobalSecondaryIndexSpecificationArgs WithReadOnDemandThroughputSettings(this global::Pulumi.AwsNative.DynamoDb.Inputs.GlobalTableReplicaGlobalSecondaryIndexSpecificationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.DynamoDb.Inputs.GlobalTableReadOnDemandThroughputSettingsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.DynamoDb.Inputs.GlobalTableReadOnDemandThroughputSettingsArgs();
        @configure(@item);
        @selfRef.ReadOnDemandThroughputSettings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DynamoDb.Inputs.GlobalTableReplicaGlobalSecondaryIndexSpecificationArgs WithReadProvisionedThroughputSettings(this global::Pulumi.AwsNative.DynamoDb.Inputs.GlobalTableReplicaGlobalSecondaryIndexSpecificationArgs @selfRef, global::Pulumi.AwsNative.DynamoDb.Inputs.GlobalTableReadProvisionedThroughputSettingsArgs readProvisionedThroughputSettings)
    {
        @selfRef.ReadProvisionedThroughputSettings = readProvisionedThroughputSettings;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DynamoDb.Inputs.GlobalTableReplicaGlobalSecondaryIndexSpecificationArgs WithReadProvisionedThroughputSettings(this global::Pulumi.AwsNative.DynamoDb.Inputs.GlobalTableReplicaGlobalSecondaryIndexSpecificationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.DynamoDb.Inputs.GlobalTableReadProvisionedThroughputSettingsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.DynamoDb.Inputs.GlobalTableReadProvisionedThroughputSettingsArgs();
        @configure(@item);
        @selfRef.ReadProvisionedThroughputSettings = @item;
        return @selfRef;
    }

}
