// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.S3.Inputs;

namespace Pulumi.AwsNative.S3;

public static partial class BucketTransitionArgsExtensions
{
    public static global::Pulumi.AwsNative.S3.Inputs.BucketTransitionArgs WithStorageClass(this global::Pulumi.AwsNative.S3.Inputs.BucketTransitionArgs @selfRef, global::Pulumi.AwsNative.S3.BucketTransitionStorageClass storageClass)
    {
        @selfRef.StorageClass = storageClass;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.S3.Inputs.BucketTransitionArgs WithStorageClass(this global::Pulumi.AwsNative.S3.Inputs.BucketTransitionArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.S3.BucketTransitionStorageClass> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.S3.BucketTransitionStorageClass>();
        @configure(@item);
        @selfRef.StorageClass = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.S3.Inputs.BucketTransitionArgs WithTransitionDate(this global::Pulumi.AwsNative.S3.Inputs.BucketTransitionArgs @selfRef, global::System.String transitionDate)
    {
        @selfRef.TransitionDate = transitionDate;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.S3.Inputs.BucketTransitionArgs WithTransitionInDays(this global::Pulumi.AwsNative.S3.Inputs.BucketTransitionArgs @selfRef, global::System.Int32 transitionInDays)
    {
        @selfRef.TransitionInDays = transitionInDays;
        return @selfRef;
    }

}
