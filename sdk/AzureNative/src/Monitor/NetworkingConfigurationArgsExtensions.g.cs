// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Monitor.Inputs;

namespace Pulumi.AzureNative.Monitor;

public static partial class NetworkingConfigurationArgsExtensions
{
    public static global::Pulumi.AzureNative.Monitor.Inputs.NetworkingConfigurationArgs WithExternalNetworkingMode(this global::Pulumi.AzureNative.Monitor.Inputs.NetworkingConfigurationArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Monitor.ExternalNetworkingMode> externalNetworkingMode)
    {
        @selfRef.ExternalNetworkingMode = externalNetworkingMode;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.NetworkingConfigurationArgs WithHost(this global::Pulumi.AzureNative.Monitor.Inputs.NetworkingConfigurationArgs @selfRef, global::System.String host)
    {
        @selfRef.Host = host;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.NetworkingConfigurationArgs WithRoutes(this global::Pulumi.AzureNative.Monitor.Inputs.NetworkingConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Monitor.Inputs.NetworkingRouteArgs> routes)
    {
        @selfRef.Routes = routes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.NetworkingConfigurationArgs WithRoutes(this global::Pulumi.AzureNative.Monitor.Inputs.NetworkingConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Monitor.Inputs.NetworkingRouteArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Monitor.Inputs.NetworkingRouteArgs>();
        @configure(@list);
        @selfRef.Routes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.NetworkingConfigurationArgs WithRoutes(this global::Pulumi.AzureNative.Monitor.Inputs.NetworkingConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Monitor.Inputs.NetworkingRouteArgs>> @create)
    {
        @selfRef.Routes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
