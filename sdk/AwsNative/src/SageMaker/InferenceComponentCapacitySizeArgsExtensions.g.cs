// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.SageMaker.Inputs;

namespace Pulumi.AwsNative.SageMaker;

public static partial class InferenceComponentCapacitySizeArgsExtensions
{
    public static global::Pulumi.AwsNative.SageMaker.Inputs.InferenceComponentCapacitySizeArgs WithType(this global::Pulumi.AwsNative.SageMaker.Inputs.InferenceComponentCapacitySizeArgs @selfRef, global::Pulumi.AwsNative.SageMaker.InferenceComponentCapacitySizeType type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.InferenceComponentCapacitySizeArgs WithType(this global::Pulumi.AwsNative.SageMaker.Inputs.InferenceComponentCapacitySizeArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.SageMaker.InferenceComponentCapacitySizeType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.SageMaker.InferenceComponentCapacitySizeType>();
        @configure(@item);
        @selfRef.Type = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.InferenceComponentCapacitySizeArgs WithValue(this global::Pulumi.AwsNative.SageMaker.Inputs.InferenceComponentCapacitySizeArgs @selfRef, global::System.Int32 value)
    {
        @selfRef.Value = value;
        return @selfRef;
    }

}
