// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.AppFlow.Inputs;

namespace Pulumi.AwsNative.AppFlow;

public static partial class FlowS3InputFormatConfigArgsExtensions
{
    public static global::Pulumi.AwsNative.AppFlow.Inputs.FlowS3InputFormatConfigArgs WithS3InputFileType(this global::Pulumi.AwsNative.AppFlow.Inputs.FlowS3InputFormatConfigArgs @selfRef, global::Pulumi.AwsNative.AppFlow.FlowS3InputFormatConfigS3InputFileType s3InputFileType)
    {
        @selfRef.S3InputFileType = s3InputFileType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppFlow.Inputs.FlowS3InputFormatConfigArgs WithS3InputFileType(this global::Pulumi.AwsNative.AppFlow.Inputs.FlowS3InputFormatConfigArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.AppFlow.FlowS3InputFormatConfigS3InputFileType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.AppFlow.FlowS3InputFormatConfigS3InputFileType>();
        @configure(@item);
        @selfRef.S3InputFileType = @item;
        return @selfRef;
    }

}
