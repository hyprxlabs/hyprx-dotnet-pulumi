// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class AwsDynamoDBTablePropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs WithArn(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs @selfRef, global::System.String arn)
    {
        @selfRef.Arn = arn;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs WithAttributeDefinitions(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.AttributeDefinitionArgs> attributeDefinitions)
    {
        @selfRef.AttributeDefinitions = attributeDefinitions;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs WithAttributeDefinitions(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.AttributeDefinitionArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.AttributeDefinitionArgs>();
        @configure(@list);
        @selfRef.AttributeDefinitions = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs WithAttributeDefinitions(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.AwsConnector.Inputs.AttributeDefinitionArgs>> @create)
    {
        @selfRef.AttributeDefinitions = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs WithBillingMode(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs @selfRef, global::System.String billingMode)
    {
        @selfRef.BillingMode = billingMode;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs WithContributorInsightsSpecification(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.ContributorInsightsSpecificationArgs contributorInsightsSpecification)
    {
        @selfRef.ContributorInsightsSpecification = contributorInsightsSpecification;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs WithContributorInsightsSpecification(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.ContributorInsightsSpecificationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.ContributorInsightsSpecificationArgs();
        @configure(@item);
        @selfRef.ContributorInsightsSpecification = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs WithDeletionProtectionEnabled(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs @selfRef, bool deletionProtectionEnabled = true)
    {
        @selfRef.DeletionProtectionEnabled = deletionProtectionEnabled;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs WithGlobalSecondaryIndexes(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.GlobalSecondaryIndexArgs> globalSecondaryIndexes)
    {
        @selfRef.GlobalSecondaryIndexes = globalSecondaryIndexes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs WithGlobalSecondaryIndexes(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.GlobalSecondaryIndexArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.GlobalSecondaryIndexArgs>();
        @configure(@list);
        @selfRef.GlobalSecondaryIndexes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs WithGlobalSecondaryIndexes(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.AwsConnector.Inputs.GlobalSecondaryIndexArgs>> @create)
    {
        @selfRef.GlobalSecondaryIndexes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs WithImportSourceSpecification(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.ImportSourceSpecificationArgs importSourceSpecification)
    {
        @selfRef.ImportSourceSpecification = importSourceSpecification;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs WithImportSourceSpecification(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.ImportSourceSpecificationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.ImportSourceSpecificationArgs();
        @configure(@item);
        @selfRef.ImportSourceSpecification = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs WithKeySchema(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.KeySchemaArgs> keySchema)
    {
        @selfRef.KeySchema = keySchema;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs WithKeySchema(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.KeySchemaArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.KeySchemaArgs>();
        @configure(@list);
        @selfRef.KeySchema = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs WithKeySchema(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.AwsConnector.Inputs.KeySchemaArgs>> @create)
    {
        @selfRef.KeySchema = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs WithKinesisStreamSpecification(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.KinesisStreamSpecificationArgs kinesisStreamSpecification)
    {
        @selfRef.KinesisStreamSpecification = kinesisStreamSpecification;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs WithKinesisStreamSpecification(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.KinesisStreamSpecificationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.KinesisStreamSpecificationArgs();
        @configure(@item);
        @selfRef.KinesisStreamSpecification = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs WithLocalSecondaryIndexes(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.LocalSecondaryIndexArgs> localSecondaryIndexes)
    {
        @selfRef.LocalSecondaryIndexes = localSecondaryIndexes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs WithLocalSecondaryIndexes(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.LocalSecondaryIndexArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.LocalSecondaryIndexArgs>();
        @configure(@list);
        @selfRef.LocalSecondaryIndexes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs WithLocalSecondaryIndexes(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.AwsConnector.Inputs.LocalSecondaryIndexArgs>> @create)
    {
        @selfRef.LocalSecondaryIndexes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs WithPointInTimeRecoverySpecification(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.PointInTimeRecoverySpecificationArgs pointInTimeRecoverySpecification)
    {
        @selfRef.PointInTimeRecoverySpecification = pointInTimeRecoverySpecification;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs WithPointInTimeRecoverySpecification(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.PointInTimeRecoverySpecificationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.PointInTimeRecoverySpecificationArgs();
        @configure(@item);
        @selfRef.PointInTimeRecoverySpecification = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs WithProvisionedThroughput(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.ProvisionedThroughputArgs provisionedThroughput)
    {
        @selfRef.ProvisionedThroughput = provisionedThroughput;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs WithProvisionedThroughput(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.ProvisionedThroughputArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.ProvisionedThroughputArgs();
        @configure(@item);
        @selfRef.ProvisionedThroughput = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs WithResourcePolicy(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.ResourcePolicyArgs resourcePolicy)
    {
        @selfRef.ResourcePolicy = resourcePolicy;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs WithResourcePolicy(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.ResourcePolicyArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.ResourcePolicyArgs();
        @configure(@item);
        @selfRef.ResourcePolicy = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs WithSseSpecification(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.SSESpecificationArgs sseSpecification)
    {
        @selfRef.SseSpecification = sseSpecification;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs WithSseSpecification(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.SSESpecificationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.SSESpecificationArgs();
        @configure(@item);
        @selfRef.SseSpecification = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs WithStreamArn(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs @selfRef, global::System.String streamArn)
    {
        @selfRef.StreamArn = streamArn;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs WithStreamSpecification(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.StreamSpecificationArgs streamSpecification)
    {
        @selfRef.StreamSpecification = streamSpecification;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs WithStreamSpecification(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.StreamSpecificationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.StreamSpecificationArgs();
        @configure(@item);
        @selfRef.StreamSpecification = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs WithTableClass(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs @selfRef, global::System.String tableClass)
    {
        @selfRef.TableClass = tableClass;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs WithTableName(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs @selfRef, global::System.String tableName)
    {
        @selfRef.TableName = tableName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs WithTags(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs WithTags(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs WithTags(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.AwsConnector.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs WithTimeToLiveSpecification(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.TimeToLiveSpecificationArgs timeToLiveSpecification)
    {
        @selfRef.TimeToLiveSpecification = timeToLiveSpecification;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs WithTimeToLiveSpecification(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDynamoDBTablePropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.TimeToLiveSpecificationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.TimeToLiveSpecificationArgs();
        @configure(@item);
        @selfRef.TimeToLiveSpecification = @item;
        return @selfRef;
    }

}
