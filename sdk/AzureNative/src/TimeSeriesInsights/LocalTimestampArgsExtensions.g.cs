// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.TimeSeriesInsights.Inputs;

namespace Pulumi.AzureNative.TimeSeriesInsights;

public static partial class LocalTimestampArgsExtensions
{
    public static global::Pulumi.AzureNative.TimeSeriesInsights.Inputs.LocalTimestampArgs WithFormat(this global::Pulumi.AzureNative.TimeSeriesInsights.Inputs.LocalTimestampArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.TimeSeriesInsights.LocalTimestampFormat> format)
    {
        @selfRef.Format = format;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TimeSeriesInsights.Inputs.LocalTimestampArgs WithTimeZoneOffset(this global::Pulumi.AzureNative.TimeSeriesInsights.Inputs.LocalTimestampArgs @selfRef, global::Pulumi.AzureNative.TimeSeriesInsights.Inputs.LocalTimestampTimeZoneOffsetArgs timeZoneOffset)
    {
        @selfRef.TimeZoneOffset = timeZoneOffset;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.TimeSeriesInsights.Inputs.LocalTimestampArgs WithTimeZoneOffset(this global::Pulumi.AzureNative.TimeSeriesInsights.Inputs.LocalTimestampArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.TimeSeriesInsights.Inputs.LocalTimestampTimeZoneOffsetArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.TimeSeriesInsights.Inputs.LocalTimestampTimeZoneOffsetArgs();
        @configure(@item);
        @selfRef.TimeZoneOffset = @item;
        return @selfRef;
    }

}
