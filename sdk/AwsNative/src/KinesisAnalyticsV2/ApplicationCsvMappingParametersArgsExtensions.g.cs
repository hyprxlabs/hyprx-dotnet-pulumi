// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.KinesisAnalyticsV2.Inputs;

namespace Pulumi.AwsNative.KinesisAnalyticsV2;

public static partial class ApplicationCsvMappingParametersArgsExtensions
{
    public static global::Pulumi.AwsNative.KinesisAnalyticsV2.Inputs.ApplicationCsvMappingParametersArgs WithRecordColumnDelimiter(this global::Pulumi.AwsNative.KinesisAnalyticsV2.Inputs.ApplicationCsvMappingParametersArgs @selfRef, global::System.String recordColumnDelimiter)
    {
        @selfRef.RecordColumnDelimiter = recordColumnDelimiter;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.KinesisAnalyticsV2.Inputs.ApplicationCsvMappingParametersArgs WithRecordRowDelimiter(this global::Pulumi.AwsNative.KinesisAnalyticsV2.Inputs.ApplicationCsvMappingParametersArgs @selfRef, global::System.String recordRowDelimiter)
    {
        @selfRef.RecordRowDelimiter = recordRowDelimiter;
        return @selfRef;
    }

}
