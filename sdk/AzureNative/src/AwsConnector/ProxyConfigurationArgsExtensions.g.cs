// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class ProxyConfigurationArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ProxyConfigurationArgs WithContainerName(this global::Pulumi.AzureNative.AwsConnector.Inputs.ProxyConfigurationArgs @selfRef, global::System.String containerName)
    {
        @selfRef.ContainerName = containerName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ProxyConfigurationArgs WithProxyConfigurationProperties(this global::Pulumi.AzureNative.AwsConnector.Inputs.ProxyConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.KeyValuePairArgs> proxyConfigurationProperties)
    {
        @selfRef.ProxyConfigurationProperties = proxyConfigurationProperties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ProxyConfigurationArgs WithProxyConfigurationProperties(this global::Pulumi.AzureNative.AwsConnector.Inputs.ProxyConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.KeyValuePairArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.KeyValuePairArgs>();
        @configure(@list);
        @selfRef.ProxyConfigurationProperties = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ProxyConfigurationArgs WithProxyConfigurationProperties(this global::Pulumi.AzureNative.AwsConnector.Inputs.ProxyConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.AwsConnector.Inputs.KeyValuePairArgs>> @create)
    {
        @selfRef.ProxyConfigurationProperties = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ProxyConfigurationArgs WithType(this global::Pulumi.AzureNative.AwsConnector.Inputs.ProxyConfigurationArgs @selfRef, global::System.String type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

}
