// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.IoTAnalytics.Inputs;

namespace Pulumi.AwsNative.IoTAnalytics;

public static partial class PipelineFilterArgsExtensions
{
    public static global::Pulumi.AwsNative.IoTAnalytics.Inputs.PipelineFilterArgs WithFilter(this global::Pulumi.AwsNative.IoTAnalytics.Inputs.PipelineFilterArgs @selfRef, global::System.String filter)
    {
        @selfRef.Filter = filter;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTAnalytics.Inputs.PipelineFilterArgs WithName(this global::Pulumi.AwsNative.IoTAnalytics.Inputs.PipelineFilterArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTAnalytics.Inputs.PipelineFilterArgs WithNext(this global::Pulumi.AwsNative.IoTAnalytics.Inputs.PipelineFilterArgs @selfRef, global::System.String next)
    {
        @selfRef.Next = next;
        return @selfRef;
    }

}
