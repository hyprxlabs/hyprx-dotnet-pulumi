// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class TemplateFunnelChartAggregatedFieldWellsArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartAggregatedFieldWellsArgs WithCategory(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartAggregatedFieldWellsArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateDimensionFieldArgs> category)
    {
        @selfRef.Category = category;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartAggregatedFieldWellsArgs WithCategory(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartAggregatedFieldWellsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateDimensionFieldArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateDimensionFieldArgs>();
        @configure(@list);
        @selfRef.Category = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartAggregatedFieldWellsArgs WithCategory(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartAggregatedFieldWellsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateDimensionFieldArgs>> @create)
    {
        @selfRef.Category = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartAggregatedFieldWellsArgs WithValues(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartAggregatedFieldWellsArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateMeasureFieldArgs> values)
    {
        @selfRef.Values = values;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartAggregatedFieldWellsArgs WithValues(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartAggregatedFieldWellsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateMeasureFieldArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateMeasureFieldArgs>();
        @configure(@list);
        @selfRef.Values = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartAggregatedFieldWellsArgs WithValues(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartAggregatedFieldWellsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateMeasureFieldArgs>> @create)
    {
        @selfRef.Values = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
