// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.SageMaker.Inputs;

namespace Pulumi.AwsNative.SageMaker;

public static partial class ModelCardMetricGroupArgsExtensions
{
    public static global::Pulumi.AwsNative.SageMaker.Inputs.ModelCardMetricGroupArgs WithMetricData(this global::Pulumi.AwsNative.SageMaker.Inputs.ModelCardMetricGroupArgs @selfRef, global::System.Collections.Generic.List<global::System.Object> metricData)
    {
        @selfRef.MetricData = metricData;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.ModelCardMetricGroupArgs WithMetricData(this global::Pulumi.AwsNative.SageMaker.Inputs.ModelCardMetricGroupArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.Object>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.Object>();
        @configure(@list);
        @selfRef.MetricData = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.ModelCardMetricGroupArgs WithMetricData(this global::Pulumi.AwsNative.SageMaker.Inputs.ModelCardMetricGroupArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.Object>> @create)
    {
        @selfRef.MetricData = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.ModelCardMetricGroupArgs WithName(this global::Pulumi.AwsNative.SageMaker.Inputs.ModelCardMetricGroupArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

}
