// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Sns.Inputs;

namespace Pulumi.AwsNative.Sns;

public static partial class TopicSubscriptionArgsExtensions
{
    public static global::Pulumi.AwsNative.Sns.Inputs.TopicSubscriptionArgs WithEndpoint(this global::Pulumi.AwsNative.Sns.Inputs.TopicSubscriptionArgs @selfRef, global::System.String endpoint)
    {
        @selfRef.Endpoint = endpoint;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Sns.Inputs.TopicSubscriptionArgs WithProtocol(this global::Pulumi.AwsNative.Sns.Inputs.TopicSubscriptionArgs @selfRef, global::System.String protocol)
    {
        @selfRef.Protocol = protocol;
        return @selfRef;
    }

}
