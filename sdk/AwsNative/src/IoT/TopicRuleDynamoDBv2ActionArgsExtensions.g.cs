// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.IoT.Inputs;

namespace Pulumi.AwsNative.IoT;

public static partial class TopicRuleDynamoDBv2ActionArgsExtensions
{
    public static global::Pulumi.AwsNative.IoT.Inputs.TopicRuleDynamoDBv2ActionArgs WithPutItem(this global::Pulumi.AwsNative.IoT.Inputs.TopicRuleDynamoDBv2ActionArgs @selfRef, global::Pulumi.AwsNative.IoT.Inputs.TopicRulePutItemInputArgs putItem)
    {
        @selfRef.PutItem = putItem;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.Inputs.TopicRuleDynamoDBv2ActionArgs WithPutItem(this global::Pulumi.AwsNative.IoT.Inputs.TopicRuleDynamoDBv2ActionArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.IoT.Inputs.TopicRulePutItemInputArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.IoT.Inputs.TopicRulePutItemInputArgs();
        @configure(@item);
        @selfRef.PutItem = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.Inputs.TopicRuleDynamoDBv2ActionArgs WithRoleArn(this global::Pulumi.AwsNative.IoT.Inputs.TopicRuleDynamoDBv2ActionArgs @selfRef, global::System.String roleArn)
    {
        @selfRef.RoleArn = roleArn;
        return @selfRef;
    }

}
