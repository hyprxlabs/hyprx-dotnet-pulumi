// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.NetworkFirewall.Inputs;

namespace Pulumi.AwsNative.NetworkFirewall;

public static partial class FirewallPolicyPublishMetricActionArgsExtensions
{
    public static global::Pulumi.AwsNative.NetworkFirewall.Inputs.FirewallPolicyPublishMetricActionArgs WithDimensions(this global::Pulumi.AwsNative.NetworkFirewall.Inputs.FirewallPolicyPublishMetricActionArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.NetworkFirewall.Inputs.FirewallPolicyDimensionArgs> dimensions)
    {
        @selfRef.Dimensions = dimensions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.NetworkFirewall.Inputs.FirewallPolicyPublishMetricActionArgs WithDimensions(this global::Pulumi.AwsNative.NetworkFirewall.Inputs.FirewallPolicyPublishMetricActionArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.NetworkFirewall.Inputs.FirewallPolicyDimensionArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.NetworkFirewall.Inputs.FirewallPolicyDimensionArgs>();
        @configure(@list);
        @selfRef.Dimensions = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.NetworkFirewall.Inputs.FirewallPolicyPublishMetricActionArgs WithDimensions(this global::Pulumi.AwsNative.NetworkFirewall.Inputs.FirewallPolicyPublishMetricActionArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.NetworkFirewall.Inputs.FirewallPolicyDimensionArgs>> @create)
    {
        @selfRef.Dimensions = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
