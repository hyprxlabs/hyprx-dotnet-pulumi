// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Ec2.Inputs;

namespace Pulumi.AwsNative.Ec2;

public static partial class NetworkInsightsAccessScopePacketHeaderStatementRequestArgsExtensions
{
    public static global::Pulumi.AwsNative.Ec2.Inputs.NetworkInsightsAccessScopePacketHeaderStatementRequestArgs WithDestinationAddresses(this global::Pulumi.AwsNative.Ec2.Inputs.NetworkInsightsAccessScopePacketHeaderStatementRequestArgs @selfRef, global::System.Collections.Generic.List<global::System.String> destinationAddresses)
    {
        @selfRef.DestinationAddresses = destinationAddresses;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.NetworkInsightsAccessScopePacketHeaderStatementRequestArgs WithDestinationAddresses(this global::Pulumi.AwsNative.Ec2.Inputs.NetworkInsightsAccessScopePacketHeaderStatementRequestArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.DestinationAddresses = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.NetworkInsightsAccessScopePacketHeaderStatementRequestArgs WithDestinationAddresses(this global::Pulumi.AwsNative.Ec2.Inputs.NetworkInsightsAccessScopePacketHeaderStatementRequestArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.DestinationAddresses = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.NetworkInsightsAccessScopePacketHeaderStatementRequestArgs WithDestinationPorts(this global::Pulumi.AwsNative.Ec2.Inputs.NetworkInsightsAccessScopePacketHeaderStatementRequestArgs @selfRef, global::System.Collections.Generic.List<global::System.String> destinationPorts)
    {
        @selfRef.DestinationPorts = destinationPorts;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.NetworkInsightsAccessScopePacketHeaderStatementRequestArgs WithDestinationPorts(this global::Pulumi.AwsNative.Ec2.Inputs.NetworkInsightsAccessScopePacketHeaderStatementRequestArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.DestinationPorts = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.NetworkInsightsAccessScopePacketHeaderStatementRequestArgs WithDestinationPorts(this global::Pulumi.AwsNative.Ec2.Inputs.NetworkInsightsAccessScopePacketHeaderStatementRequestArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.DestinationPorts = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.NetworkInsightsAccessScopePacketHeaderStatementRequestArgs WithDestinationPrefixLists(this global::Pulumi.AwsNative.Ec2.Inputs.NetworkInsightsAccessScopePacketHeaderStatementRequestArgs @selfRef, global::System.Collections.Generic.List<global::System.String> destinationPrefixLists)
    {
        @selfRef.DestinationPrefixLists = destinationPrefixLists;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.NetworkInsightsAccessScopePacketHeaderStatementRequestArgs WithDestinationPrefixLists(this global::Pulumi.AwsNative.Ec2.Inputs.NetworkInsightsAccessScopePacketHeaderStatementRequestArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.DestinationPrefixLists = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.NetworkInsightsAccessScopePacketHeaderStatementRequestArgs WithDestinationPrefixLists(this global::Pulumi.AwsNative.Ec2.Inputs.NetworkInsightsAccessScopePacketHeaderStatementRequestArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.DestinationPrefixLists = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.NetworkInsightsAccessScopePacketHeaderStatementRequestArgs WithProtocols(this global::Pulumi.AwsNative.Ec2.Inputs.NetworkInsightsAccessScopePacketHeaderStatementRequestArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ec2.NetworkInsightsAccessScopeProtocol> protocols)
    {
        @selfRef.Protocols = protocols;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.NetworkInsightsAccessScopePacketHeaderStatementRequestArgs WithProtocols(this global::Pulumi.AwsNative.Ec2.Inputs.NetworkInsightsAccessScopePacketHeaderStatementRequestArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ec2.NetworkInsightsAccessScopeProtocol>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ec2.NetworkInsightsAccessScopeProtocol>();
        @configure(@list);
        @selfRef.Protocols = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.NetworkInsightsAccessScopePacketHeaderStatementRequestArgs WithProtocols(this global::Pulumi.AwsNative.Ec2.Inputs.NetworkInsightsAccessScopePacketHeaderStatementRequestArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Ec2.NetworkInsightsAccessScopeProtocol>> @create)
    {
        @selfRef.Protocols = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.NetworkInsightsAccessScopePacketHeaderStatementRequestArgs WithSourceAddresses(this global::Pulumi.AwsNative.Ec2.Inputs.NetworkInsightsAccessScopePacketHeaderStatementRequestArgs @selfRef, global::System.Collections.Generic.List<global::System.String> sourceAddresses)
    {
        @selfRef.SourceAddresses = sourceAddresses;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.NetworkInsightsAccessScopePacketHeaderStatementRequestArgs WithSourceAddresses(this global::Pulumi.AwsNative.Ec2.Inputs.NetworkInsightsAccessScopePacketHeaderStatementRequestArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.SourceAddresses = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.NetworkInsightsAccessScopePacketHeaderStatementRequestArgs WithSourceAddresses(this global::Pulumi.AwsNative.Ec2.Inputs.NetworkInsightsAccessScopePacketHeaderStatementRequestArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.SourceAddresses = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.NetworkInsightsAccessScopePacketHeaderStatementRequestArgs WithSourcePorts(this global::Pulumi.AwsNative.Ec2.Inputs.NetworkInsightsAccessScopePacketHeaderStatementRequestArgs @selfRef, global::System.Collections.Generic.List<global::System.String> sourcePorts)
    {
        @selfRef.SourcePorts = sourcePorts;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.NetworkInsightsAccessScopePacketHeaderStatementRequestArgs WithSourcePorts(this global::Pulumi.AwsNative.Ec2.Inputs.NetworkInsightsAccessScopePacketHeaderStatementRequestArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.SourcePorts = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.NetworkInsightsAccessScopePacketHeaderStatementRequestArgs WithSourcePorts(this global::Pulumi.AwsNative.Ec2.Inputs.NetworkInsightsAccessScopePacketHeaderStatementRequestArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.SourcePorts = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.NetworkInsightsAccessScopePacketHeaderStatementRequestArgs WithSourcePrefixLists(this global::Pulumi.AwsNative.Ec2.Inputs.NetworkInsightsAccessScopePacketHeaderStatementRequestArgs @selfRef, global::System.Collections.Generic.List<global::System.String> sourcePrefixLists)
    {
        @selfRef.SourcePrefixLists = sourcePrefixLists;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.NetworkInsightsAccessScopePacketHeaderStatementRequestArgs WithSourcePrefixLists(this global::Pulumi.AwsNative.Ec2.Inputs.NetworkInsightsAccessScopePacketHeaderStatementRequestArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.SourcePrefixLists = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.NetworkInsightsAccessScopePacketHeaderStatementRequestArgs WithSourcePrefixLists(this global::Pulumi.AwsNative.Ec2.Inputs.NetworkInsightsAccessScopePacketHeaderStatementRequestArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.SourcePrefixLists = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
