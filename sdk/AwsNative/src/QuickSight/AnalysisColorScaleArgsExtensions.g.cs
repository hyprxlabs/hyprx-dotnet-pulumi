// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class AnalysisColorScaleArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisColorScaleArgs WithColorFillType(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisColorScaleArgs @selfRef, global::Pulumi.AwsNative.QuickSight.AnalysisColorFillType colorFillType)
    {
        @selfRef.ColorFillType = colorFillType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisColorScaleArgs WithColorFillType(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisColorScaleArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.AnalysisColorFillType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QuickSight.AnalysisColorFillType>();
        @configure(@item);
        @selfRef.ColorFillType = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisColorScaleArgs WithColors(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisColorScaleArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDataColorArgs> colors)
    {
        @selfRef.Colors = colors;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisColorScaleArgs WithColors(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisColorScaleArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDataColorArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDataColorArgs>();
        @configure(@list);
        @selfRef.Colors = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisColorScaleArgs WithColors(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisColorScaleArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDataColorArgs>> @create)
    {
        @selfRef.Colors = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisColorScaleArgs WithNullValueColor(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisColorScaleArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDataColorArgs nullValueColor)
    {
        @selfRef.NullValueColor = nullValueColor;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisColorScaleArgs WithNullValueColor(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisColorScaleArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDataColorArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDataColorArgs();
        @configure(@item);
        @selfRef.NullValueColor = @item;
        return @selfRef;
    }

}
