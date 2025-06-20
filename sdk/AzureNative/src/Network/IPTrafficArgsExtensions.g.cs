// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Network.Inputs;

namespace Pulumi.AzureNative.Network;

public static partial class IPTrafficArgsExtensions
{
    public static global::Pulumi.AzureNative.Network.Inputs.IPTrafficArgs WithDestinationIps(this global::Pulumi.AzureNative.Network.Inputs.IPTrafficArgs @selfRef, global::System.Collections.Generic.List<global::System.String> destinationIps)
    {
        @selfRef.DestinationIps = destinationIps;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.IPTrafficArgs WithDestinationIps(this global::Pulumi.AzureNative.Network.Inputs.IPTrafficArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.DestinationIps = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.IPTrafficArgs WithDestinationIps(this global::Pulumi.AzureNative.Network.Inputs.IPTrafficArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.DestinationIps = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.IPTrafficArgs WithDestinationPorts(this global::Pulumi.AzureNative.Network.Inputs.IPTrafficArgs @selfRef, global::System.Collections.Generic.List<global::System.String> destinationPorts)
    {
        @selfRef.DestinationPorts = destinationPorts;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.IPTrafficArgs WithDestinationPorts(this global::Pulumi.AzureNative.Network.Inputs.IPTrafficArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.DestinationPorts = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.IPTrafficArgs WithDestinationPorts(this global::Pulumi.AzureNative.Network.Inputs.IPTrafficArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.DestinationPorts = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.IPTrafficArgs WithProtocols(this global::Pulumi.AzureNative.Network.Inputs.IPTrafficArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Network.NetworkProtocol>> protocols)
    {
        @selfRef.Protocols = protocols;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.IPTrafficArgs WithProtocols(this global::Pulumi.AzureNative.Network.Inputs.IPTrafficArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Network.NetworkProtocol>>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Network.NetworkProtocol>>();
        @configure(@list);
        @selfRef.Protocols = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.IPTrafficArgs WithProtocols(this global::Pulumi.AzureNative.Network.Inputs.IPTrafficArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Network.NetworkProtocol>>> @create)
    {
        @selfRef.Protocols = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.IPTrafficArgs WithSourceIps(this global::Pulumi.AzureNative.Network.Inputs.IPTrafficArgs @selfRef, global::System.Collections.Generic.List<global::System.String> sourceIps)
    {
        @selfRef.SourceIps = sourceIps;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.IPTrafficArgs WithSourceIps(this global::Pulumi.AzureNative.Network.Inputs.IPTrafficArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.SourceIps = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.IPTrafficArgs WithSourceIps(this global::Pulumi.AzureNative.Network.Inputs.IPTrafficArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.SourceIps = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.IPTrafficArgs WithSourcePorts(this global::Pulumi.AzureNative.Network.Inputs.IPTrafficArgs @selfRef, global::System.Collections.Generic.List<global::System.String> sourcePorts)
    {
        @selfRef.SourcePorts = sourcePorts;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.IPTrafficArgs WithSourcePorts(this global::Pulumi.AzureNative.Network.Inputs.IPTrafficArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.SourcePorts = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.IPTrafficArgs WithSourcePorts(this global::Pulumi.AzureNative.Network.Inputs.IPTrafficArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.SourcePorts = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
