// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.SageMaker.Inputs;

namespace Pulumi.AwsNative.SageMaker;

public static partial class ModelCardTrainingMetricArgsExtensions
{
    public static global::Pulumi.AwsNative.SageMaker.Inputs.ModelCardTrainingMetricArgs WithName(this global::Pulumi.AwsNative.SageMaker.Inputs.ModelCardTrainingMetricArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.ModelCardTrainingMetricArgs WithNotes(this global::Pulumi.AwsNative.SageMaker.Inputs.ModelCardTrainingMetricArgs @selfRef, global::System.String notes)
    {
        @selfRef.Notes = notes;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.ModelCardTrainingMetricArgs WithValue(this global::Pulumi.AwsNative.SageMaker.Inputs.ModelCardTrainingMetricArgs @selfRef, global::System.Double value)
    {
        @selfRef.Value = value;
        return @selfRef;
    }

}
