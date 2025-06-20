// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class TemplateFieldBasedTooltipArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFieldBasedTooltipArgs WithAggregationVisibility(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFieldBasedTooltipArgs @selfRef, global::System.Object aggregationVisibility)
    {
        @selfRef.AggregationVisibility = aggregationVisibility;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFieldBasedTooltipArgs WithAggregationVisibility(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFieldBasedTooltipArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.AggregationVisibility = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFieldBasedTooltipArgs WithTooltipFields(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFieldBasedTooltipArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateTooltipItemArgs> tooltipFields)
    {
        @selfRef.TooltipFields = tooltipFields;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFieldBasedTooltipArgs WithTooltipFields(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFieldBasedTooltipArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateTooltipItemArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateTooltipItemArgs>();
        @configure(@list);
        @selfRef.TooltipFields = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFieldBasedTooltipArgs WithTooltipFields(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFieldBasedTooltipArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateTooltipItemArgs>> @create)
    {
        @selfRef.TooltipFields = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFieldBasedTooltipArgs WithTooltipTitleType(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFieldBasedTooltipArgs @selfRef, global::Pulumi.AwsNative.QuickSight.TemplateTooltipTitleType tooltipTitleType)
    {
        @selfRef.TooltipTitleType = tooltipTitleType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFieldBasedTooltipArgs WithTooltipTitleType(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFieldBasedTooltipArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.TemplateTooltipTitleType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QuickSight.TemplateTooltipTitleType>();
        @configure(@item);
        @selfRef.TooltipTitleType = @item;
        return @selfRef;
    }

}
