// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class TemplateColorScaleArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateColorScaleArgs WithColorFillType(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateColorScaleArgs @selfRef, global::Pulumi.AwsNative.QuickSight.TemplateColorFillType colorFillType)
    {
        @selfRef.ColorFillType = colorFillType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateColorScaleArgs WithColorFillType(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateColorScaleArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.TemplateColorFillType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QuickSight.TemplateColorFillType>();
        @configure(@item);
        @selfRef.ColorFillType = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateColorScaleArgs WithColors(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateColorScaleArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateDataColorArgs> colors)
    {
        @selfRef.Colors = colors;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateColorScaleArgs WithColors(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateColorScaleArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateDataColorArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateDataColorArgs>();
        @configure(@list);
        @selfRef.Colors = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateColorScaleArgs WithColors(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateColorScaleArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateDataColorArgs>> @create)
    {
        @selfRef.Colors = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateColorScaleArgs WithNullValueColor(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateColorScaleArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateDataColorArgs nullValueColor)
    {
        @selfRef.NullValueColor = nullValueColor;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateColorScaleArgs WithNullValueColor(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateColorScaleArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateDataColorArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateDataColorArgs();
        @configure(@item);
        @selfRef.NullValueColor = @item;
        return @selfRef;
    }

}
