// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Ec2.Inputs;

namespace Pulumi.AwsNative.Ec2;

public static partial class VpcEndpointDnsOptionsSpecificationArgsExtensions
{
    public static global::Pulumi.AwsNative.Ec2.Inputs.VpcEndpointDnsOptionsSpecificationArgs WithDnsRecordIpType(this global::Pulumi.AwsNative.Ec2.Inputs.VpcEndpointDnsOptionsSpecificationArgs @selfRef, global::Pulumi.AwsNative.Ec2.VpcEndpointDnsOptionsSpecificationDnsRecordIpType dnsRecordIpType)
    {
        @selfRef.DnsRecordIpType = dnsRecordIpType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.VpcEndpointDnsOptionsSpecificationArgs WithDnsRecordIpType(this global::Pulumi.AwsNative.Ec2.Inputs.VpcEndpointDnsOptionsSpecificationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Ec2.VpcEndpointDnsOptionsSpecificationDnsRecordIpType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Ec2.VpcEndpointDnsOptionsSpecificationDnsRecordIpType>();
        @configure(@item);
        @selfRef.DnsRecordIpType = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.VpcEndpointDnsOptionsSpecificationArgs WithPrivateDnsOnlyForInboundResolverEndpoint(this global::Pulumi.AwsNative.Ec2.Inputs.VpcEndpointDnsOptionsSpecificationArgs @selfRef, global::Pulumi.AwsNative.Ec2.VpcEndpointDnsOptionsSpecificationPrivateDnsOnlyForInboundResolverEndpoint privateDnsOnlyForInboundResolverEndpoint)
    {
        @selfRef.PrivateDnsOnlyForInboundResolverEndpoint = privateDnsOnlyForInboundResolverEndpoint;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.VpcEndpointDnsOptionsSpecificationArgs WithPrivateDnsOnlyForInboundResolverEndpoint(this global::Pulumi.AwsNative.Ec2.Inputs.VpcEndpointDnsOptionsSpecificationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Ec2.VpcEndpointDnsOptionsSpecificationPrivateDnsOnlyForInboundResolverEndpoint> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Ec2.VpcEndpointDnsOptionsSpecificationPrivateDnsOnlyForInboundResolverEndpoint>();
        @configure(@item);
        @selfRef.PrivateDnsOnlyForInboundResolverEndpoint = @item;
        return @selfRef;
    }

}
