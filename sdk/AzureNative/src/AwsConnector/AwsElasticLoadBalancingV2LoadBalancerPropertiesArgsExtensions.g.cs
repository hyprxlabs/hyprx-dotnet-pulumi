// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class AwsElasticLoadBalancingV2LoadBalancerPropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingV2LoadBalancerPropertiesArgs WithCanonicalHostedZoneID(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingV2LoadBalancerPropertiesArgs @selfRef, global::System.String canonicalHostedZoneID)
    {
        @selfRef.CanonicalHostedZoneID = canonicalHostedZoneID;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingV2LoadBalancerPropertiesArgs WithDnsName(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingV2LoadBalancerPropertiesArgs @selfRef, global::System.String dnsName)
    {
        @selfRef.DnsName = dnsName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingV2LoadBalancerPropertiesArgs WithEnforceSecurityGroupInboundRulesOnPrivateLinkTraffic(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingV2LoadBalancerPropertiesArgs @selfRef, global::System.String enforceSecurityGroupInboundRulesOnPrivateLinkTraffic)
    {
        @selfRef.EnforceSecurityGroupInboundRulesOnPrivateLinkTraffic = enforceSecurityGroupInboundRulesOnPrivateLinkTraffic;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingV2LoadBalancerPropertiesArgs WithIpAddressType(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingV2LoadBalancerPropertiesArgs @selfRef, global::System.String ipAddressType)
    {
        @selfRef.IpAddressType = ipAddressType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingV2LoadBalancerPropertiesArgs WithLoadBalancerArn(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingV2LoadBalancerPropertiesArgs @selfRef, global::System.String loadBalancerArn)
    {
        @selfRef.LoadBalancerArn = loadBalancerArn;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingV2LoadBalancerPropertiesArgs WithLoadBalancerAttributes(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingV2LoadBalancerPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.LoadBalancerAttributeArgs> loadBalancerAttributes)
    {
        @selfRef.LoadBalancerAttributes = loadBalancerAttributes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingV2LoadBalancerPropertiesArgs WithLoadBalancerAttributes(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingV2LoadBalancerPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.LoadBalancerAttributeArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.LoadBalancerAttributeArgs>();
        @configure(@list);
        @selfRef.LoadBalancerAttributes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingV2LoadBalancerPropertiesArgs WithLoadBalancerAttributes(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingV2LoadBalancerPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.AwsConnector.Inputs.LoadBalancerAttributeArgs>> @create)
    {
        @selfRef.LoadBalancerAttributes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingV2LoadBalancerPropertiesArgs WithLoadBalancerFullName(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingV2LoadBalancerPropertiesArgs @selfRef, global::System.String loadBalancerFullName)
    {
        @selfRef.LoadBalancerFullName = loadBalancerFullName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingV2LoadBalancerPropertiesArgs WithLoadBalancerName(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingV2LoadBalancerPropertiesArgs @selfRef, global::System.String loadBalancerName)
    {
        @selfRef.LoadBalancerName = loadBalancerName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingV2LoadBalancerPropertiesArgs WithName(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingV2LoadBalancerPropertiesArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingV2LoadBalancerPropertiesArgs WithScheme(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingV2LoadBalancerPropertiesArgs @selfRef, global::System.String scheme)
    {
        @selfRef.Scheme = scheme;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingV2LoadBalancerPropertiesArgs WithSecurityGroups(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingV2LoadBalancerPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::System.String> securityGroups)
    {
        @selfRef.SecurityGroups = securityGroups;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingV2LoadBalancerPropertiesArgs WithSecurityGroups(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingV2LoadBalancerPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.SecurityGroups = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingV2LoadBalancerPropertiesArgs WithSecurityGroups(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingV2LoadBalancerPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.SecurityGroups = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingV2LoadBalancerPropertiesArgs WithSubnetMappings(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingV2LoadBalancerPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.SubnetMappingArgs> subnetMappings)
    {
        @selfRef.SubnetMappings = subnetMappings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingV2LoadBalancerPropertiesArgs WithSubnetMappings(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingV2LoadBalancerPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.SubnetMappingArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.SubnetMappingArgs>();
        @configure(@list);
        @selfRef.SubnetMappings = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingV2LoadBalancerPropertiesArgs WithSubnetMappings(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingV2LoadBalancerPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.AwsConnector.Inputs.SubnetMappingArgs>> @create)
    {
        @selfRef.SubnetMappings = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingV2LoadBalancerPropertiesArgs WithSubnets(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingV2LoadBalancerPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::System.String> subnets)
    {
        @selfRef.Subnets = subnets;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingV2LoadBalancerPropertiesArgs WithSubnets(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingV2LoadBalancerPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Subnets = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingV2LoadBalancerPropertiesArgs WithSubnets(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingV2LoadBalancerPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Subnets = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingV2LoadBalancerPropertiesArgs WithTags(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingV2LoadBalancerPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingV2LoadBalancerPropertiesArgs WithTags(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingV2LoadBalancerPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingV2LoadBalancerPropertiesArgs WithTags(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingV2LoadBalancerPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.AwsConnector.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingV2LoadBalancerPropertiesArgs WithType(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsElasticLoadBalancingV2LoadBalancerPropertiesArgs @selfRef, global::System.String type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

}
