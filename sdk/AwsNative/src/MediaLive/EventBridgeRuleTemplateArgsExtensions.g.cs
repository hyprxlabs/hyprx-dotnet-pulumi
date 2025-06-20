// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.MediaLive;

public static partial class EventBridgeRuleTemplateArgsExtensions
{
    public static global::Pulumi.AwsNative.MediaLive.EventBridgeRuleTemplateArgs WithDescription(this global::Pulumi.AwsNative.MediaLive.EventBridgeRuleTemplateArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaLive.EventBridgeRuleTemplateArgs WithEventTargets(this global::Pulumi.AwsNative.MediaLive.EventBridgeRuleTemplateArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.MediaLive.Inputs.EventBridgeRuleTemplateTargetArgs> eventTargets)
    {
        @selfRef.EventTargets = eventTargets;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaLive.EventBridgeRuleTemplateArgs WithEventTargets(this global::Pulumi.AwsNative.MediaLive.EventBridgeRuleTemplateArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.MediaLive.Inputs.EventBridgeRuleTemplateTargetArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.MediaLive.Inputs.EventBridgeRuleTemplateTargetArgs>();
        @configure(@list);
        @selfRef.EventTargets = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaLive.EventBridgeRuleTemplateArgs WithEventTargets(this global::Pulumi.AwsNative.MediaLive.EventBridgeRuleTemplateArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.MediaLive.Inputs.EventBridgeRuleTemplateTargetArgs>> @create)
    {
        @selfRef.EventTargets = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaLive.EventBridgeRuleTemplateArgs WithEventType(this global::Pulumi.AwsNative.MediaLive.EventBridgeRuleTemplateArgs @selfRef, global::Pulumi.AwsNative.MediaLive.EventBridgeRuleTemplateEventType eventType)
    {
        @selfRef.EventType = eventType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaLive.EventBridgeRuleTemplateArgs WithEventType(this global::Pulumi.AwsNative.MediaLive.EventBridgeRuleTemplateArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.MediaLive.EventBridgeRuleTemplateEventType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.MediaLive.EventBridgeRuleTemplateEventType>();
        @configure(@item);
        @selfRef.EventType = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaLive.EventBridgeRuleTemplateArgs WithGroupIdentifier(this global::Pulumi.AwsNative.MediaLive.EventBridgeRuleTemplateArgs @selfRef, global::System.String groupIdentifier)
    {
        @selfRef.GroupIdentifier = groupIdentifier;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaLive.EventBridgeRuleTemplateArgs WithName(this global::Pulumi.AwsNative.MediaLive.EventBridgeRuleTemplateArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaLive.EventBridgeRuleTemplateArgs WithTags(this global::Pulumi.AwsNative.MediaLive.EventBridgeRuleTemplateArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaLive.EventBridgeRuleTemplateArgs WithTags(this global::Pulumi.AwsNative.MediaLive.EventBridgeRuleTemplateArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaLive.EventBridgeRuleTemplateArgs WithTags(this global::Pulumi.AwsNative.MediaLive.EventBridgeRuleTemplateArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
