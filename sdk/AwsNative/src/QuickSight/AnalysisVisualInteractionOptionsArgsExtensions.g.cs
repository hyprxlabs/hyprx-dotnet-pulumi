// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class AnalysisVisualInteractionOptionsArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisVisualInteractionOptionsArgs WithContextMenuOption(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisVisualInteractionOptionsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisContextMenuOptionArgs contextMenuOption)
    {
        @selfRef.ContextMenuOption = contextMenuOption;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisVisualInteractionOptionsArgs WithContextMenuOption(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisVisualInteractionOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisContextMenuOptionArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisContextMenuOptionArgs();
        @configure(@item);
        @selfRef.ContextMenuOption = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisVisualInteractionOptionsArgs WithVisualMenuOption(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisVisualInteractionOptionsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisVisualMenuOptionArgs visualMenuOption)
    {
        @selfRef.VisualMenuOption = visualMenuOption;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisVisualInteractionOptionsArgs WithVisualMenuOption(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisVisualInteractionOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisVisualMenuOptionArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisVisualMenuOptionArgs();
        @configure(@item);
        @selfRef.VisualMenuOption = @item;
        return @selfRef;
    }

}
