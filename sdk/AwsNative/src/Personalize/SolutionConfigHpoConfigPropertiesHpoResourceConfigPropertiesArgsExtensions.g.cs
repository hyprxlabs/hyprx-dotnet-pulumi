// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Personalize.Inputs;

namespace Pulumi.AwsNative.Personalize;

public static partial class SolutionConfigHpoConfigPropertiesHpoResourceConfigPropertiesArgsExtensions
{
    public static global::Pulumi.AwsNative.Personalize.Inputs.SolutionConfigHpoConfigPropertiesHpoResourceConfigPropertiesArgs WithMaxNumberOfTrainingJobs(this global::Pulumi.AwsNative.Personalize.Inputs.SolutionConfigHpoConfigPropertiesHpoResourceConfigPropertiesArgs @selfRef, global::System.String maxNumberOfTrainingJobs)
    {
        @selfRef.MaxNumberOfTrainingJobs = maxNumberOfTrainingJobs;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Personalize.Inputs.SolutionConfigHpoConfigPropertiesHpoResourceConfigPropertiesArgs WithMaxParallelTrainingJobs(this global::Pulumi.AwsNative.Personalize.Inputs.SolutionConfigHpoConfigPropertiesHpoResourceConfigPropertiesArgs @selfRef, global::System.String maxParallelTrainingJobs)
    {
        @selfRef.MaxParallelTrainingJobs = maxParallelTrainingJobs;
        return @selfRef;
    }

}
