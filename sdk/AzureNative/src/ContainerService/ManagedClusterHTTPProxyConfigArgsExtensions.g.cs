// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.ContainerService.Inputs;

namespace Pulumi.AzureNative.ContainerService;

public static partial class ManagedClusterHTTPProxyConfigArgsExtensions
{
    public static global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterHTTPProxyConfigArgs WithHttpProxy(this global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterHTTPProxyConfigArgs @selfRef, global::System.String httpProxy)
    {
        @selfRef.HttpProxy = httpProxy;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterHTTPProxyConfigArgs WithHttpsProxy(this global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterHTTPProxyConfigArgs @selfRef, global::System.String httpsProxy)
    {
        @selfRef.HttpsProxy = httpsProxy;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterHTTPProxyConfigArgs WithNoProxy(this global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterHTTPProxyConfigArgs @selfRef, global::System.Collections.Generic.List<global::System.String> noProxy)
    {
        @selfRef.NoProxy = noProxy;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterHTTPProxyConfigArgs WithNoProxy(this global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterHTTPProxyConfigArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.NoProxy = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterHTTPProxyConfigArgs WithNoProxy(this global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterHTTPProxyConfigArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.NoProxy = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterHTTPProxyConfigArgs WithTrustedCa(this global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterHTTPProxyConfigArgs @selfRef, global::System.String trustedCa)
    {
        @selfRef.TrustedCa = trustedCa;
        return @selfRef;
    }

}
