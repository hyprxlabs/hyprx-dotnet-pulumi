// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.DynamoDb;

public static partial class TableArgsExtensions
{
    public static global::Pulumi.AwsNative.DynamoDb.TableArgs WithAttributeDefinitions(this global::Pulumi.AwsNative.DynamoDb.TableArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.DynamoDb.Inputs.TableAttributeDefinitionArgs> attributeDefinitions)
    {
        @selfRef.AttributeDefinitions = attributeDefinitions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DynamoDb.TableArgs WithAttributeDefinitions(this global::Pulumi.AwsNative.DynamoDb.TableArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.DynamoDb.Inputs.TableAttributeDefinitionArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.DynamoDb.Inputs.TableAttributeDefinitionArgs>();
        @configure(@list);
        @selfRef.AttributeDefinitions = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DynamoDb.TableArgs WithAttributeDefinitions(this global::Pulumi.AwsNative.DynamoDb.TableArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.DynamoDb.Inputs.TableAttributeDefinitionArgs>> @create)
    {
        @selfRef.AttributeDefinitions = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DynamoDb.TableArgs WithBillingMode(this global::Pulumi.AwsNative.DynamoDb.TableArgs @selfRef, global::System.String billingMode)
    {
        @selfRef.BillingMode = billingMode;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DynamoDb.TableArgs WithContributorInsightsSpecification(this global::Pulumi.AwsNative.DynamoDb.TableArgs @selfRef, global::Pulumi.AwsNative.DynamoDb.Inputs.TableContributorInsightsSpecificationArgs contributorInsightsSpecification)
    {
        @selfRef.ContributorInsightsSpecification = contributorInsightsSpecification;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DynamoDb.TableArgs WithContributorInsightsSpecification(this global::Pulumi.AwsNative.DynamoDb.TableArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.DynamoDb.Inputs.TableContributorInsightsSpecificationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.DynamoDb.Inputs.TableContributorInsightsSpecificationArgs();
        @configure(@item);
        @selfRef.ContributorInsightsSpecification = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DynamoDb.TableArgs WithDeletionProtectionEnabled(this global::Pulumi.AwsNative.DynamoDb.TableArgs @selfRef, bool deletionProtectionEnabled = true)
    {
        @selfRef.DeletionProtectionEnabled = deletionProtectionEnabled;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DynamoDb.TableArgs WithGlobalSecondaryIndexes(this global::Pulumi.AwsNative.DynamoDb.TableArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.DynamoDb.Inputs.TableGlobalSecondaryIndexArgs> globalSecondaryIndexes)
    {
        @selfRef.GlobalSecondaryIndexes = globalSecondaryIndexes;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DynamoDb.TableArgs WithGlobalSecondaryIndexes(this global::Pulumi.AwsNative.DynamoDb.TableArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.DynamoDb.Inputs.TableGlobalSecondaryIndexArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.DynamoDb.Inputs.TableGlobalSecondaryIndexArgs>();
        @configure(@list);
        @selfRef.GlobalSecondaryIndexes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DynamoDb.TableArgs WithGlobalSecondaryIndexes(this global::Pulumi.AwsNative.DynamoDb.TableArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.DynamoDb.Inputs.TableGlobalSecondaryIndexArgs>> @create)
    {
        @selfRef.GlobalSecondaryIndexes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DynamoDb.TableArgs WithImportSourceSpecification(this global::Pulumi.AwsNative.DynamoDb.TableArgs @selfRef, global::Pulumi.AwsNative.DynamoDb.Inputs.TableImportSourceSpecificationArgs importSourceSpecification)
    {
        @selfRef.ImportSourceSpecification = importSourceSpecification;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DynamoDb.TableArgs WithImportSourceSpecification(this global::Pulumi.AwsNative.DynamoDb.TableArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.DynamoDb.Inputs.TableImportSourceSpecificationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.DynamoDb.Inputs.TableImportSourceSpecificationArgs();
        @configure(@item);
        @selfRef.ImportSourceSpecification = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DynamoDb.TableArgs WithKeySchema(this global::Pulumi.AwsNative.DynamoDb.TableArgs @selfRef, global::Pulumi.Union<global::System.Collections.Immutable.ImmutableArray<global::Pulumi.AwsNative.DynamoDb.Inputs.TableKeySchemaArgs>, global::System.Object> keySchema)
    {
        @selfRef.KeySchema = keySchema;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DynamoDb.TableArgs WithKinesisStreamSpecification(this global::Pulumi.AwsNative.DynamoDb.TableArgs @selfRef, global::Pulumi.AwsNative.DynamoDb.Inputs.TableKinesisStreamSpecificationArgs kinesisStreamSpecification)
    {
        @selfRef.KinesisStreamSpecification = kinesisStreamSpecification;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DynamoDb.TableArgs WithKinesisStreamSpecification(this global::Pulumi.AwsNative.DynamoDb.TableArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.DynamoDb.Inputs.TableKinesisStreamSpecificationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.DynamoDb.Inputs.TableKinesisStreamSpecificationArgs();
        @configure(@item);
        @selfRef.KinesisStreamSpecification = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DynamoDb.TableArgs WithLocalSecondaryIndexes(this global::Pulumi.AwsNative.DynamoDb.TableArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.DynamoDb.Inputs.TableLocalSecondaryIndexArgs> localSecondaryIndexes)
    {
        @selfRef.LocalSecondaryIndexes = localSecondaryIndexes;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DynamoDb.TableArgs WithLocalSecondaryIndexes(this global::Pulumi.AwsNative.DynamoDb.TableArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.DynamoDb.Inputs.TableLocalSecondaryIndexArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.DynamoDb.Inputs.TableLocalSecondaryIndexArgs>();
        @configure(@list);
        @selfRef.LocalSecondaryIndexes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DynamoDb.TableArgs WithLocalSecondaryIndexes(this global::Pulumi.AwsNative.DynamoDb.TableArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.DynamoDb.Inputs.TableLocalSecondaryIndexArgs>> @create)
    {
        @selfRef.LocalSecondaryIndexes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DynamoDb.TableArgs WithOnDemandThroughput(this global::Pulumi.AwsNative.DynamoDb.TableArgs @selfRef, global::Pulumi.AwsNative.DynamoDb.Inputs.TableOnDemandThroughputArgs onDemandThroughput)
    {
        @selfRef.OnDemandThroughput = onDemandThroughput;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DynamoDb.TableArgs WithOnDemandThroughput(this global::Pulumi.AwsNative.DynamoDb.TableArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.DynamoDb.Inputs.TableOnDemandThroughputArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.DynamoDb.Inputs.TableOnDemandThroughputArgs();
        @configure(@item);
        @selfRef.OnDemandThroughput = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DynamoDb.TableArgs WithPointInTimeRecoverySpecification(this global::Pulumi.AwsNative.DynamoDb.TableArgs @selfRef, global::Pulumi.AwsNative.DynamoDb.Inputs.TablePointInTimeRecoverySpecificationArgs pointInTimeRecoverySpecification)
    {
        @selfRef.PointInTimeRecoverySpecification = pointInTimeRecoverySpecification;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DynamoDb.TableArgs WithPointInTimeRecoverySpecification(this global::Pulumi.AwsNative.DynamoDb.TableArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.DynamoDb.Inputs.TablePointInTimeRecoverySpecificationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.DynamoDb.Inputs.TablePointInTimeRecoverySpecificationArgs();
        @configure(@item);
        @selfRef.PointInTimeRecoverySpecification = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DynamoDb.TableArgs WithProvisionedThroughput(this global::Pulumi.AwsNative.DynamoDb.TableArgs @selfRef, global::Pulumi.AwsNative.DynamoDb.Inputs.TableProvisionedThroughputArgs provisionedThroughput)
    {
        @selfRef.ProvisionedThroughput = provisionedThroughput;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DynamoDb.TableArgs WithProvisionedThroughput(this global::Pulumi.AwsNative.DynamoDb.TableArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.DynamoDb.Inputs.TableProvisionedThroughputArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.DynamoDb.Inputs.TableProvisionedThroughputArgs();
        @configure(@item);
        @selfRef.ProvisionedThroughput = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DynamoDb.TableArgs WithResourcePolicy(this global::Pulumi.AwsNative.DynamoDb.TableArgs @selfRef, global::Pulumi.AwsNative.DynamoDb.Inputs.TableResourcePolicyArgs resourcePolicy)
    {
        @selfRef.ResourcePolicy = resourcePolicy;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DynamoDb.TableArgs WithResourcePolicy(this global::Pulumi.AwsNative.DynamoDb.TableArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.DynamoDb.Inputs.TableResourcePolicyArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.DynamoDb.Inputs.TableResourcePolicyArgs();
        @configure(@item);
        @selfRef.ResourcePolicy = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DynamoDb.TableArgs WithSseSpecification(this global::Pulumi.AwsNative.DynamoDb.TableArgs @selfRef, global::Pulumi.AwsNative.DynamoDb.Inputs.TableSseSpecificationArgs sseSpecification)
    {
        @selfRef.SseSpecification = sseSpecification;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DynamoDb.TableArgs WithSseSpecification(this global::Pulumi.AwsNative.DynamoDb.TableArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.DynamoDb.Inputs.TableSseSpecificationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.DynamoDb.Inputs.TableSseSpecificationArgs();
        @configure(@item);
        @selfRef.SseSpecification = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DynamoDb.TableArgs WithStreamSpecification(this global::Pulumi.AwsNative.DynamoDb.TableArgs @selfRef, global::Pulumi.AwsNative.DynamoDb.Inputs.TableStreamSpecificationArgs streamSpecification)
    {
        @selfRef.StreamSpecification = streamSpecification;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DynamoDb.TableArgs WithStreamSpecification(this global::Pulumi.AwsNative.DynamoDb.TableArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.DynamoDb.Inputs.TableStreamSpecificationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.DynamoDb.Inputs.TableStreamSpecificationArgs();
        @configure(@item);
        @selfRef.StreamSpecification = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DynamoDb.TableArgs WithTableClass(this global::Pulumi.AwsNative.DynamoDb.TableArgs @selfRef, global::System.String tableClass)
    {
        @selfRef.TableClass = tableClass;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DynamoDb.TableArgs WithTableName(this global::Pulumi.AwsNative.DynamoDb.TableArgs @selfRef, global::System.String tableName)
    {
        @selfRef.TableName = tableName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DynamoDb.TableArgs WithTags(this global::Pulumi.AwsNative.DynamoDb.TableArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DynamoDb.TableArgs WithTags(this global::Pulumi.AwsNative.DynamoDb.TableArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DynamoDb.TableArgs WithTags(this global::Pulumi.AwsNative.DynamoDb.TableArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DynamoDb.TableArgs WithTimeToLiveSpecification(this global::Pulumi.AwsNative.DynamoDb.TableArgs @selfRef, global::Pulumi.AwsNative.DynamoDb.Inputs.TableTimeToLiveSpecificationArgs timeToLiveSpecification)
    {
        @selfRef.TimeToLiveSpecification = timeToLiveSpecification;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DynamoDb.TableArgs WithTimeToLiveSpecification(this global::Pulumi.AwsNative.DynamoDb.TableArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.DynamoDb.Inputs.TableTimeToLiveSpecificationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.DynamoDb.Inputs.TableTimeToLiveSpecificationArgs();
        @configure(@item);
        @selfRef.TimeToLiveSpecification = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DynamoDb.TableArgs WithWarmThroughput(this global::Pulumi.AwsNative.DynamoDb.TableArgs @selfRef, global::Pulumi.AwsNative.DynamoDb.Inputs.TableWarmThroughputArgs warmThroughput)
    {
        @selfRef.WarmThroughput = warmThroughput;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DynamoDb.TableArgs WithWarmThroughput(this global::Pulumi.AwsNative.DynamoDb.TableArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.DynamoDb.Inputs.TableWarmThroughputArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.DynamoDb.Inputs.TableWarmThroughputArgs();
        @configure(@item);
        @selfRef.WarmThroughput = @item;
        return @selfRef;
    }

}
