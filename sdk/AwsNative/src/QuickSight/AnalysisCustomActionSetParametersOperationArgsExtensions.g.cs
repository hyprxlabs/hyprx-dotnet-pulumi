// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class AnalysisCustomActionSetParametersOperationArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisCustomActionSetParametersOperationArgs WithParameterValueConfigurations(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisCustomActionSetParametersOperationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSetParameterValueConfigurationArgs> parameterValueConfigurations)
    {
        @selfRef.ParameterValueConfigurations = parameterValueConfigurations;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisCustomActionSetParametersOperationArgs WithParameterValueConfigurations(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisCustomActionSetParametersOperationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSetParameterValueConfigurationArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSetParameterValueConfigurationArgs>();
        @configure(@list);
        @selfRef.ParameterValueConfigurations = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisCustomActionSetParametersOperationArgs WithParameterValueConfigurations(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisCustomActionSetParametersOperationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSetParameterValueConfigurationArgs>> @create)
    {
        @selfRef.ParameterValueConfigurations = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
