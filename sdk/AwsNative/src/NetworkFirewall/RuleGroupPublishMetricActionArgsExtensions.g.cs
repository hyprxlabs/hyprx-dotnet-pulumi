// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.NetworkFirewall.Inputs;

namespace Pulumi.AwsNative.NetworkFirewall;

public static partial class RuleGroupPublishMetricActionArgsExtensions
{
    public static global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupPublishMetricActionArgs WithDimensions(this global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupPublishMetricActionArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupDimensionArgs> dimensions)
    {
        @selfRef.Dimensions = dimensions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupPublishMetricActionArgs WithDimensions(this global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupPublishMetricActionArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupDimensionArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupDimensionArgs>();
        @configure(@list);
        @selfRef.Dimensions = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupPublishMetricActionArgs WithDimensions(this global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupPublishMetricActionArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.NetworkFirewall.Inputs.RuleGroupDimensionArgs>> @create)
    {
        @selfRef.Dimensions = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
