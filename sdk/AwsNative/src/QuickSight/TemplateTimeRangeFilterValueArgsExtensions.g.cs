// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class TemplateTimeRangeFilterValueArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateTimeRangeFilterValueArgs WithParameter(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateTimeRangeFilterValueArgs @selfRef, global::System.String parameter)
    {
        @selfRef.Parameter = parameter;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateTimeRangeFilterValueArgs WithRollingDate(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateTimeRangeFilterValueArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRollingDateConfigurationArgs rollingDate)
    {
        @selfRef.RollingDate = rollingDate;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateTimeRangeFilterValueArgs WithRollingDate(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateTimeRangeFilterValueArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRollingDateConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRollingDateConfigurationArgs();
        @configure(@item);
        @selfRef.RollingDate = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateTimeRangeFilterValueArgs WithStaticValue(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateTimeRangeFilterValueArgs @selfRef, global::System.String staticValue)
    {
        @selfRef.StaticValue = staticValue;
        return @selfRef;
    }

}
