// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.IoT.Inputs;

namespace Pulumi.AwsNative.IoT;

public static partial class TopicRuleKafkaActionArgsExtensions
{
    public static global::Pulumi.AwsNative.IoT.Inputs.TopicRuleKafkaActionArgs WithClientProperties(this global::Pulumi.AwsNative.IoT.Inputs.TopicRuleKafkaActionArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> clientProperties)
    {
        @selfRef.ClientProperties = clientProperties;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.Inputs.TopicRuleKafkaActionArgs WithClientProperties(this global::Pulumi.AwsNative.IoT.Inputs.TopicRuleKafkaActionArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.ClientProperties = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.Inputs.TopicRuleKafkaActionArgs WithClientProperties(this global::Pulumi.AwsNative.IoT.Inputs.TopicRuleKafkaActionArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.ClientProperties = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.Inputs.TopicRuleKafkaActionArgs WithDestinationArn(this global::Pulumi.AwsNative.IoT.Inputs.TopicRuleKafkaActionArgs @selfRef, global::System.String destinationArn)
    {
        @selfRef.DestinationArn = destinationArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.Inputs.TopicRuleKafkaActionArgs WithHeaders(this global::Pulumi.AwsNative.IoT.Inputs.TopicRuleKafkaActionArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.IoT.Inputs.TopicRuleKafkaActionHeaderArgs> headers)
    {
        @selfRef.Headers = headers;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.Inputs.TopicRuleKafkaActionArgs WithHeaders(this global::Pulumi.AwsNative.IoT.Inputs.TopicRuleKafkaActionArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.IoT.Inputs.TopicRuleKafkaActionHeaderArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.IoT.Inputs.TopicRuleKafkaActionHeaderArgs>();
        @configure(@list);
        @selfRef.Headers = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.Inputs.TopicRuleKafkaActionArgs WithHeaders(this global::Pulumi.AwsNative.IoT.Inputs.TopicRuleKafkaActionArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.IoT.Inputs.TopicRuleKafkaActionHeaderArgs>> @create)
    {
        @selfRef.Headers = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.Inputs.TopicRuleKafkaActionArgs WithKey(this global::Pulumi.AwsNative.IoT.Inputs.TopicRuleKafkaActionArgs @selfRef, global::System.String key)
    {
        @selfRef.Key = key;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.Inputs.TopicRuleKafkaActionArgs WithPartition(this global::Pulumi.AwsNative.IoT.Inputs.TopicRuleKafkaActionArgs @selfRef, global::System.String partition)
    {
        @selfRef.Partition = partition;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.Inputs.TopicRuleKafkaActionArgs WithTopic(this global::Pulumi.AwsNative.IoT.Inputs.TopicRuleKafkaActionArgs @selfRef, global::System.String topic)
    {
        @selfRef.Topic = topic;
        return @selfRef;
    }

}
