// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.IoT.Inputs;

namespace Pulumi.AwsNative.IoT;

public static partial class TopicRuleKinesisActionArgsExtensions
{
    public static global::Pulumi.AwsNative.IoT.Inputs.TopicRuleKinesisActionArgs WithPartitionKey(this global::Pulumi.AwsNative.IoT.Inputs.TopicRuleKinesisActionArgs @selfRef, global::System.String partitionKey)
    {
        @selfRef.PartitionKey = partitionKey;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.Inputs.TopicRuleKinesisActionArgs WithRoleArn(this global::Pulumi.AwsNative.IoT.Inputs.TopicRuleKinesisActionArgs @selfRef, global::System.String roleArn)
    {
        @selfRef.RoleArn = roleArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.Inputs.TopicRuleKinesisActionArgs WithStreamName(this global::Pulumi.AwsNative.IoT.Inputs.TopicRuleKinesisActionArgs @selfRef, global::System.String streamName)
    {
        @selfRef.StreamName = streamName;
        return @selfRef;
    }

}
