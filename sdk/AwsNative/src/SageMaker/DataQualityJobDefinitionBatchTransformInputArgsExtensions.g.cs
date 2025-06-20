// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.SageMaker.Inputs;

namespace Pulumi.AwsNative.SageMaker;

public static partial class DataQualityJobDefinitionBatchTransformInputArgsExtensions
{
    public static global::Pulumi.AwsNative.SageMaker.Inputs.DataQualityJobDefinitionBatchTransformInputArgs WithDataCapturedDestinationS3Uri(this global::Pulumi.AwsNative.SageMaker.Inputs.DataQualityJobDefinitionBatchTransformInputArgs @selfRef, global::System.String dataCapturedDestinationS3Uri)
    {
        @selfRef.DataCapturedDestinationS3Uri = dataCapturedDestinationS3Uri;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.DataQualityJobDefinitionBatchTransformInputArgs WithDatasetFormat(this global::Pulumi.AwsNative.SageMaker.Inputs.DataQualityJobDefinitionBatchTransformInputArgs @selfRef, global::Pulumi.AwsNative.SageMaker.Inputs.DataQualityJobDefinitionDatasetFormatArgs datasetFormat)
    {
        @selfRef.DatasetFormat = datasetFormat;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.DataQualityJobDefinitionBatchTransformInputArgs WithDatasetFormat(this global::Pulumi.AwsNative.SageMaker.Inputs.DataQualityJobDefinitionBatchTransformInputArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.SageMaker.Inputs.DataQualityJobDefinitionDatasetFormatArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.SageMaker.Inputs.DataQualityJobDefinitionDatasetFormatArgs();
        @configure(@item);
        @selfRef.DatasetFormat = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.DataQualityJobDefinitionBatchTransformInputArgs WithExcludeFeaturesAttribute(this global::Pulumi.AwsNative.SageMaker.Inputs.DataQualityJobDefinitionBatchTransformInputArgs @selfRef, global::System.String excludeFeaturesAttribute)
    {
        @selfRef.ExcludeFeaturesAttribute = excludeFeaturesAttribute;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.DataQualityJobDefinitionBatchTransformInputArgs WithLocalPath(this global::Pulumi.AwsNative.SageMaker.Inputs.DataQualityJobDefinitionBatchTransformInputArgs @selfRef, global::System.String localPath)
    {
        @selfRef.LocalPath = localPath;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.DataQualityJobDefinitionBatchTransformInputArgs WithS3DataDistributionType(this global::Pulumi.AwsNative.SageMaker.Inputs.DataQualityJobDefinitionBatchTransformInputArgs @selfRef, global::Pulumi.AwsNative.SageMaker.DataQualityJobDefinitionBatchTransformInputS3DataDistributionType s3DataDistributionType)
    {
        @selfRef.S3DataDistributionType = s3DataDistributionType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.DataQualityJobDefinitionBatchTransformInputArgs WithS3DataDistributionType(this global::Pulumi.AwsNative.SageMaker.Inputs.DataQualityJobDefinitionBatchTransformInputArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.SageMaker.DataQualityJobDefinitionBatchTransformInputS3DataDistributionType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.SageMaker.DataQualityJobDefinitionBatchTransformInputS3DataDistributionType>();
        @configure(@item);
        @selfRef.S3DataDistributionType = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.DataQualityJobDefinitionBatchTransformInputArgs WithS3InputMode(this global::Pulumi.AwsNative.SageMaker.Inputs.DataQualityJobDefinitionBatchTransformInputArgs @selfRef, global::Pulumi.AwsNative.SageMaker.DataQualityJobDefinitionBatchTransformInputS3InputMode s3InputMode)
    {
        @selfRef.S3InputMode = s3InputMode;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.DataQualityJobDefinitionBatchTransformInputArgs WithS3InputMode(this global::Pulumi.AwsNative.SageMaker.Inputs.DataQualityJobDefinitionBatchTransformInputArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.SageMaker.DataQualityJobDefinitionBatchTransformInputS3InputMode> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.SageMaker.DataQualityJobDefinitionBatchTransformInputS3InputMode>();
        @configure(@item);
        @selfRef.S3InputMode = @item;
        return @selfRef;
    }

}
