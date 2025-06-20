// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Fms.Inputs;

namespace Pulumi.AwsNative.Fms;

public static partial class PolicyOptionArgsExtensions
{
    public static global::Pulumi.AwsNative.Fms.Inputs.PolicyOptionArgs WithNetworkAclCommonPolicy(this global::Pulumi.AwsNative.Fms.Inputs.PolicyOptionArgs @selfRef, global::Pulumi.AwsNative.Fms.Inputs.PolicyNetworkAclCommonPolicyArgs networkAclCommonPolicy)
    {
        @selfRef.NetworkAclCommonPolicy = networkAclCommonPolicy;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Fms.Inputs.PolicyOptionArgs WithNetworkAclCommonPolicy(this global::Pulumi.AwsNative.Fms.Inputs.PolicyOptionArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Fms.Inputs.PolicyNetworkAclCommonPolicyArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Fms.Inputs.PolicyNetworkAclCommonPolicyArgs();
        @configure(@item);
        @selfRef.NetworkAclCommonPolicy = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Fms.Inputs.PolicyOptionArgs WithNetworkFirewallPolicy(this global::Pulumi.AwsNative.Fms.Inputs.PolicyOptionArgs @selfRef, global::Pulumi.AwsNative.Fms.Inputs.PolicyNetworkFirewallPolicyArgs networkFirewallPolicy)
    {
        @selfRef.NetworkFirewallPolicy = networkFirewallPolicy;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Fms.Inputs.PolicyOptionArgs WithNetworkFirewallPolicy(this global::Pulumi.AwsNative.Fms.Inputs.PolicyOptionArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Fms.Inputs.PolicyNetworkFirewallPolicyArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Fms.Inputs.PolicyNetworkFirewallPolicyArgs();
        @configure(@item);
        @selfRef.NetworkFirewallPolicy = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Fms.Inputs.PolicyOptionArgs WithThirdPartyFirewallPolicy(this global::Pulumi.AwsNative.Fms.Inputs.PolicyOptionArgs @selfRef, global::Pulumi.AwsNative.Fms.Inputs.PolicyThirdPartyFirewallPolicyArgs thirdPartyFirewallPolicy)
    {
        @selfRef.ThirdPartyFirewallPolicy = thirdPartyFirewallPolicy;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Fms.Inputs.PolicyOptionArgs WithThirdPartyFirewallPolicy(this global::Pulumi.AwsNative.Fms.Inputs.PolicyOptionArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Fms.Inputs.PolicyThirdPartyFirewallPolicyArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Fms.Inputs.PolicyThirdPartyFirewallPolicyArgs();
        @configure(@item);
        @selfRef.ThirdPartyFirewallPolicy = @item;
        return @selfRef;
    }

}
