// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs;

namespace Pulumi.AwsNative.ElasticLoadBalancingV2;

public static partial class ListenerRuleFixedResponseConfigArgsExtensions
{
    public static global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerRuleFixedResponseConfigArgs WithContentType(this global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerRuleFixedResponseConfigArgs @selfRef, global::System.String contentType)
    {
        @selfRef.ContentType = contentType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerRuleFixedResponseConfigArgs WithMessageBody(this global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerRuleFixedResponseConfigArgs @selfRef, global::System.String messageBody)
    {
        @selfRef.MessageBody = messageBody;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerRuleFixedResponseConfigArgs WithStatusCode(this global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerRuleFixedResponseConfigArgs @selfRef, global::System.String statusCode)
    {
        @selfRef.StatusCode = statusCode;
        return @selfRef;
    }

}
