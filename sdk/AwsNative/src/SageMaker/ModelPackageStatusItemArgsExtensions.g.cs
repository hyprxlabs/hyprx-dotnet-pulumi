// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.SageMaker.Inputs;

namespace Pulumi.AwsNative.SageMaker;

public static partial class ModelPackageStatusItemArgsExtensions
{
    public static global::Pulumi.AwsNative.SageMaker.Inputs.ModelPackageStatusItemArgs WithFailureReason(this global::Pulumi.AwsNative.SageMaker.Inputs.ModelPackageStatusItemArgs @selfRef, global::System.String failureReason)
    {
        @selfRef.FailureReason = failureReason;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.ModelPackageStatusItemArgs WithName(this global::Pulumi.AwsNative.SageMaker.Inputs.ModelPackageStatusItemArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.ModelPackageStatusItemArgs WithStatus(this global::Pulumi.AwsNative.SageMaker.Inputs.ModelPackageStatusItemArgs @selfRef, global::Pulumi.AwsNative.SageMaker.ModelPackageStatusItemStatus status)
    {
        @selfRef.Status = status;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.ModelPackageStatusItemArgs WithStatus(this global::Pulumi.AwsNative.SageMaker.Inputs.ModelPackageStatusItemArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.SageMaker.ModelPackageStatusItemStatus> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.SageMaker.ModelPackageStatusItemStatus>();
        @configure(@item);
        @selfRef.Status = @item;
        return @selfRef;
    }

}
