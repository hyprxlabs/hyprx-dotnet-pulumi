// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.SageMaker;

public static partial class ModelCardArgsExtensions
{
    public static global::Pulumi.AwsNative.SageMaker.ModelCardArgs WithContent(this global::Pulumi.AwsNative.SageMaker.ModelCardArgs @selfRef, global::Pulumi.AwsNative.SageMaker.Inputs.ModelCardContentArgs content)
    {
        @selfRef.Content = content;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.ModelCardArgs WithContent(this global::Pulumi.AwsNative.SageMaker.ModelCardArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.SageMaker.Inputs.ModelCardContentArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.SageMaker.Inputs.ModelCardContentArgs();
        @configure(@item);
        @selfRef.Content = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.ModelCardArgs WithCreatedBy(this global::Pulumi.AwsNative.SageMaker.ModelCardArgs @selfRef, global::Pulumi.AwsNative.SageMaker.Inputs.ModelCardUserContextArgs createdBy)
    {
        @selfRef.CreatedBy = createdBy;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.ModelCardArgs WithCreatedBy(this global::Pulumi.AwsNative.SageMaker.ModelCardArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.SageMaker.Inputs.ModelCardUserContextArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.SageMaker.Inputs.ModelCardUserContextArgs();
        @configure(@item);
        @selfRef.CreatedBy = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.ModelCardArgs WithLastModifiedBy(this global::Pulumi.AwsNative.SageMaker.ModelCardArgs @selfRef, global::Pulumi.AwsNative.SageMaker.Inputs.ModelCardUserContextArgs lastModifiedBy)
    {
        @selfRef.LastModifiedBy = lastModifiedBy;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.ModelCardArgs WithLastModifiedBy(this global::Pulumi.AwsNative.SageMaker.ModelCardArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.SageMaker.Inputs.ModelCardUserContextArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.SageMaker.Inputs.ModelCardUserContextArgs();
        @configure(@item);
        @selfRef.LastModifiedBy = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.ModelCardArgs WithModelCardName(this global::Pulumi.AwsNative.SageMaker.ModelCardArgs @selfRef, global::System.String modelCardName)
    {
        @selfRef.ModelCardName = modelCardName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.ModelCardArgs WithModelCardStatus(this global::Pulumi.AwsNative.SageMaker.ModelCardArgs @selfRef, global::Pulumi.AwsNative.SageMaker.ModelCardStatus modelCardStatus)
    {
        @selfRef.ModelCardStatus = modelCardStatus;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.ModelCardArgs WithModelCardStatus(this global::Pulumi.AwsNative.SageMaker.ModelCardArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.SageMaker.ModelCardStatus> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.SageMaker.ModelCardStatus>();
        @configure(@item);
        @selfRef.ModelCardStatus = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.ModelCardArgs WithSecurityConfig(this global::Pulumi.AwsNative.SageMaker.ModelCardArgs @selfRef, global::Pulumi.AwsNative.SageMaker.Inputs.ModelCardSecurityConfigArgs securityConfig)
    {
        @selfRef.SecurityConfig = securityConfig;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.ModelCardArgs WithSecurityConfig(this global::Pulumi.AwsNative.SageMaker.ModelCardArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.SageMaker.Inputs.ModelCardSecurityConfigArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.SageMaker.Inputs.ModelCardSecurityConfigArgs();
        @configure(@item);
        @selfRef.SecurityConfig = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.ModelCardArgs WithTags(this global::Pulumi.AwsNative.SageMaker.ModelCardArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.ModelCardArgs WithTags(this global::Pulumi.AwsNative.SageMaker.ModelCardArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.ModelCardArgs WithTags(this global::Pulumi.AwsNative.SageMaker.ModelCardArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
