// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class AnalysisValidationStrategyArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisValidationStrategyArgs WithMode(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisValidationStrategyArgs @selfRef, global::Pulumi.AwsNative.QuickSight.AnalysisValidationStrategyMode mode)
    {
        @selfRef.Mode = mode;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisValidationStrategyArgs WithMode(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisValidationStrategyArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.AnalysisValidationStrategyMode> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QuickSight.AnalysisValidationStrategyMode>();
        @configure(@item);
        @selfRef.Mode = @item;
        return @selfRef;
    }

}
