// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class AnalysisPivotTableConditionalFormattingScopeArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableConditionalFormattingScopeArgs WithRole(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableConditionalFormattingScopeArgs @selfRef, global::Pulumi.AwsNative.QuickSight.AnalysisPivotTableConditionalFormattingScopeRole role)
    {
        @selfRef.Role = role;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableConditionalFormattingScopeArgs WithRole(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableConditionalFormattingScopeArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.AnalysisPivotTableConditionalFormattingScopeRole> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QuickSight.AnalysisPivotTableConditionalFormattingScopeRole>();
        @configure(@item);
        @selfRef.Role = @item;
        return @selfRef;
    }

}
