// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.LookoutMetrics.Inputs;

namespace Pulumi.AwsNative.LookoutMetrics;

public static partial class AnomalyDetectorCsvFormatDescriptorArgsExtensions
{
    public static global::Pulumi.AwsNative.LookoutMetrics.Inputs.AnomalyDetectorCsvFormatDescriptorArgs WithCharset(this global::Pulumi.AwsNative.LookoutMetrics.Inputs.AnomalyDetectorCsvFormatDescriptorArgs @selfRef, global::System.String charset)
    {
        @selfRef.Charset = charset;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.LookoutMetrics.Inputs.AnomalyDetectorCsvFormatDescriptorArgs WithContainsHeader(this global::Pulumi.AwsNative.LookoutMetrics.Inputs.AnomalyDetectorCsvFormatDescriptorArgs @selfRef, bool containsHeader = true)
    {
        @selfRef.ContainsHeader = containsHeader;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.LookoutMetrics.Inputs.AnomalyDetectorCsvFormatDescriptorArgs WithDelimiter(this global::Pulumi.AwsNative.LookoutMetrics.Inputs.AnomalyDetectorCsvFormatDescriptorArgs @selfRef, global::System.String delimiter)
    {
        @selfRef.Delimiter = delimiter;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.LookoutMetrics.Inputs.AnomalyDetectorCsvFormatDescriptorArgs WithFileCompression(this global::Pulumi.AwsNative.LookoutMetrics.Inputs.AnomalyDetectorCsvFormatDescriptorArgs @selfRef, global::Pulumi.AwsNative.LookoutMetrics.AnomalyDetectorCsvFormatDescriptorFileCompression fileCompression)
    {
        @selfRef.FileCompression = fileCompression;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.LookoutMetrics.Inputs.AnomalyDetectorCsvFormatDescriptorArgs WithFileCompression(this global::Pulumi.AwsNative.LookoutMetrics.Inputs.AnomalyDetectorCsvFormatDescriptorArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.LookoutMetrics.AnomalyDetectorCsvFormatDescriptorFileCompression> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.LookoutMetrics.AnomalyDetectorCsvFormatDescriptorFileCompression>();
        @configure(@item);
        @selfRef.FileCompression = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.LookoutMetrics.Inputs.AnomalyDetectorCsvFormatDescriptorArgs WithHeaderList(this global::Pulumi.AwsNative.LookoutMetrics.Inputs.AnomalyDetectorCsvFormatDescriptorArgs @selfRef, global::System.Collections.Generic.List<global::System.String> headerList)
    {
        @selfRef.HeaderList = headerList;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.LookoutMetrics.Inputs.AnomalyDetectorCsvFormatDescriptorArgs WithHeaderList(this global::Pulumi.AwsNative.LookoutMetrics.Inputs.AnomalyDetectorCsvFormatDescriptorArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.HeaderList = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.LookoutMetrics.Inputs.AnomalyDetectorCsvFormatDescriptorArgs WithHeaderList(this global::Pulumi.AwsNative.LookoutMetrics.Inputs.AnomalyDetectorCsvFormatDescriptorArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.HeaderList = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.LookoutMetrics.Inputs.AnomalyDetectorCsvFormatDescriptorArgs WithQuoteSymbol(this global::Pulumi.AwsNative.LookoutMetrics.Inputs.AnomalyDetectorCsvFormatDescriptorArgs @selfRef, global::System.String quoteSymbol)
    {
        @selfRef.QuoteSymbol = quoteSymbol;
        return @selfRef;
    }

}
