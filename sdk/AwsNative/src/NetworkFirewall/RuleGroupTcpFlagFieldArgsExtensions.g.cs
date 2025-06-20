// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.NetworkFirewall.Inputs;

namespace Pulumi.AwsNative.NetworkFirewall;

public static partial class RuleGroupTcpFlagFieldArgsExtensions
{
    public static global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupTcpFlagFieldArgs WithFlags(this global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupTcpFlagFieldArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.NetworkFirewall.RuleGroupTcpFlag> flags)
    {
        @selfRef.Flags = flags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupTcpFlagFieldArgs WithFlags(this global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupTcpFlagFieldArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.NetworkFirewall.RuleGroupTcpFlag>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.NetworkFirewall.RuleGroupTcpFlag>();
        @configure(@list);
        @selfRef.Flags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupTcpFlagFieldArgs WithFlags(this global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupTcpFlagFieldArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.NetworkFirewall.RuleGroupTcpFlag>> @create)
    {
        @selfRef.Flags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupTcpFlagFieldArgs WithMasks(this global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupTcpFlagFieldArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.NetworkFirewall.RuleGroupTcpFlag> masks)
    {
        @selfRef.Masks = masks;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupTcpFlagFieldArgs WithMasks(this global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupTcpFlagFieldArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.NetworkFirewall.RuleGroupTcpFlag>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.NetworkFirewall.RuleGroupTcpFlag>();
        @configure(@list);
        @selfRef.Masks = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupTcpFlagFieldArgs WithMasks(this global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupTcpFlagFieldArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.NetworkFirewall.RuleGroupTcpFlag>> @create)
    {
        @selfRef.Masks = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
