// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.ContainerInstance.Inputs;

namespace Pulumi.AzureNative.ContainerInstance;

public static partial class ContainerHttpGetArgsExtensions
{
    public static global::Pulumi.AzureNative.ContainerInstance.Inputs.ContainerHttpGetArgs WithHttpHeaders(this global::Pulumi.AzureNative.ContainerInstance.Inputs.ContainerHttpGetArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.ContainerInstance.Inputs.HttpHeaderArgs> httpHeaders)
    {
        @selfRef.HttpHeaders = httpHeaders;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerInstance.Inputs.ContainerHttpGetArgs WithHttpHeaders(this global::Pulumi.AzureNative.ContainerInstance.Inputs.ContainerHttpGetArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.ContainerInstance.Inputs.HttpHeaderArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.ContainerInstance.Inputs.HttpHeaderArgs>();
        @configure(@list);
        @selfRef.HttpHeaders = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerInstance.Inputs.ContainerHttpGetArgs WithHttpHeaders(this global::Pulumi.AzureNative.ContainerInstance.Inputs.ContainerHttpGetArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.ContainerInstance.Inputs.HttpHeaderArgs>> @create)
    {
        @selfRef.HttpHeaders = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerInstance.Inputs.ContainerHttpGetArgs WithPath(this global::Pulumi.AzureNative.ContainerInstance.Inputs.ContainerHttpGetArgs @selfRef, global::System.String path)
    {
        @selfRef.Path = path;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerInstance.Inputs.ContainerHttpGetArgs WithPort(this global::Pulumi.AzureNative.ContainerInstance.Inputs.ContainerHttpGetArgs @selfRef, global::System.Int32 port)
    {
        @selfRef.Port = port;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerInstance.Inputs.ContainerHttpGetArgs WithScheme(this global::Pulumi.AzureNative.ContainerInstance.Inputs.ContainerHttpGetArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.ContainerInstance.Scheme> scheme)
    {
        @selfRef.Scheme = scheme;
        return @selfRef;
    }

}
