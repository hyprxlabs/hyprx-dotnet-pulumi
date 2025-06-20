// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.EmrServerless.Inputs;

namespace Pulumi.AwsNative.EmrServerless;

public static partial class ApplicationNetworkConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.EmrServerless.Inputs.ApplicationNetworkConfigurationArgs WithSecurityGroupIds(this global::Pulumi.AwsNative.EmrServerless.Inputs.ApplicationNetworkConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::System.String> securityGroupIds)
    {
        @selfRef.SecurityGroupIds = securityGroupIds;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.EmrServerless.Inputs.ApplicationNetworkConfigurationArgs WithSecurityGroupIds(this global::Pulumi.AwsNative.EmrServerless.Inputs.ApplicationNetworkConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.SecurityGroupIds = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.EmrServerless.Inputs.ApplicationNetworkConfigurationArgs WithSecurityGroupIds(this global::Pulumi.AwsNative.EmrServerless.Inputs.ApplicationNetworkConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.SecurityGroupIds = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.EmrServerless.Inputs.ApplicationNetworkConfigurationArgs WithSubnetIds(this global::Pulumi.AwsNative.EmrServerless.Inputs.ApplicationNetworkConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::System.String> subnetIds)
    {
        @selfRef.SubnetIds = subnetIds;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.EmrServerless.Inputs.ApplicationNetworkConfigurationArgs WithSubnetIds(this global::Pulumi.AwsNative.EmrServerless.Inputs.ApplicationNetworkConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.SubnetIds = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.EmrServerless.Inputs.ApplicationNetworkConfigurationArgs WithSubnetIds(this global::Pulumi.AwsNative.EmrServerless.Inputs.ApplicationNetworkConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.SubnetIds = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
