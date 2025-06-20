// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.XRay.Inputs;

namespace Pulumi.AwsNative.XRay;

public static partial class SamplingRuleUpdateArgsExtensions
{
    public static global::Pulumi.AwsNative.XRay.Inputs.SamplingRuleUpdateArgs WithAttributes(this global::Pulumi.AwsNative.XRay.Inputs.SamplingRuleUpdateArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> attributes)
    {
        @selfRef.Attributes = attributes;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.XRay.Inputs.SamplingRuleUpdateArgs WithAttributes(this global::Pulumi.AwsNative.XRay.Inputs.SamplingRuleUpdateArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Attributes = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.XRay.Inputs.SamplingRuleUpdateArgs WithAttributes(this global::Pulumi.AwsNative.XRay.Inputs.SamplingRuleUpdateArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Attributes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.XRay.Inputs.SamplingRuleUpdateArgs WithFixedRate(this global::Pulumi.AwsNative.XRay.Inputs.SamplingRuleUpdateArgs @selfRef, global::System.Double fixedRate)
    {
        @selfRef.FixedRate = fixedRate;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.XRay.Inputs.SamplingRuleUpdateArgs WithHost(this global::Pulumi.AwsNative.XRay.Inputs.SamplingRuleUpdateArgs @selfRef, global::System.String host)
    {
        @selfRef.Host = host;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.XRay.Inputs.SamplingRuleUpdateArgs WithHttpMethod(this global::Pulumi.AwsNative.XRay.Inputs.SamplingRuleUpdateArgs @selfRef, global::System.String httpMethod)
    {
        @selfRef.HttpMethod = httpMethod;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.XRay.Inputs.SamplingRuleUpdateArgs WithPriority(this global::Pulumi.AwsNative.XRay.Inputs.SamplingRuleUpdateArgs @selfRef, global::System.Int32 priority)
    {
        @selfRef.Priority = priority;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.XRay.Inputs.SamplingRuleUpdateArgs WithReservoirSize(this global::Pulumi.AwsNative.XRay.Inputs.SamplingRuleUpdateArgs @selfRef, global::System.Int32 reservoirSize)
    {
        @selfRef.ReservoirSize = reservoirSize;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.XRay.Inputs.SamplingRuleUpdateArgs WithResourceArn(this global::Pulumi.AwsNative.XRay.Inputs.SamplingRuleUpdateArgs @selfRef, global::System.String resourceArn)
    {
        @selfRef.ResourceArn = resourceArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.XRay.Inputs.SamplingRuleUpdateArgs WithRuleArn(this global::Pulumi.AwsNative.XRay.Inputs.SamplingRuleUpdateArgs @selfRef, global::System.String ruleArn)
    {
        @selfRef.RuleArn = ruleArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.XRay.Inputs.SamplingRuleUpdateArgs WithRuleName(this global::Pulumi.AwsNative.XRay.Inputs.SamplingRuleUpdateArgs @selfRef, global::System.String ruleName)
    {
        @selfRef.RuleName = ruleName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.XRay.Inputs.SamplingRuleUpdateArgs WithServiceName(this global::Pulumi.AwsNative.XRay.Inputs.SamplingRuleUpdateArgs @selfRef, global::System.String serviceName)
    {
        @selfRef.ServiceName = serviceName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.XRay.Inputs.SamplingRuleUpdateArgs WithServiceType(this global::Pulumi.AwsNative.XRay.Inputs.SamplingRuleUpdateArgs @selfRef, global::System.String serviceType)
    {
        @selfRef.ServiceType = serviceType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.XRay.Inputs.SamplingRuleUpdateArgs WithUrlPath(this global::Pulumi.AwsNative.XRay.Inputs.SamplingRuleUpdateArgs @selfRef, global::System.String urlPath)
    {
        @selfRef.UrlPath = urlPath;
        return @selfRef;
    }

}
