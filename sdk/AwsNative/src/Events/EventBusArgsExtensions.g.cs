// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Events;

public static partial class EventBusArgsExtensions
{
    public static global::Pulumi.AwsNative.Events.EventBusArgs WithDeadLetterConfig(this global::Pulumi.AwsNative.Events.EventBusArgs @selfRef, global::Pulumi.AwsNative.Events.Inputs.DeadLetterConfigPropertiesArgs deadLetterConfig)
    {
        @selfRef.DeadLetterConfig = deadLetterConfig;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.EventBusArgs WithDeadLetterConfig(this global::Pulumi.AwsNative.Events.EventBusArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Events.Inputs.DeadLetterConfigPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Events.Inputs.DeadLetterConfigPropertiesArgs();
        @configure(@item);
        @selfRef.DeadLetterConfig = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.EventBusArgs WithDescription(this global::Pulumi.AwsNative.Events.EventBusArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.EventBusArgs WithEventSourceName(this global::Pulumi.AwsNative.Events.EventBusArgs @selfRef, global::System.String eventSourceName)
    {
        @selfRef.EventSourceName = eventSourceName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.EventBusArgs WithKmsKeyIdentifier(this global::Pulumi.AwsNative.Events.EventBusArgs @selfRef, global::System.String kmsKeyIdentifier)
    {
        @selfRef.KmsKeyIdentifier = kmsKeyIdentifier;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.EventBusArgs WithName(this global::Pulumi.AwsNative.Events.EventBusArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.EventBusArgs WithPolicy(this global::Pulumi.AwsNative.Events.EventBusArgs @selfRef, global::System.Object policy)
    {
        @selfRef.Policy = policy;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.EventBusArgs WithPolicy(this global::Pulumi.AwsNative.Events.EventBusArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.Policy = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.EventBusArgs WithTags(this global::Pulumi.AwsNative.Events.EventBusArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.EventBusArgs WithTags(this global::Pulumi.AwsNative.Events.EventBusArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Events.EventBusArgs WithTags(this global::Pulumi.AwsNative.Events.EventBusArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
