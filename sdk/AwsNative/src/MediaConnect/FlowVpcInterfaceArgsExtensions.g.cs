// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.MediaConnect.Inputs;

namespace Pulumi.AwsNative.MediaConnect;

public static partial class FlowVpcInterfaceArgsExtensions
{
    public static global::Pulumi.AwsNative.MediaConnect.Inputs.FlowVpcInterfaceArgs WithName(this global::Pulumi.AwsNative.MediaConnect.Inputs.FlowVpcInterfaceArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaConnect.Inputs.FlowVpcInterfaceArgs WithNetworkInterfaceIds(this global::Pulumi.AwsNative.MediaConnect.Inputs.FlowVpcInterfaceArgs @selfRef, global::System.Collections.Generic.List<global::System.String> networkInterfaceIds)
    {
        @selfRef.NetworkInterfaceIds = networkInterfaceIds;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaConnect.Inputs.FlowVpcInterfaceArgs WithNetworkInterfaceIds(this global::Pulumi.AwsNative.MediaConnect.Inputs.FlowVpcInterfaceArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.NetworkInterfaceIds = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaConnect.Inputs.FlowVpcInterfaceArgs WithNetworkInterfaceIds(this global::Pulumi.AwsNative.MediaConnect.Inputs.FlowVpcInterfaceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.NetworkInterfaceIds = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaConnect.Inputs.FlowVpcInterfaceArgs WithNetworkInterfaceType(this global::Pulumi.AwsNative.MediaConnect.Inputs.FlowVpcInterfaceArgs @selfRef, global::Pulumi.AwsNative.MediaConnect.FlowVpcInterfaceNetworkInterfaceType networkInterfaceType)
    {
        @selfRef.NetworkInterfaceType = networkInterfaceType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaConnect.Inputs.FlowVpcInterfaceArgs WithNetworkInterfaceType(this global::Pulumi.AwsNative.MediaConnect.Inputs.FlowVpcInterfaceArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.MediaConnect.FlowVpcInterfaceNetworkInterfaceType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.MediaConnect.FlowVpcInterfaceNetworkInterfaceType>();
        @configure(@item);
        @selfRef.NetworkInterfaceType = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaConnect.Inputs.FlowVpcInterfaceArgs WithRoleArn(this global::Pulumi.AwsNative.MediaConnect.Inputs.FlowVpcInterfaceArgs @selfRef, global::System.String roleArn)
    {
        @selfRef.RoleArn = roleArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaConnect.Inputs.FlowVpcInterfaceArgs WithSecurityGroupIds(this global::Pulumi.AwsNative.MediaConnect.Inputs.FlowVpcInterfaceArgs @selfRef, global::System.Collections.Generic.List<global::System.String> securityGroupIds)
    {
        @selfRef.SecurityGroupIds = securityGroupIds;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaConnect.Inputs.FlowVpcInterfaceArgs WithSecurityGroupIds(this global::Pulumi.AwsNative.MediaConnect.Inputs.FlowVpcInterfaceArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.SecurityGroupIds = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaConnect.Inputs.FlowVpcInterfaceArgs WithSecurityGroupIds(this global::Pulumi.AwsNative.MediaConnect.Inputs.FlowVpcInterfaceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.SecurityGroupIds = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaConnect.Inputs.FlowVpcInterfaceArgs WithSubnetId(this global::Pulumi.AwsNative.MediaConnect.Inputs.FlowVpcInterfaceArgs @selfRef, global::System.String subnetId)
    {
        @selfRef.SubnetId = subnetId;
        return @selfRef;
    }

}
