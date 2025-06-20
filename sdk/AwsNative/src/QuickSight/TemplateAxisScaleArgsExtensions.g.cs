// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class TemplateAxisScaleArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateAxisScaleArgs WithLinear(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateAxisScaleArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateAxisLinearScaleArgs linear)
    {
        @selfRef.Linear = linear;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateAxisScaleArgs WithLinear(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateAxisScaleArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateAxisLinearScaleArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateAxisLinearScaleArgs();
        @configure(@item);
        @selfRef.Linear = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateAxisScaleArgs WithLogarithmic(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateAxisScaleArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateAxisLogarithmicScaleArgs logarithmic)
    {
        @selfRef.Logarithmic = logarithmic;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateAxisScaleArgs WithLogarithmic(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateAxisScaleArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateAxisLogarithmicScaleArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateAxisLogarithmicScaleArgs();
        @configure(@item);
        @selfRef.Logarithmic = @item;
        return @selfRef;
    }

}
