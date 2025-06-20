// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Ec2.Inputs;

namespace Pulumi.AwsNative.Ec2;

public static partial class VerifiedAccessEndpointLoadBalancerOptionsArgsExtensions
{
    public static global::Pulumi.AwsNative.Ec2.Inputs.VerifiedAccessEndpointLoadBalancerOptionsArgs WithLoadBalancerArn(this global::Pulumi.AwsNative.Ec2.Inputs.VerifiedAccessEndpointLoadBalancerOptionsArgs @selfRef, global::System.String loadBalancerArn)
    {
        @selfRef.LoadBalancerArn = loadBalancerArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.VerifiedAccessEndpointLoadBalancerOptionsArgs WithPort(this global::Pulumi.AwsNative.Ec2.Inputs.VerifiedAccessEndpointLoadBalancerOptionsArgs @selfRef, global::System.Int32 port)
    {
        @selfRef.Port = port;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.VerifiedAccessEndpointLoadBalancerOptionsArgs WithPortRanges(this global::Pulumi.AwsNative.Ec2.Inputs.VerifiedAccessEndpointLoadBalancerOptionsArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ec2.Inputs.VerifiedAccessEndpointPortRangeArgs> portRanges)
    {
        @selfRef.PortRanges = portRanges;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.VerifiedAccessEndpointLoadBalancerOptionsArgs WithPortRanges(this global::Pulumi.AwsNative.Ec2.Inputs.VerifiedAccessEndpointLoadBalancerOptionsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ec2.Inputs.VerifiedAccessEndpointPortRangeArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ec2.Inputs.VerifiedAccessEndpointPortRangeArgs>();
        @configure(@list);
        @selfRef.PortRanges = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.VerifiedAccessEndpointLoadBalancerOptionsArgs WithPortRanges(this global::Pulumi.AwsNative.Ec2.Inputs.VerifiedAccessEndpointLoadBalancerOptionsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Ec2.Inputs.VerifiedAccessEndpointPortRangeArgs>> @create)
    {
        @selfRef.PortRanges = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.VerifiedAccessEndpointLoadBalancerOptionsArgs WithProtocol(this global::Pulumi.AwsNative.Ec2.Inputs.VerifiedAccessEndpointLoadBalancerOptionsArgs @selfRef, global::System.String protocol)
    {
        @selfRef.Protocol = protocol;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.VerifiedAccessEndpointLoadBalancerOptionsArgs WithSubnetIds(this global::Pulumi.AwsNative.Ec2.Inputs.VerifiedAccessEndpointLoadBalancerOptionsArgs @selfRef, global::System.Collections.Generic.List<global::System.String> subnetIds)
    {
        @selfRef.SubnetIds = subnetIds;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.VerifiedAccessEndpointLoadBalancerOptionsArgs WithSubnetIds(this global::Pulumi.AwsNative.Ec2.Inputs.VerifiedAccessEndpointLoadBalancerOptionsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.SubnetIds = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.VerifiedAccessEndpointLoadBalancerOptionsArgs WithSubnetIds(this global::Pulumi.AwsNative.Ec2.Inputs.VerifiedAccessEndpointLoadBalancerOptionsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.SubnetIds = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
