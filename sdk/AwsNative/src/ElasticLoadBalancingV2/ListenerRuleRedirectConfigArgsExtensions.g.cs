// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs;

namespace Pulumi.AwsNative.ElasticLoadBalancingV2;

public static partial class ListenerRuleRedirectConfigArgsExtensions
{
    public static global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerRuleRedirectConfigArgs WithHost(this global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerRuleRedirectConfigArgs @selfRef, global::System.String host)
    {
        @selfRef.Host = host;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerRuleRedirectConfigArgs WithPath(this global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerRuleRedirectConfigArgs @selfRef, global::System.String path)
    {
        @selfRef.Path = path;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerRuleRedirectConfigArgs WithPort(this global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerRuleRedirectConfigArgs @selfRef, global::System.String port)
    {
        @selfRef.Port = port;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerRuleRedirectConfigArgs WithProtocol(this global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerRuleRedirectConfigArgs @selfRef, global::System.String protocol)
    {
        @selfRef.Protocol = protocol;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerRuleRedirectConfigArgs WithQuery(this global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerRuleRedirectConfigArgs @selfRef, global::System.String query)
    {
        @selfRef.Query = query;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerRuleRedirectConfigArgs WithStatusCode(this global::Pulumi.AwsNative.ElasticLoadBalancingV2.Inputs.ListenerRuleRedirectConfigArgs @selfRef, global::System.String statusCode)
    {
        @selfRef.StatusCode = statusCode;
        return @selfRef;
    }

}
