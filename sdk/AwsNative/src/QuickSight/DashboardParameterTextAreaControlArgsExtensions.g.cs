// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class DashboardParameterTextAreaControlArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardParameterTextAreaControlArgs WithDelimiter(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardParameterTextAreaControlArgs @selfRef, global::System.String delimiter)
    {
        @selfRef.Delimiter = delimiter;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardParameterTextAreaControlArgs WithDisplayOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardParameterTextAreaControlArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTextAreaControlDisplayOptionsArgs displayOptions)
    {
        @selfRef.DisplayOptions = displayOptions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardParameterTextAreaControlArgs WithDisplayOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardParameterTextAreaControlArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTextAreaControlDisplayOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTextAreaControlDisplayOptionsArgs();
        @configure(@item);
        @selfRef.DisplayOptions = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardParameterTextAreaControlArgs WithParameterControlId(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardParameterTextAreaControlArgs @selfRef, global::System.String parameterControlId)
    {
        @selfRef.ParameterControlId = parameterControlId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardParameterTextAreaControlArgs WithSourceParameterName(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardParameterTextAreaControlArgs @selfRef, global::System.String sourceParameterName)
    {
        @selfRef.SourceParameterName = sourceParameterName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardParameterTextAreaControlArgs WithTitle(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardParameterTextAreaControlArgs @selfRef, global::System.String title)
    {
        @selfRef.Title = title;
        return @selfRef;
    }

}
