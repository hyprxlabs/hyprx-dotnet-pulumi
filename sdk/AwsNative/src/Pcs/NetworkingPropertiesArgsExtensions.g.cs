// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Pcs.Inputs;

namespace Pulumi.AwsNative.Pcs;

public static partial class NetworkingPropertiesArgsExtensions
{
    public static global::Pulumi.AwsNative.Pcs.Inputs.NetworkingPropertiesArgs WithSecurityGroupIds(this global::Pulumi.AwsNative.Pcs.Inputs.NetworkingPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::System.String> securityGroupIds)
    {
        @selfRef.SecurityGroupIds = securityGroupIds;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Pcs.Inputs.NetworkingPropertiesArgs WithSecurityGroupIds(this global::Pulumi.AwsNative.Pcs.Inputs.NetworkingPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.SecurityGroupIds = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Pcs.Inputs.NetworkingPropertiesArgs WithSecurityGroupIds(this global::Pulumi.AwsNative.Pcs.Inputs.NetworkingPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.SecurityGroupIds = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Pcs.Inputs.NetworkingPropertiesArgs WithSubnetIds(this global::Pulumi.AwsNative.Pcs.Inputs.NetworkingPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::System.String> subnetIds)
    {
        @selfRef.SubnetIds = subnetIds;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Pcs.Inputs.NetworkingPropertiesArgs WithSubnetIds(this global::Pulumi.AwsNative.Pcs.Inputs.NetworkingPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.SubnetIds = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Pcs.Inputs.NetworkingPropertiesArgs WithSubnetIds(this global::Pulumi.AwsNative.Pcs.Inputs.NetworkingPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.SubnetIds = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
