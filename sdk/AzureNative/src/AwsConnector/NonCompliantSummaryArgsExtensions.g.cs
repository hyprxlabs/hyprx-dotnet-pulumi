// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class NonCompliantSummaryArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.NonCompliantSummaryArgs WithNonCompliantCount(this global::Pulumi.AzureNative.AwsConnector.Inputs.NonCompliantSummaryArgs @selfRef, global::System.Int32 nonCompliantCount)
    {
        @selfRef.NonCompliantCount = nonCompliantCount;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.NonCompliantSummaryArgs WithSeveritySummary(this global::Pulumi.AzureNative.AwsConnector.Inputs.NonCompliantSummaryArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.SeveritySummaryArgs severitySummary)
    {
        @selfRef.SeveritySummary = severitySummary;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.NonCompliantSummaryArgs WithSeveritySummary(this global::Pulumi.AzureNative.AwsConnector.Inputs.NonCompliantSummaryArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.SeveritySummaryArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.SeveritySummaryArgs();
        @configure(@item);
        @selfRef.SeveritySummary = @item;
        return @selfRef;
    }

}
