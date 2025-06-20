// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.SageMaker;

public static partial class ModelPackageGroupArgsExtensions
{
    public static global::Pulumi.AwsNative.SageMaker.ModelPackageGroupArgs WithModelPackageGroupDescription(this global::Pulumi.AwsNative.SageMaker.ModelPackageGroupArgs @selfRef, global::System.String modelPackageGroupDescription)
    {
        @selfRef.ModelPackageGroupDescription = modelPackageGroupDescription;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.ModelPackageGroupArgs WithModelPackageGroupName(this global::Pulumi.AwsNative.SageMaker.ModelPackageGroupArgs @selfRef, global::System.String modelPackageGroupName)
    {
        @selfRef.ModelPackageGroupName = modelPackageGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.ModelPackageGroupArgs WithModelPackageGroupPolicy(this global::Pulumi.AwsNative.SageMaker.ModelPackageGroupArgs @selfRef, global::System.Object modelPackageGroupPolicy)
    {
        @selfRef.ModelPackageGroupPolicy = modelPackageGroupPolicy;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.ModelPackageGroupArgs WithModelPackageGroupPolicy(this global::Pulumi.AwsNative.SageMaker.ModelPackageGroupArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.ModelPackageGroupPolicy = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.ModelPackageGroupArgs WithTags(this global::Pulumi.AwsNative.SageMaker.ModelPackageGroupArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.ModelPackageGroupArgs WithTags(this global::Pulumi.AwsNative.SageMaker.ModelPackageGroupArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.ModelPackageGroupArgs WithTags(this global::Pulumi.AwsNative.SageMaker.ModelPackageGroupArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
