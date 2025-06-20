// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Ec2.Inputs;

namespace Pulumi.AwsNative.Ec2;

public static partial class LaunchTemplateNetworkInterfaceArgsExtensions
{
    public static global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs WithAssociateCarrierIpAddress(this global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs @selfRef, bool associateCarrierIpAddress = true)
    {
        @selfRef.AssociateCarrierIpAddress = associateCarrierIpAddress;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs WithAssociatePublicIpAddress(this global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs @selfRef, bool associatePublicIpAddress = true)
    {
        @selfRef.AssociatePublicIpAddress = associatePublicIpAddress;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs WithConnectionTrackingSpecification(this global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs @selfRef, global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateConnectionTrackingSpecificationArgs connectionTrackingSpecification)
    {
        @selfRef.ConnectionTrackingSpecification = connectionTrackingSpecification;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs WithConnectionTrackingSpecification(this global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateConnectionTrackingSpecificationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateConnectionTrackingSpecificationArgs();
        @configure(@item);
        @selfRef.ConnectionTrackingSpecification = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs WithDeleteOnTermination(this global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs @selfRef, bool deleteOnTermination = true)
    {
        @selfRef.DeleteOnTermination = deleteOnTermination;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs WithDescription(this global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs WithDeviceIndex(this global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs @selfRef, global::System.Int32 deviceIndex)
    {
        @selfRef.DeviceIndex = deviceIndex;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs WithEnaSrdSpecification(this global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs @selfRef, global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateEnaSrdSpecificationArgs enaSrdSpecification)
    {
        @selfRef.EnaSrdSpecification = enaSrdSpecification;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs WithEnaSrdSpecification(this global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateEnaSrdSpecificationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateEnaSrdSpecificationArgs();
        @configure(@item);
        @selfRef.EnaSrdSpecification = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs WithGroups(this global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs @selfRef, global::System.Collections.Generic.List<global::System.String> groups)
    {
        @selfRef.Groups = groups;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs WithGroups(this global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Groups = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs WithGroups(this global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Groups = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs WithInterfaceType(this global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs @selfRef, global::System.String interfaceType)
    {
        @selfRef.InterfaceType = interfaceType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs WithIpv4PrefixCount(this global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs @selfRef, global::System.Int32 ipv4PrefixCount)
    {
        @selfRef.Ipv4PrefixCount = ipv4PrefixCount;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs WithIpv4Prefixes(this global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateIpv4PrefixSpecificationArgs> ipv4Prefixes)
    {
        @selfRef.Ipv4Prefixes = ipv4Prefixes;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs WithIpv4Prefixes(this global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateIpv4PrefixSpecificationArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateIpv4PrefixSpecificationArgs>();
        @configure(@list);
        @selfRef.Ipv4Prefixes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs WithIpv4Prefixes(this global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateIpv4PrefixSpecificationArgs>> @create)
    {
        @selfRef.Ipv4Prefixes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs WithIpv6AddressCount(this global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs @selfRef, global::System.Int32 ipv6AddressCount)
    {
        @selfRef.Ipv6AddressCount = ipv6AddressCount;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs WithIpv6Addresses(this global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateIpv6AddArgs> ipv6Addresses)
    {
        @selfRef.Ipv6Addresses = ipv6Addresses;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs WithIpv6Addresses(this global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateIpv6AddArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateIpv6AddArgs>();
        @configure(@list);
        @selfRef.Ipv6Addresses = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs WithIpv6Addresses(this global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateIpv6AddArgs>> @create)
    {
        @selfRef.Ipv6Addresses = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs WithIpv6PrefixCount(this global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs @selfRef, global::System.Int32 ipv6PrefixCount)
    {
        @selfRef.Ipv6PrefixCount = ipv6PrefixCount;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs WithIpv6Prefixes(this global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateIpv6PrefixSpecificationArgs> ipv6Prefixes)
    {
        @selfRef.Ipv6Prefixes = ipv6Prefixes;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs WithIpv6Prefixes(this global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateIpv6PrefixSpecificationArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateIpv6PrefixSpecificationArgs>();
        @configure(@list);
        @selfRef.Ipv6Prefixes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs WithIpv6Prefixes(this global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateIpv6PrefixSpecificationArgs>> @create)
    {
        @selfRef.Ipv6Prefixes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs WithNetworkCardIndex(this global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs @selfRef, global::System.Int32 networkCardIndex)
    {
        @selfRef.NetworkCardIndex = networkCardIndex;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs WithNetworkInterfaceId(this global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs @selfRef, global::System.String networkInterfaceId)
    {
        @selfRef.NetworkInterfaceId = networkInterfaceId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs WithPrimaryIpv6(this global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs @selfRef, bool primaryIpv6 = true)
    {
        @selfRef.PrimaryIpv6 = primaryIpv6;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs WithPrivateIpAddress(this global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs @selfRef, global::System.String privateIpAddress)
    {
        @selfRef.PrivateIpAddress = privateIpAddress;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs WithPrivateIpAddresses(this global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplatePrivateIpAddArgs> privateIpAddresses)
    {
        @selfRef.PrivateIpAddresses = privateIpAddresses;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs WithPrivateIpAddresses(this global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplatePrivateIpAddArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplatePrivateIpAddArgs>();
        @configure(@list);
        @selfRef.PrivateIpAddresses = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs WithPrivateIpAddresses(this global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplatePrivateIpAddArgs>> @create)
    {
        @selfRef.PrivateIpAddresses = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs WithSecondaryPrivateIpAddressCount(this global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs @selfRef, global::System.Int32 secondaryPrivateIpAddressCount)
    {
        @selfRef.SecondaryPrivateIpAddressCount = secondaryPrivateIpAddressCount;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs WithSubnetId(this global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateNetworkInterfaceArgs @selfRef, global::System.String subnetId)
    {
        @selfRef.SubnetId = subnetId;
        return @selfRef;
    }

}
