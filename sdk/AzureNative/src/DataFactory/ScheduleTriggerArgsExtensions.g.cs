// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataFactory.Inputs;

namespace Pulumi.AzureNative.DataFactory;

public static partial class ScheduleTriggerArgsExtensions
{
    public static global::Pulumi.AzureNative.DataFactory.Inputs.ScheduleTriggerArgs WithAnnotations(this global::Pulumi.AzureNative.DataFactory.Inputs.ScheduleTriggerArgs @selfRef, global::System.Collections.Generic.List<global::System.Object> annotations)
    {
        @selfRef.Annotations = annotations;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.ScheduleTriggerArgs WithAnnotations(this global::Pulumi.AzureNative.DataFactory.Inputs.ScheduleTriggerArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.Object>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.Object>();
        @configure(@list);
        @selfRef.Annotations = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.ScheduleTriggerArgs WithAnnotations(this global::Pulumi.AzureNative.DataFactory.Inputs.ScheduleTriggerArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.Object>> @create)
    {
        @selfRef.Annotations = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.ScheduleTriggerArgs WithDescription(this global::Pulumi.AzureNative.DataFactory.Inputs.ScheduleTriggerArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.ScheduleTriggerArgs WithPipelines(this global::Pulumi.AzureNative.DataFactory.Inputs.ScheduleTriggerArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.DataFactory.Inputs.TriggerPipelineReferenceArgs> pipelines)
    {
        @selfRef.Pipelines = pipelines;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.ScheduleTriggerArgs WithPipelines(this global::Pulumi.AzureNative.DataFactory.Inputs.ScheduleTriggerArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.DataFactory.Inputs.TriggerPipelineReferenceArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.DataFactory.Inputs.TriggerPipelineReferenceArgs>();
        @configure(@list);
        @selfRef.Pipelines = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.ScheduleTriggerArgs WithPipelines(this global::Pulumi.AzureNative.DataFactory.Inputs.ScheduleTriggerArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.DataFactory.Inputs.TriggerPipelineReferenceArgs>> @create)
    {
        @selfRef.Pipelines = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.ScheduleTriggerArgs WithRecurrence(this global::Pulumi.AzureNative.DataFactory.Inputs.ScheduleTriggerArgs @selfRef, global::Pulumi.AzureNative.DataFactory.Inputs.ScheduleTriggerRecurrenceArgs recurrence)
    {
        @selfRef.Recurrence = recurrence;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.ScheduleTriggerArgs WithRecurrence(this global::Pulumi.AzureNative.DataFactory.Inputs.ScheduleTriggerArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataFactory.Inputs.ScheduleTriggerRecurrenceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DataFactory.Inputs.ScheduleTriggerRecurrenceArgs();
        @configure(@item);
        @selfRef.Recurrence = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.ScheduleTriggerArgs WithType(this global::Pulumi.AzureNative.DataFactory.Inputs.ScheduleTriggerArgs @selfRef, global::System.String type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

}
