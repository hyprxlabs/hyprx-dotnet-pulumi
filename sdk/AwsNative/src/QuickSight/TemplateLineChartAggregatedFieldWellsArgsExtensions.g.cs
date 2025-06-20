// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class TemplateLineChartAggregatedFieldWellsArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLineChartAggregatedFieldWellsArgs WithCategory(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLineChartAggregatedFieldWellsArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateDimensionFieldArgs> category)
    {
        @selfRef.Category = category;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLineChartAggregatedFieldWellsArgs WithCategory(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLineChartAggregatedFieldWellsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateDimensionFieldArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateDimensionFieldArgs>();
        @configure(@list);
        @selfRef.Category = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLineChartAggregatedFieldWellsArgs WithCategory(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLineChartAggregatedFieldWellsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateDimensionFieldArgs>> @create)
    {
        @selfRef.Category = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLineChartAggregatedFieldWellsArgs WithColors(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLineChartAggregatedFieldWellsArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateDimensionFieldArgs> colors)
    {
        @selfRef.Colors = colors;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLineChartAggregatedFieldWellsArgs WithColors(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLineChartAggregatedFieldWellsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateDimensionFieldArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateDimensionFieldArgs>();
        @configure(@list);
        @selfRef.Colors = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLineChartAggregatedFieldWellsArgs WithColors(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLineChartAggregatedFieldWellsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateDimensionFieldArgs>> @create)
    {
        @selfRef.Colors = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLineChartAggregatedFieldWellsArgs WithSmallMultiples(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLineChartAggregatedFieldWellsArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateDimensionFieldArgs> smallMultiples)
    {
        @selfRef.SmallMultiples = smallMultiples;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLineChartAggregatedFieldWellsArgs WithSmallMultiples(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLineChartAggregatedFieldWellsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateDimensionFieldArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateDimensionFieldArgs>();
        @configure(@list);
        @selfRef.SmallMultiples = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLineChartAggregatedFieldWellsArgs WithSmallMultiples(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLineChartAggregatedFieldWellsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateDimensionFieldArgs>> @create)
    {
        @selfRef.SmallMultiples = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLineChartAggregatedFieldWellsArgs WithValues(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLineChartAggregatedFieldWellsArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateMeasureFieldArgs> values)
    {
        @selfRef.Values = values;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLineChartAggregatedFieldWellsArgs WithValues(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLineChartAggregatedFieldWellsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateMeasureFieldArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateMeasureFieldArgs>();
        @configure(@list);
        @selfRef.Values = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLineChartAggregatedFieldWellsArgs WithValues(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLineChartAggregatedFieldWellsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateMeasureFieldArgs>> @create)
    {
        @selfRef.Values = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
