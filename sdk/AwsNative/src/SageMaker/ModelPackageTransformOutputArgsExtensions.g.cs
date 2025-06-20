// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.SageMaker.Inputs;

namespace Pulumi.AwsNative.SageMaker;

public static partial class ModelPackageTransformOutputArgsExtensions
{
    public static global::Pulumi.AwsNative.SageMaker.Inputs.ModelPackageTransformOutputArgs WithAccept(this global::Pulumi.AwsNative.SageMaker.Inputs.ModelPackageTransformOutputArgs @selfRef, global::System.String accept)
    {
        @selfRef.Accept = accept;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.ModelPackageTransformOutputArgs WithAssembleWith(this global::Pulumi.AwsNative.SageMaker.Inputs.ModelPackageTransformOutputArgs @selfRef, global::Pulumi.AwsNative.SageMaker.ModelPackageTransformOutputAssembleWith assembleWith)
    {
        @selfRef.AssembleWith = assembleWith;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.ModelPackageTransformOutputArgs WithAssembleWith(this global::Pulumi.AwsNative.SageMaker.Inputs.ModelPackageTransformOutputArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.SageMaker.ModelPackageTransformOutputAssembleWith> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.SageMaker.ModelPackageTransformOutputAssembleWith>();
        @configure(@item);
        @selfRef.AssembleWith = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.ModelPackageTransformOutputArgs WithKmsKeyId(this global::Pulumi.AwsNative.SageMaker.Inputs.ModelPackageTransformOutputArgs @selfRef, global::System.String kmsKeyId)
    {
        @selfRef.KmsKeyId = kmsKeyId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.ModelPackageTransformOutputArgs WithS3OutputPath(this global::Pulumi.AwsNative.SageMaker.Inputs.ModelPackageTransformOutputArgs @selfRef, global::System.String s3OutputPath)
    {
        @selfRef.S3OutputPath = s3OutputPath;
        return @selfRef;
    }

}
