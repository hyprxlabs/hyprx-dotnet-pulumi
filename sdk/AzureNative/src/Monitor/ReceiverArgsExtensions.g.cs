// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Monitor.Inputs;

namespace Pulumi.AzureNative.Monitor;

public static partial class ReceiverArgsExtensions
{
    public static global::Pulumi.AzureNative.Monitor.Inputs.ReceiverArgs WithName(this global::Pulumi.AzureNative.Monitor.Inputs.ReceiverArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.ReceiverArgs WithOtlp(this global::Pulumi.AzureNative.Monitor.Inputs.ReceiverArgs @selfRef, global::Pulumi.AzureNative.Monitor.Inputs.OtlpReceiverArgs otlp)
    {
        @selfRef.Otlp = otlp;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.ReceiverArgs WithOtlp(this global::Pulumi.AzureNative.Monitor.Inputs.ReceiverArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Monitor.Inputs.OtlpReceiverArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Monitor.Inputs.OtlpReceiverArgs();
        @configure(@item);
        @selfRef.Otlp = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.ReceiverArgs WithSyslog(this global::Pulumi.AzureNative.Monitor.Inputs.ReceiverArgs @selfRef, global::Pulumi.AzureNative.Monitor.Inputs.SyslogReceiverArgs syslog)
    {
        @selfRef.Syslog = syslog;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.ReceiverArgs WithSyslog(this global::Pulumi.AzureNative.Monitor.Inputs.ReceiverArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Monitor.Inputs.SyslogReceiverArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Monitor.Inputs.SyslogReceiverArgs();
        @configure(@item);
        @selfRef.Syslog = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.ReceiverArgs WithType(this global::Pulumi.AzureNative.Monitor.Inputs.ReceiverArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Monitor.ReceiverType> type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.ReceiverArgs WithUdp(this global::Pulumi.AzureNative.Monitor.Inputs.ReceiverArgs @selfRef, global::Pulumi.AzureNative.Monitor.Inputs.UdpReceiverArgs udp)
    {
        @selfRef.Udp = udp;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.ReceiverArgs WithUdp(this global::Pulumi.AzureNative.Monitor.Inputs.ReceiverArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Monitor.Inputs.UdpReceiverArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Monitor.Inputs.UdpReceiverArgs();
        @configure(@item);
        @selfRef.Udp = @item;
        return @selfRef;
    }

}
