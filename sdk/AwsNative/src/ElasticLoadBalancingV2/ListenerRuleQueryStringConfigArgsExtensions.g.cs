// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs;

namespace Pulumi.AwsNative.ElasticLoadBalancingV2;

public static partial class ListenerRuleQueryStringConfigArgsExtensions
{
    public static global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerRuleQueryStringConfigArgs WithValues(this global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerRuleQueryStringConfigArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerRuleQueryStringKeyValueArgs> values)
    {
        @selfRef.Values = values;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerRuleQueryStringConfigArgs WithValues(this global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerRuleQueryStringConfigArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerRuleQueryStringKeyValueArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerRuleQueryStringKeyValueArgs>();
        @configure(@list);
        @selfRef.Values = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerRuleQueryStringConfigArgs WithValues(this global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerRuleQueryStringConfigArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerRuleQueryStringKeyValueArgs>> @create)
    {
        @selfRef.Values = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
