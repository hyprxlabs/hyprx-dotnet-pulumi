// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.SageMaker.Inputs;

namespace Pulumi.AwsNative.SageMaker;

public static partial class DomainKernelGatewayAppSettingsArgsExtensions
{
    public static global::Pulumi.AwsNative.SageMaker.Inputs.DomainKernelGatewayAppSettingsArgs WithCustomImages(this global::Pulumi.AwsNative.SageMaker.Inputs.DomainKernelGatewayAppSettingsArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.SageMaker.Inputs.DomainCustomImageArgs> customImages)
    {
        @selfRef.CustomImages = customImages;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.DomainKernelGatewayAppSettingsArgs WithCustomImages(this global::Pulumi.AwsNative.SageMaker.Inputs.DomainKernelGatewayAppSettingsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.SageMaker.Inputs.DomainCustomImageArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.SageMaker.Inputs.DomainCustomImageArgs>();
        @configure(@list);
        @selfRef.CustomImages = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.DomainKernelGatewayAppSettingsArgs WithCustomImages(this global::Pulumi.AwsNative.SageMaker.Inputs.DomainKernelGatewayAppSettingsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.SageMaker.Inputs.DomainCustomImageArgs>> @create)
    {
        @selfRef.CustomImages = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.DomainKernelGatewayAppSettingsArgs WithDefaultResourceSpec(this global::Pulumi.AwsNative.SageMaker.Inputs.DomainKernelGatewayAppSettingsArgs @selfRef, global::Pulumi.AwsNative.SageMaker.Inputs.DomainResourceSpecArgs defaultResourceSpec)
    {
        @selfRef.DefaultResourceSpec = defaultResourceSpec;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.DomainKernelGatewayAppSettingsArgs WithDefaultResourceSpec(this global::Pulumi.AwsNative.SageMaker.Inputs.DomainKernelGatewayAppSettingsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.SageMaker.Inputs.DomainResourceSpecArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.SageMaker.Inputs.DomainResourceSpecArgs();
        @configure(@item);
        @selfRef.DefaultResourceSpec = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.DomainKernelGatewayAppSettingsArgs WithLifecycleConfigArns(this global::Pulumi.AwsNative.SageMaker.Inputs.DomainKernelGatewayAppSettingsArgs @selfRef, global::System.Collections.Generic.List<global::System.String> lifecycleConfigArns)
    {
        @selfRef.LifecycleConfigArns = lifecycleConfigArns;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.DomainKernelGatewayAppSettingsArgs WithLifecycleConfigArns(this global::Pulumi.AwsNative.SageMaker.Inputs.DomainKernelGatewayAppSettingsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.LifecycleConfigArns = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.DomainKernelGatewayAppSettingsArgs WithLifecycleConfigArns(this global::Pulumi.AwsNative.SageMaker.Inputs.DomainKernelGatewayAppSettingsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.LifecycleConfigArns = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
