// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Fms.Inputs;

namespace Pulumi.AwsNative.Fms;

public static partial class PolicyThirdPartyFirewallPolicyArgsExtensions
{
    public static global::Pulumi.AwsNative.Fms.Inputs.PolicyThirdPartyFirewallPolicyArgs WithFirewallDeploymentModel(this global::Pulumi.AwsNative.Fms.Inputs.PolicyThirdPartyFirewallPolicyArgs @selfRef, global::Pulumi.AwsNative.Fms.PolicyFirewallDeploymentModel firewallDeploymentModel)
    {
        @selfRef.FirewallDeploymentModel = firewallDeploymentModel;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Fms.Inputs.PolicyThirdPartyFirewallPolicyArgs WithFirewallDeploymentModel(this global::Pulumi.AwsNative.Fms.Inputs.PolicyThirdPartyFirewallPolicyArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Fms.PolicyFirewallDeploymentModel> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Fms.PolicyFirewallDeploymentModel>();
        @configure(@item);
        @selfRef.FirewallDeploymentModel = @item;
        return @selfRef;
    }

}
