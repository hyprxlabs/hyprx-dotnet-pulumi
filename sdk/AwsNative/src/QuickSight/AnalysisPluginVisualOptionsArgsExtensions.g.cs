// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class AnalysisPluginVisualOptionsArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPluginVisualOptionsArgs WithVisualProperties(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPluginVisualOptionsArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPluginVisualPropertyArgs> visualProperties)
    {
        @selfRef.VisualProperties = visualProperties;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPluginVisualOptionsArgs WithVisualProperties(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPluginVisualOptionsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPluginVisualPropertyArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPluginVisualPropertyArgs>();
        @configure(@list);
        @selfRef.VisualProperties = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPluginVisualOptionsArgs WithVisualProperties(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPluginVisualOptionsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPluginVisualPropertyArgs>> @create)
    {
        @selfRef.VisualProperties = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
