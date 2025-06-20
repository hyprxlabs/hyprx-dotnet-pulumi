// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Monitor.Inputs;

namespace Pulumi.AzureNative.Monitor;

public static partial class WindowsFirewallLogsDataSourceArgsExtensions
{
    public static global::Pulumi.AzureNative.Monitor.Inputs.WindowsFirewallLogsDataSourceArgs WithName(this global::Pulumi.AzureNative.Monitor.Inputs.WindowsFirewallLogsDataSourceArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.WindowsFirewallLogsDataSourceArgs WithStreams(this global::Pulumi.AzureNative.Monitor.Inputs.WindowsFirewallLogsDataSourceArgs @selfRef, global::System.Collections.Generic.List<global::System.String> streams)
    {
        @selfRef.Streams = streams;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.WindowsFirewallLogsDataSourceArgs WithStreams(this global::Pulumi.AzureNative.Monitor.Inputs.WindowsFirewallLogsDataSourceArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Streams = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.WindowsFirewallLogsDataSourceArgs WithStreams(this global::Pulumi.AzureNative.Monitor.Inputs.WindowsFirewallLogsDataSourceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Streams = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
