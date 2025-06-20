// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.EventGrid.Inputs;

namespace Pulumi.AzureNative.EventGrid;

public static partial class EventTypeInfoArgsExtensions
{
    public static global::Pulumi.AzureNative.EventGrid.Inputs.EventTypeInfoArgs WithInlineEventTypes(this global::Pulumi.AzureNative.EventGrid.Inputs.EventTypeInfoArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.EventGrid.Inputs.InlineEventPropertiesArgs> inlineEventTypes)
    {
        @selfRef.InlineEventTypes = inlineEventTypes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EventGrid.Inputs.EventTypeInfoArgs WithInlineEventTypes(this global::Pulumi.AzureNative.EventGrid.Inputs.EventTypeInfoArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.EventGrid.Inputs.InlineEventPropertiesArgs>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.EventGrid.Inputs.InlineEventPropertiesArgs>();
        @configure(@dict);
        @selfRef.InlineEventTypes = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EventGrid.Inputs.EventTypeInfoArgs WithInlineEventTypes(this global::Pulumi.AzureNative.EventGrid.Inputs.EventTypeInfoArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::Pulumi.AzureNative.EventGrid.Inputs.InlineEventPropertiesArgs>> @create)
    {
        @selfRef.InlineEventTypes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EventGrid.Inputs.EventTypeInfoArgs WithKind(this global::Pulumi.AzureNative.EventGrid.Inputs.EventTypeInfoArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.EventGrid.EventDefinitionKind> kind)
    {
        @selfRef.Kind = kind;
        return @selfRef;
    }

}
