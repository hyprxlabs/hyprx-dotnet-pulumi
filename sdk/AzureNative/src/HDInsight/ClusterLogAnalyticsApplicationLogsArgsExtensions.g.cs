// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.HDInsight.Inputs;

namespace Pulumi.AzureNative.HDInsight;

public static partial class ClusterLogAnalyticsApplicationLogsArgsExtensions
{
    public static global::Pulumi.AzureNative.HDInsight.Inputs.ClusterLogAnalyticsApplicationLogsArgs WithStdErrorEnabled(this global::Pulumi.AzureNative.HDInsight.Inputs.ClusterLogAnalyticsApplicationLogsArgs @selfRef, bool stdErrorEnabled = true)
    {
        @selfRef.StdErrorEnabled = stdErrorEnabled;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HDInsight.Inputs.ClusterLogAnalyticsApplicationLogsArgs WithStdOutEnabled(this global::Pulumi.AzureNative.HDInsight.Inputs.ClusterLogAnalyticsApplicationLogsArgs @selfRef, bool stdOutEnabled = true)
    {
        @selfRef.StdOutEnabled = stdOutEnabled;
        return @selfRef;
    }

}
