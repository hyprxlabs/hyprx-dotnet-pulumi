// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class VpcConfigResponseArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.VpcConfigResponseArgs WithClusterSecurityGroupId(this global::Pulumi.AzureNative.AwsConnector.Inputs.VpcConfigResponseArgs @selfRef, global::System.String clusterSecurityGroupId)
    {
        @selfRef.ClusterSecurityGroupId = clusterSecurityGroupId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.VpcConfigResponseArgs WithEndpointPrivateAccess(this global::Pulumi.AzureNative.AwsConnector.Inputs.VpcConfigResponseArgs @selfRef, bool endpointPrivateAccess = true)
    {
        @selfRef.EndpointPrivateAccess = endpointPrivateAccess;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.VpcConfigResponseArgs WithEndpointPublicAccess(this global::Pulumi.AzureNative.AwsConnector.Inputs.VpcConfigResponseArgs @selfRef, bool endpointPublicAccess = true)
    {
        @selfRef.EndpointPublicAccess = endpointPublicAccess;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.VpcConfigResponseArgs WithIpv6AllowedForDualStack(this global::Pulumi.AzureNative.AwsConnector.Inputs.VpcConfigResponseArgs @selfRef, bool ipv6AllowedForDualStack = true)
    {
        @selfRef.Ipv6AllowedForDualStack = ipv6AllowedForDualStack;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.VpcConfigResponseArgs WithPublicAccessCidrs(this global::Pulumi.AzureNative.AwsConnector.Inputs.VpcConfigResponseArgs @selfRef, global::System.Collections.Generic.List<global::System.String> publicAccessCidrs)
    {
        @selfRef.PublicAccessCidrs = publicAccessCidrs;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.VpcConfigResponseArgs WithPublicAccessCidrs(this global::Pulumi.AzureNative.AwsConnector.Inputs.VpcConfigResponseArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.PublicAccessCidrs = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.VpcConfigResponseArgs WithPublicAccessCidrs(this global::Pulumi.AzureNative.AwsConnector.Inputs.VpcConfigResponseArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.PublicAccessCidrs = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.VpcConfigResponseArgs WithSecurityGroupIds(this global::Pulumi.AzureNative.AwsConnector.Inputs.VpcConfigResponseArgs @selfRef, global::System.Collections.Generic.List<global::System.String> securityGroupIds)
    {
        @selfRef.SecurityGroupIds = securityGroupIds;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.VpcConfigResponseArgs WithSecurityGroupIds(this global::Pulumi.AzureNative.AwsConnector.Inputs.VpcConfigResponseArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.SecurityGroupIds = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.VpcConfigResponseArgs WithSecurityGroupIds(this global::Pulumi.AzureNative.AwsConnector.Inputs.VpcConfigResponseArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.SecurityGroupIds = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.VpcConfigResponseArgs WithSubnetIds(this global::Pulumi.AzureNative.AwsConnector.Inputs.VpcConfigResponseArgs @selfRef, global::System.Collections.Generic.List<global::System.String> subnetIds)
    {
        @selfRef.SubnetIds = subnetIds;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.VpcConfigResponseArgs WithSubnetIds(this global::Pulumi.AzureNative.AwsConnector.Inputs.VpcConfigResponseArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.SubnetIds = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.VpcConfigResponseArgs WithSubnetIds(this global::Pulumi.AzureNative.AwsConnector.Inputs.VpcConfigResponseArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.SubnetIds = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.VpcConfigResponseArgs WithSubnets(this global::Pulumi.AzureNative.AwsConnector.Inputs.VpcConfigResponseArgs @selfRef, global::System.Collections.Generic.List<global::System.String> subnets)
    {
        @selfRef.Subnets = subnets;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.VpcConfigResponseArgs WithSubnets(this global::Pulumi.AzureNative.AwsConnector.Inputs.VpcConfigResponseArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Subnets = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.VpcConfigResponseArgs WithSubnets(this global::Pulumi.AzureNative.AwsConnector.Inputs.VpcConfigResponseArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Subnets = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.VpcConfigResponseArgs WithVpcId(this global::Pulumi.AzureNative.AwsConnector.Inputs.VpcConfigResponseArgs @selfRef, global::System.String vpcId)
    {
        @selfRef.VpcId = vpcId;
        return @selfRef;
    }

}
