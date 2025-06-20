// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.SageMaker.Inputs;

namespace Pulumi.AwsNative.SageMaker;

public static partial class ModelQualityJobDefinitionEndpointInputArgsExtensions
{
    public static global::Pulumi.AwsNative.SageMaker.Inputs.ModelQualityJobDefinitionEndpointInputArgs WithEndTimeOffset(this global::Pulumi.AwsNative.SageMaker.Inputs.ModelQualityJobDefinitionEndpointInputArgs @selfRef, global::System.String endTimeOffset)
    {
        @selfRef.EndTimeOffset = endTimeOffset;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.ModelQualityJobDefinitionEndpointInputArgs WithEndpointName(this global::Pulumi.AwsNative.SageMaker.Inputs.ModelQualityJobDefinitionEndpointInputArgs @selfRef, global::System.String endpointName)
    {
        @selfRef.EndpointName = endpointName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.ModelQualityJobDefinitionEndpointInputArgs WithInferenceAttribute(this global::Pulumi.AwsNative.SageMaker.Inputs.ModelQualityJobDefinitionEndpointInputArgs @selfRef, global::System.String inferenceAttribute)
    {
        @selfRef.InferenceAttribute = inferenceAttribute;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.ModelQualityJobDefinitionEndpointInputArgs WithLocalPath(this global::Pulumi.AwsNative.SageMaker.Inputs.ModelQualityJobDefinitionEndpointInputArgs @selfRef, global::System.String localPath)
    {
        @selfRef.LocalPath = localPath;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.ModelQualityJobDefinitionEndpointInputArgs WithProbabilityAttribute(this global::Pulumi.AwsNative.SageMaker.Inputs.ModelQualityJobDefinitionEndpointInputArgs @selfRef, global::System.String probabilityAttribute)
    {
        @selfRef.ProbabilityAttribute = probabilityAttribute;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.ModelQualityJobDefinitionEndpointInputArgs WithProbabilityThresholdAttribute(this global::Pulumi.AwsNative.SageMaker.Inputs.ModelQualityJobDefinitionEndpointInputArgs @selfRef, global::System.Double probabilityThresholdAttribute)
    {
        @selfRef.ProbabilityThresholdAttribute = probabilityThresholdAttribute;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.ModelQualityJobDefinitionEndpointInputArgs WithS3DataDistributionType(this global::Pulumi.AwsNative.SageMaker.Inputs.ModelQualityJobDefinitionEndpointInputArgs @selfRef, global::Pulumi.AwsNative.SageMaker.ModelQualityJobDefinitionEndpointInputS3DataDistributionType s3DataDistributionType)
    {
        @selfRef.S3DataDistributionType = s3DataDistributionType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.ModelQualityJobDefinitionEndpointInputArgs WithS3DataDistributionType(this global::Pulumi.AwsNative.SageMaker.Inputs.ModelQualityJobDefinitionEndpointInputArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.SageMaker.ModelQualityJobDefinitionEndpointInputS3DataDistributionType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.SageMaker.ModelQualityJobDefinitionEndpointInputS3DataDistributionType>();
        @configure(@item);
        @selfRef.S3DataDistributionType = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.ModelQualityJobDefinitionEndpointInputArgs WithS3InputMode(this global::Pulumi.AwsNative.SageMaker.Inputs.ModelQualityJobDefinitionEndpointInputArgs @selfRef, global::Pulumi.AwsNative.SageMaker.ModelQualityJobDefinitionEndpointInputS3InputMode s3InputMode)
    {
        @selfRef.S3InputMode = s3InputMode;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.ModelQualityJobDefinitionEndpointInputArgs WithS3InputMode(this global::Pulumi.AwsNative.SageMaker.Inputs.ModelQualityJobDefinitionEndpointInputArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.SageMaker.ModelQualityJobDefinitionEndpointInputS3InputMode> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.SageMaker.ModelQualityJobDefinitionEndpointInputS3InputMode>();
        @configure(@item);
        @selfRef.S3InputMode = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.ModelQualityJobDefinitionEndpointInputArgs WithStartTimeOffset(this global::Pulumi.AwsNative.SageMaker.Inputs.ModelQualityJobDefinitionEndpointInputArgs @selfRef, global::System.String startTimeOffset)
    {
        @selfRef.StartTimeOffset = startTimeOffset;
        return @selfRef;
    }

}
