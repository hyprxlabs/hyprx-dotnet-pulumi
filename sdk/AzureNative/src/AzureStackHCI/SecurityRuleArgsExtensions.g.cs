// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.AzureStackHCI;

public static partial class SecurityRuleArgsExtensions
{
    public static global::Pulumi.AzureNative.AzureStackHCI.SecurityRuleArgs WithAccess(this global::Pulumi.AzureNative.AzureStackHCI.SecurityRuleArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AzureStackHCI.SecurityRuleAccess> access)
    {
        @selfRef.Access = access;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.SecurityRuleArgs WithDescription(this global::Pulumi.AzureNative.AzureStackHCI.SecurityRuleArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.SecurityRuleArgs WithDestinationAddressPrefixes(this global::Pulumi.AzureNative.AzureStackHCI.SecurityRuleArgs @selfRef, global::System.Collections.Generic.List<global::System.String> destinationAddressPrefixes)
    {
        @selfRef.DestinationAddressPrefixes = destinationAddressPrefixes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.SecurityRuleArgs WithDestinationAddressPrefixes(this global::Pulumi.AzureNative.AzureStackHCI.SecurityRuleArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.DestinationAddressPrefixes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.SecurityRuleArgs WithDestinationAddressPrefixes(this global::Pulumi.AzureNative.AzureStackHCI.SecurityRuleArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.DestinationAddressPrefixes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.SecurityRuleArgs WithDestinationPortRanges(this global::Pulumi.AzureNative.AzureStackHCI.SecurityRuleArgs @selfRef, global::System.Collections.Generic.List<global::System.String> destinationPortRanges)
    {
        @selfRef.DestinationPortRanges = destinationPortRanges;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.SecurityRuleArgs WithDestinationPortRanges(this global::Pulumi.AzureNative.AzureStackHCI.SecurityRuleArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.DestinationPortRanges = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.SecurityRuleArgs WithDestinationPortRanges(this global::Pulumi.AzureNative.AzureStackHCI.SecurityRuleArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.DestinationPortRanges = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.SecurityRuleArgs WithDirection(this global::Pulumi.AzureNative.AzureStackHCI.SecurityRuleArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AzureStackHCI.SecurityRuleDirection> direction)
    {
        @selfRef.Direction = direction;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.SecurityRuleArgs WithExtendedLocation(this global::Pulumi.AzureNative.AzureStackHCI.SecurityRuleArgs @selfRef, global::Pulumi.AzureNative.AzureStackHCI.Inputs.ExtendedLocationArgs extendedLocation)
    {
        @selfRef.ExtendedLocation = extendedLocation;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.SecurityRuleArgs WithExtendedLocation(this global::Pulumi.AzureNative.AzureStackHCI.SecurityRuleArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AzureStackHCI.Inputs.ExtendedLocationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AzureStackHCI.Inputs.ExtendedLocationArgs();
        @configure(@item);
        @selfRef.ExtendedLocation = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.SecurityRuleArgs WithNetworkSecurityGroupName(this global::Pulumi.AzureNative.AzureStackHCI.SecurityRuleArgs @selfRef, global::System.String networkSecurityGroupName)
    {
        @selfRef.NetworkSecurityGroupName = networkSecurityGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.SecurityRuleArgs WithPriority(this global::Pulumi.AzureNative.AzureStackHCI.SecurityRuleArgs @selfRef, global::System.Int32 priority)
    {
        @selfRef.Priority = priority;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.SecurityRuleArgs WithProtocol(this global::Pulumi.AzureNative.AzureStackHCI.SecurityRuleArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AzureStackHCI.SecurityRuleProtocol> protocol)
    {
        @selfRef.Protocol = protocol;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.SecurityRuleArgs WithResourceGroupName(this global::Pulumi.AzureNative.AzureStackHCI.SecurityRuleArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.SecurityRuleArgs WithSecurityRuleName(this global::Pulumi.AzureNative.AzureStackHCI.SecurityRuleArgs @selfRef, global::System.String securityRuleName)
    {
        @selfRef.SecurityRuleName = securityRuleName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.SecurityRuleArgs WithSourceAddressPrefixes(this global::Pulumi.AzureNative.AzureStackHCI.SecurityRuleArgs @selfRef, global::System.Collections.Generic.List<global::System.String> sourceAddressPrefixes)
    {
        @selfRef.SourceAddressPrefixes = sourceAddressPrefixes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.SecurityRuleArgs WithSourceAddressPrefixes(this global::Pulumi.AzureNative.AzureStackHCI.SecurityRuleArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.SourceAddressPrefixes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.SecurityRuleArgs WithSourceAddressPrefixes(this global::Pulumi.AzureNative.AzureStackHCI.SecurityRuleArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.SourceAddressPrefixes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.SecurityRuleArgs WithSourcePortRanges(this global::Pulumi.AzureNative.AzureStackHCI.SecurityRuleArgs @selfRef, global::System.Collections.Generic.List<global::System.String> sourcePortRanges)
    {
        @selfRef.SourcePortRanges = sourcePortRanges;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.SecurityRuleArgs WithSourcePortRanges(this global::Pulumi.AzureNative.AzureStackHCI.SecurityRuleArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.SourcePortRanges = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.SecurityRuleArgs WithSourcePortRanges(this global::Pulumi.AzureNative.AzureStackHCI.SecurityRuleArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.SourcePortRanges = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
