// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class AnalysisLayerCustomActionArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisLayerCustomActionArgs WithActionOperations(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisLayerCustomActionArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisLayerCustomActionOperationArgs> actionOperations)
    {
        @selfRef.ActionOperations = actionOperations;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisLayerCustomActionArgs WithActionOperations(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisLayerCustomActionArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisLayerCustomActionOperationArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisLayerCustomActionOperationArgs>();
        @configure(@list);
        @selfRef.ActionOperations = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisLayerCustomActionArgs WithActionOperations(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisLayerCustomActionArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisLayerCustomActionOperationArgs>> @create)
    {
        @selfRef.ActionOperations = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisLayerCustomActionArgs WithCustomActionId(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisLayerCustomActionArgs @selfRef, global::System.String customActionId)
    {
        @selfRef.CustomActionId = customActionId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisLayerCustomActionArgs WithName(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisLayerCustomActionArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisLayerCustomActionArgs WithStatus(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisLayerCustomActionArgs @selfRef, global::Pulumi.AwsNative.QuickSight.AnalysisWidgetStatus status)
    {
        @selfRef.Status = status;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisLayerCustomActionArgs WithStatus(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisLayerCustomActionArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.AnalysisWidgetStatus> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QuickSight.AnalysisWidgetStatus>();
        @configure(@item);
        @selfRef.Status = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisLayerCustomActionArgs WithTrigger(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisLayerCustomActionArgs @selfRef, global::Pulumi.AwsNative.QuickSight.AnalysisLayerCustomActionTrigger trigger)
    {
        @selfRef.Trigger = trigger;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisLayerCustomActionArgs WithTrigger(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisLayerCustomActionArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.AnalysisLayerCustomActionTrigger> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QuickSight.AnalysisLayerCustomActionTrigger>();
        @configure(@item);
        @selfRef.Trigger = @item;
        return @selfRef;
    }

}
