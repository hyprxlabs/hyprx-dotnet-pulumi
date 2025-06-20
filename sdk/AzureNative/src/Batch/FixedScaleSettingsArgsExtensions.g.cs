// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Batch.Inputs;

namespace Pulumi.AzureNative.Batch;

public static partial class FixedScaleSettingsArgsExtensions
{
    public static global::Pulumi.AzureNative.Batch.Inputs.FixedScaleSettingsArgs WithNodeDeallocationOption(this global::Pulumi.AzureNative.Batch.Inputs.FixedScaleSettingsArgs @selfRef, global::Pulumi.AzureNative.Batch.ComputeNodeDeallocationOption nodeDeallocationOption)
    {
        @selfRef.NodeDeallocationOption = nodeDeallocationOption;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Batch.Inputs.FixedScaleSettingsArgs WithNodeDeallocationOption(this global::Pulumi.AzureNative.Batch.Inputs.FixedScaleSettingsArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Batch.ComputeNodeDeallocationOption> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AzureNative.Batch.ComputeNodeDeallocationOption>();
        @configure(@item);
        @selfRef.NodeDeallocationOption = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Batch.Inputs.FixedScaleSettingsArgs WithResizeTimeout(this global::Pulumi.AzureNative.Batch.Inputs.FixedScaleSettingsArgs @selfRef, global::System.String resizeTimeout)
    {
        @selfRef.ResizeTimeout = resizeTimeout;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Batch.Inputs.FixedScaleSettingsArgs WithTargetDedicatedNodes(this global::Pulumi.AzureNative.Batch.Inputs.FixedScaleSettingsArgs @selfRef, global::System.Int32 targetDedicatedNodes)
    {
        @selfRef.TargetDedicatedNodes = targetDedicatedNodes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Batch.Inputs.FixedScaleSettingsArgs WithTargetLowPriorityNodes(this global::Pulumi.AzureNative.Batch.Inputs.FixedScaleSettingsArgs @selfRef, global::System.Int32 targetLowPriorityNodes)
    {
        @selfRef.TargetLowPriorityNodes = targetLowPriorityNodes;
        return @selfRef;
    }

}
