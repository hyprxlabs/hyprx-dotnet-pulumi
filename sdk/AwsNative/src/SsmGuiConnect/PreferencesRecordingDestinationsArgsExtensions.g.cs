// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.SsmGuiConnect.Inputs;

namespace Pulumi.AwsNative.SsmGuiConnect;

public static partial class PreferencesRecordingDestinationsArgsExtensions
{
    public static global::Pulumi.AwsNative.SsmGuiConnect.Inputs.PreferencesRecordingDestinationsArgs WithS3Buckets(this global::Pulumi.AwsNative.SsmGuiConnect.Inputs.PreferencesRecordingDestinationsArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.SsmGuiConnect.Inputs.PreferencesS3BucketArgs> s3Buckets)
    {
        @selfRef.S3Buckets = s3Buckets;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SsmGuiConnect.Inputs.PreferencesRecordingDestinationsArgs WithS3Buckets(this global::Pulumi.AwsNative.SsmGuiConnect.Inputs.PreferencesRecordingDestinationsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.SsmGuiConnect.Inputs.PreferencesS3BucketArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.SsmGuiConnect.Inputs.PreferencesS3BucketArgs>();
        @configure(@list);
        @selfRef.S3Buckets = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SsmGuiConnect.Inputs.PreferencesRecordingDestinationsArgs WithS3Buckets(this global::Pulumi.AwsNative.SsmGuiConnect.Inputs.PreferencesRecordingDestinationsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.SsmGuiConnect.Inputs.PreferencesS3BucketArgs>> @create)
    {
        @selfRef.S3Buckets = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
