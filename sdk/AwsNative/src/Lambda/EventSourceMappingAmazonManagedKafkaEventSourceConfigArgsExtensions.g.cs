// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Lambda.Inputs;

namespace Pulumi.AwsNative.Lambda;

public static partial class EventSourceMappingAmazonManagedKafkaEventSourceConfigArgsExtensions
{
    public static global::Pulumi.AwsNative.Lambda.Inputs.EventSourceMappingAmazonManagedKafkaEventSourceConfigArgs WithConsumerGroupId(this global::Pulumi.AwsNative.Lambda.Inputs.EventSourceMappingAmazonManagedKafkaEventSourceConfigArgs @selfRef, global::System.String consumerGroupId)
    {
        @selfRef.ConsumerGroupId = consumerGroupId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lambda.Inputs.EventSourceMappingAmazonManagedKafkaEventSourceConfigArgs WithSchemaRegistryConfig(this global::Pulumi.AwsNative.Lambda.Inputs.EventSourceMappingAmazonManagedKafkaEventSourceConfigArgs @selfRef, global::Pulumi.AwsNative.Lambda.Inputs.EventSourceMappingSchemaRegistryConfigArgs schemaRegistryConfig)
    {
        @selfRef.SchemaRegistryConfig = schemaRegistryConfig;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lambda.Inputs.EventSourceMappingAmazonManagedKafkaEventSourceConfigArgs WithSchemaRegistryConfig(this global::Pulumi.AwsNative.Lambda.Inputs.EventSourceMappingAmazonManagedKafkaEventSourceConfigArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Lambda.Inputs.EventSourceMappingSchemaRegistryConfigArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Lambda.Inputs.EventSourceMappingSchemaRegistryConfigArgs();
        @configure(@item);
        @selfRef.SchemaRegistryConfig = @item;
        return @selfRef;
    }

}
