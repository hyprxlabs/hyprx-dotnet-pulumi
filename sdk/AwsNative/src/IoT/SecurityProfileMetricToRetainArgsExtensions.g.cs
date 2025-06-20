// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.IoT.Inputs;

namespace Pulumi.AwsNative.IoT;

public static partial class SecurityProfileMetricToRetainArgsExtensions
{
    public static global::Pulumi.AwsNative.IoT.Inputs.SecurityProfileMetricToRetainArgs WithExportMetric(this global::Pulumi.AwsNative.IoT.Inputs.SecurityProfileMetricToRetainArgs @selfRef, bool exportMetric = true)
    {
        @selfRef.ExportMetric = exportMetric;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.Inputs.SecurityProfileMetricToRetainArgs WithMetric(this global::Pulumi.AwsNative.IoT.Inputs.SecurityProfileMetricToRetainArgs @selfRef, global::System.String metric)
    {
        @selfRef.Metric = metric;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.Inputs.SecurityProfileMetricToRetainArgs WithMetricDimension(this global::Pulumi.AwsNative.IoT.Inputs.SecurityProfileMetricToRetainArgs @selfRef, global::Pulumi.AwsNative.IoT.Inputs.SecurityProfileMetricDimensionArgs metricDimension)
    {
        @selfRef.MetricDimension = metricDimension;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.Inputs.SecurityProfileMetricToRetainArgs WithMetricDimension(this global::Pulumi.AwsNative.IoT.Inputs.SecurityProfileMetricToRetainArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.IoT.Inputs.SecurityProfileMetricDimensionArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.IoT.Inputs.SecurityProfileMetricDimensionArgs();
        @configure(@item);
        @selfRef.MetricDimension = @item;
        return @selfRef;
    }

}
