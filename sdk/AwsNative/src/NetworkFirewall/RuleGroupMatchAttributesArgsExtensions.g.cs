// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.NetworkFirewall.Inputs;

namespace Pulumi.AwsNative.NetworkFirewall;

public static partial class RuleGroupMatchAttributesArgsExtensions
{
    public static global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupMatchAttributesArgs WithDestinationPorts(this global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupMatchAttributesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupPortRangeArgs> destinationPorts)
    {
        @selfRef.DestinationPorts = destinationPorts;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupMatchAttributesArgs WithDestinationPorts(this global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupMatchAttributesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupPortRangeArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupPortRangeArgs>();
        @configure(@list);
        @selfRef.DestinationPorts = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupMatchAttributesArgs WithDestinationPorts(this global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupMatchAttributesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupPortRangeArgs>> @create)
    {
        @selfRef.DestinationPorts = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupMatchAttributesArgs WithDestinations(this global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupMatchAttributesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupAddressArgs> destinations)
    {
        @selfRef.Destinations = destinations;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupMatchAttributesArgs WithDestinations(this global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupMatchAttributesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupAddressArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupAddressArgs>();
        @configure(@list);
        @selfRef.Destinations = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupMatchAttributesArgs WithDestinations(this global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupMatchAttributesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupAddressArgs>> @create)
    {
        @selfRef.Destinations = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupMatchAttributesArgs WithProtocols(this global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupMatchAttributesArgs @selfRef, global::System.Collections.Generic.List<global::System.Int32> protocols)
    {
        @selfRef.Protocols = protocols;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupMatchAttributesArgs WithProtocols(this global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupMatchAttributesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.Int32>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.Int32>();
        @configure(@list);
        @selfRef.Protocols = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupMatchAttributesArgs WithProtocols(this global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupMatchAttributesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.Int32>> @create)
    {
        @selfRef.Protocols = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupMatchAttributesArgs WithSourcePorts(this global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupMatchAttributesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupPortRangeArgs> sourcePorts)
    {
        @selfRef.SourcePorts = sourcePorts;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupMatchAttributesArgs WithSourcePorts(this global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupMatchAttributesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupPortRangeArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupPortRangeArgs>();
        @configure(@list);
        @selfRef.SourcePorts = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupMatchAttributesArgs WithSourcePorts(this global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupMatchAttributesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupPortRangeArgs>> @create)
    {
        @selfRef.SourcePorts = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupMatchAttributesArgs WithSources(this global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupMatchAttributesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupAddressArgs> sources)
    {
        @selfRef.Sources = sources;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupMatchAttributesArgs WithSources(this global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupMatchAttributesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupAddressArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupAddressArgs>();
        @configure(@list);
        @selfRef.Sources = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupMatchAttributesArgs WithSources(this global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupMatchAttributesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupAddressArgs>> @create)
    {
        @selfRef.Sources = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupMatchAttributesArgs WithTcpFlags(this global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupMatchAttributesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupTcpFlagFieldArgs> tcpFlags)
    {
        @selfRef.TcpFlags = tcpFlags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupMatchAttributesArgs WithTcpFlags(this global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupMatchAttributesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupTcpFlagFieldArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupTcpFlagFieldArgs>();
        @configure(@list);
        @selfRef.TcpFlags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupMatchAttributesArgs WithTcpFlags(this global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupMatchAttributesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupTcpFlagFieldArgs>> @create)
    {
        @selfRef.TcpFlags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
