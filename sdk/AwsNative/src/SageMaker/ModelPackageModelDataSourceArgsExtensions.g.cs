// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.SageMaker.Inputs;

namespace Pulumi.AwsNative.SageMaker;

public static partial class ModelPackageModelDataSourceArgsExtensions
{
    public static global::Pulumi.AwsNative.SageMaker.Inputs.ModelPackageModelDataSourceArgs WithS3DataSource(this global::Pulumi.AwsNative.SageMaker.Inputs.ModelPackageModelDataSourceArgs @selfRef, global::Pulumi.AwsNative.SageMaker.Inputs.ModelPackageS3ModelDataSourceArgs s3DataSource)
    {
        @selfRef.S3DataSource = s3DataSource;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.ModelPackageModelDataSourceArgs WithS3DataSource(this global::Pulumi.AwsNative.SageMaker.Inputs.ModelPackageModelDataSourceArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.SageMaker.Inputs.ModelPackageS3ModelDataSourceArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.SageMaker.Inputs.ModelPackageS3ModelDataSourceArgs();
        @configure(@item);
        @selfRef.S3DataSource = @item;
        return @selfRef;
    }

}
