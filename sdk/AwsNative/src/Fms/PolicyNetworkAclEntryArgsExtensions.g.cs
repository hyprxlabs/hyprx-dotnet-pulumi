// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Fms.Inputs;

namespace Pulumi.AwsNative.Fms;

public static partial class PolicyNetworkAclEntryArgsExtensions
{
    public static global::Pulumi.AwsNative.Fms.Inputs.PolicyNetworkAclEntryArgs WithCidrBlock(this global::Pulumi.AwsNative.Fms.Inputs.PolicyNetworkAclEntryArgs @selfRef, global::System.String cidrBlock)
    {
        @selfRef.CidrBlock = cidrBlock;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Fms.Inputs.PolicyNetworkAclEntryArgs WithEgress(this global::Pulumi.AwsNative.Fms.Inputs.PolicyNetworkAclEntryArgs @selfRef, bool egress = true)
    {
        @selfRef.Egress = egress;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Fms.Inputs.PolicyNetworkAclEntryArgs WithIcmpTypeCode(this global::Pulumi.AwsNative.Fms.Inputs.PolicyNetworkAclEntryArgs @selfRef, global::Pulumi.AwsNative.Fms.Inputs.PolicyNetworkAclEntryIcmpTypeCodePropertiesArgs icmpTypeCode)
    {
        @selfRef.IcmpTypeCode = icmpTypeCode;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Fms.Inputs.PolicyNetworkAclEntryArgs WithIcmpTypeCode(this global::Pulumi.AwsNative.Fms.Inputs.PolicyNetworkAclEntryArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Fms.Inputs.PolicyNetworkAclEntryIcmpTypeCodePropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Fms.Inputs.PolicyNetworkAclEntryIcmpTypeCodePropertiesArgs();
        @configure(@item);
        @selfRef.IcmpTypeCode = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Fms.Inputs.PolicyNetworkAclEntryArgs WithIpv6CidrBlock(this global::Pulumi.AwsNative.Fms.Inputs.PolicyNetworkAclEntryArgs @selfRef, global::System.String ipv6CidrBlock)
    {
        @selfRef.Ipv6CidrBlock = ipv6CidrBlock;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Fms.Inputs.PolicyNetworkAclEntryArgs WithPortRange(this global::Pulumi.AwsNative.Fms.Inputs.PolicyNetworkAclEntryArgs @selfRef, global::Pulumi.AwsNative.Fms.Inputs.PolicyNetworkAclEntryPortRangePropertiesArgs portRange)
    {
        @selfRef.PortRange = portRange;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Fms.Inputs.PolicyNetworkAclEntryArgs WithPortRange(this global::Pulumi.AwsNative.Fms.Inputs.PolicyNetworkAclEntryArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Fms.Inputs.PolicyNetworkAclEntryPortRangePropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Fms.Inputs.PolicyNetworkAclEntryPortRangePropertiesArgs();
        @configure(@item);
        @selfRef.PortRange = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Fms.Inputs.PolicyNetworkAclEntryArgs WithProtocol(this global::Pulumi.AwsNative.Fms.Inputs.PolicyNetworkAclEntryArgs @selfRef, global::System.String protocol)
    {
        @selfRef.Protocol = protocol;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Fms.Inputs.PolicyNetworkAclEntryArgs WithRuleAction(this global::Pulumi.AwsNative.Fms.Inputs.PolicyNetworkAclEntryArgs @selfRef, global::Pulumi.AwsNative.Fms.PolicyNetworkAclEntryRuleAction ruleAction)
    {
        @selfRef.RuleAction = ruleAction;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Fms.Inputs.PolicyNetworkAclEntryArgs WithRuleAction(this global::Pulumi.AwsNative.Fms.Inputs.PolicyNetworkAclEntryArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Fms.PolicyNetworkAclEntryRuleAction> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Fms.PolicyNetworkAclEntryRuleAction>();
        @configure(@item);
        @selfRef.RuleAction = @item;
        return @selfRef;
    }

}
