// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Personalize.Inputs;

namespace Pulumi.AwsNative.Personalize;

public static partial class SolutionConfigHpoConfigPropertiesHpoObjectivePropertiesArgsExtensions
{
    public static global::Pulumi.AwsNative.Personalize.Inputs.SolutionConfigHpoConfigPropertiesHpoObjectivePropertiesArgs WithMetricName(this global::Pulumi.AwsNative.Personalize.Inputs.SolutionConfigHpoConfigPropertiesHpoObjectivePropertiesArgs @selfRef, global::System.String metricName)
    {
        @selfRef.MetricName = metricName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Personalize.Inputs.SolutionConfigHpoConfigPropertiesHpoObjectivePropertiesArgs WithMetricRegex(this global::Pulumi.AwsNative.Personalize.Inputs.SolutionConfigHpoConfigPropertiesHpoObjectivePropertiesArgs @selfRef, global::System.String metricRegex)
    {
        @selfRef.MetricRegex = metricRegex;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Personalize.Inputs.SolutionConfigHpoConfigPropertiesHpoObjectivePropertiesArgs WithType(this global::Pulumi.AwsNative.Personalize.Inputs.SolutionConfigHpoConfigPropertiesHpoObjectivePropertiesArgs @selfRef, global::Pulumi.AwsNative.Personalize.SolutionConfigHpoConfigPropertiesHpoObjectivePropertiesType type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Personalize.Inputs.SolutionConfigHpoConfigPropertiesHpoObjectivePropertiesArgs WithType(this global::Pulumi.AwsNative.Personalize.Inputs.SolutionConfigHpoConfigPropertiesHpoObjectivePropertiesArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Personalize.SolutionConfigHpoConfigPropertiesHpoObjectivePropertiesType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Personalize.SolutionConfigHpoConfigPropertiesHpoObjectivePropertiesType>();
        @configure(@item);
        @selfRef.Type = @item;
        return @selfRef;
    }

}
