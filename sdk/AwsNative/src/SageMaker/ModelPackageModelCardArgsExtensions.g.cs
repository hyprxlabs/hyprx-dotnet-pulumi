// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.SageMaker.Inputs;

namespace Pulumi.AwsNative.SageMaker;

public static partial class ModelPackageModelCardArgsExtensions
{
    public static global::Pulumi.AwsNative.SageMaker.Inputs.ModelPackageModelCardArgs WithModelCardContent(this global::Pulumi.AwsNative.SageMaker.Inputs.ModelPackageModelCardArgs @selfRef, global::System.String modelCardContent)
    {
        @selfRef.ModelCardContent = modelCardContent;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.ModelPackageModelCardArgs WithModelCardStatus(this global::Pulumi.AwsNative.SageMaker.Inputs.ModelPackageModelCardArgs @selfRef, global::Pulumi.AwsNative.SageMaker.ModelPackageModelCardModelCardStatus modelCardStatus)
    {
        @selfRef.ModelCardStatus = modelCardStatus;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.ModelPackageModelCardArgs WithModelCardStatus(this global::Pulumi.AwsNative.SageMaker.Inputs.ModelPackageModelCardArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.SageMaker.ModelPackageModelCardModelCardStatus> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.SageMaker.ModelPackageModelCardModelCardStatus>();
        @configure(@item);
        @selfRef.ModelCardStatus = @item;
        return @selfRef;
    }

}
