// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.SageMaker.Inputs;

namespace Pulumi.AwsNative.SageMaker;

public static partial class AppImageConfigKernelGatewayImageConfigArgsExtensions
{
    public static global::Pulumi.AwsNative.SageMaker.Inputs.AppImageConfigKernelGatewayImageConfigArgs WithFileSystemConfig(this global::Pulumi.AwsNative.SageMaker.Inputs.AppImageConfigKernelGatewayImageConfigArgs @selfRef, global::Pulumi.AwsNative.SageMaker.Inputs.AppImageConfigFileSystemConfigArgs fileSystemConfig)
    {
        @selfRef.FileSystemConfig = fileSystemConfig;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.AppImageConfigKernelGatewayImageConfigArgs WithFileSystemConfig(this global::Pulumi.AwsNative.SageMaker.Inputs.AppImageConfigKernelGatewayImageConfigArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.SageMaker.Inputs.AppImageConfigFileSystemConfigArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.SageMaker.Inputs.AppImageConfigFileSystemConfigArgs();
        @configure(@item);
        @selfRef.FileSystemConfig = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.AppImageConfigKernelGatewayImageConfigArgs WithKernelSpecs(this global::Pulumi.AwsNative.SageMaker.Inputs.AppImageConfigKernelGatewayImageConfigArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.SageMaker.Inputs.AppImageConfigKernelSpecArgs> kernelSpecs)
    {
        @selfRef.KernelSpecs = kernelSpecs;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.AppImageConfigKernelGatewayImageConfigArgs WithKernelSpecs(this global::Pulumi.AwsNative.SageMaker.Inputs.AppImageConfigKernelGatewayImageConfigArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.SageMaker.Inputs.AppImageConfigKernelSpecArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.SageMaker.Inputs.AppImageConfigKernelSpecArgs>();
        @configure(@list);
        @selfRef.KernelSpecs = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.AppImageConfigKernelGatewayImageConfigArgs WithKernelSpecs(this global::Pulumi.AwsNative.SageMaker.Inputs.AppImageConfigKernelGatewayImageConfigArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.SageMaker.Inputs.AppImageConfigKernelSpecArgs>> @create)
    {
        @selfRef.KernelSpecs = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
