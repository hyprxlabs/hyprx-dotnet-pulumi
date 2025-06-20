// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.IoTAnalytics.Inputs;

namespace Pulumi.AwsNative.IoTAnalytics;

public static partial class PipelineAddAttributesArgsExtensions
{
    public static global::Pulumi.AwsNative.IoTAnalytics.Inputs.PipelineAddAttributesArgs WithAttributes(this global::Pulumi.AwsNative.IoTAnalytics.Inputs.PipelineAddAttributesArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> attributes)
    {
        @selfRef.Attributes = attributes;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTAnalytics.Inputs.PipelineAddAttributesArgs WithAttributes(this global::Pulumi.AwsNative.IoTAnalytics.Inputs.PipelineAddAttributesArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Attributes = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTAnalytics.Inputs.PipelineAddAttributesArgs WithAttributes(this global::Pulumi.AwsNative.IoTAnalytics.Inputs.PipelineAddAttributesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Attributes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTAnalytics.Inputs.PipelineAddAttributesArgs WithName(this global::Pulumi.AwsNative.IoTAnalytics.Inputs.PipelineAddAttributesArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTAnalytics.Inputs.PipelineAddAttributesArgs WithNext(this global::Pulumi.AwsNative.IoTAnalytics.Inputs.PipelineAddAttributesArgs @selfRef, global::System.String next)
    {
        @selfRef.Next = next;
        return @selfRef;
    }

}
