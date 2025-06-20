// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.SecurityInsights.Inputs;

namespace Pulumi.AzureNative.SecurityInsights;

public static partial class SapSystemsConfigurationArgsExtensions
{
    public static global::Pulumi.AzureNative.SecurityInsights.Inputs.SapSystemsConfigurationArgs WithAzureResourceId(this global::Pulumi.AzureNative.SecurityInsights.Inputs.SapSystemsConfigurationArgs @selfRef, global::System.String azureResourceId)
    {
        @selfRef.AzureResourceId = azureResourceId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.Inputs.SapSystemsConfigurationArgs WithConnector(this global::Pulumi.AzureNative.SecurityInsights.Inputs.SapSystemsConfigurationArgs @selfRef, global::Pulumi.Union<global::Pulumi.AzureNative.SecurityInsights.Inputs.RfcConnectorArgs, global::Pulumi.AzureNative.SecurityInsights.Inputs.SapControlConnectorArgs> connector)
    {
        @selfRef.Connector = connector;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.Inputs.SapSystemsConfigurationArgs WithLogs(this global::Pulumi.AzureNative.SecurityInsights.Inputs.SapSystemsConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.SecurityInsights.Inputs.LogArgs> logs)
    {
        @selfRef.Logs = logs;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.Inputs.SapSystemsConfigurationArgs WithLogs(this global::Pulumi.AzureNative.SecurityInsights.Inputs.SapSystemsConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.SecurityInsights.Inputs.LogArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.SecurityInsights.Inputs.LogArgs>();
        @configure(@list);
        @selfRef.Logs = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.Inputs.SapSystemsConfigurationArgs WithLogs(this global::Pulumi.AzureNative.SecurityInsights.Inputs.SapSystemsConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.SecurityInsights.Inputs.LogArgs>> @create)
    {
        @selfRef.Logs = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.Inputs.SapSystemsConfigurationArgs WithType(this global::Pulumi.AzureNative.SecurityInsights.Inputs.SapSystemsConfigurationArgs @selfRef, global::System.String type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

}
