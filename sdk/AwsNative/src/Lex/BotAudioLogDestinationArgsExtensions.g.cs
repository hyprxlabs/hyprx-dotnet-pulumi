// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Lex.Inputs;

namespace Pulumi.AwsNative.Lex;

public static partial class BotAudioLogDestinationArgsExtensions
{
    public static global::Pulumi.AwsNative.Lex.Inputs.BotAudioLogDestinationArgs WithS3Bucket(this global::Pulumi.AwsNative.Lex.Inputs.BotAudioLogDestinationArgs @selfRef, global::Pulumi.AwsNative.Lex.Inputs.BotS3BucketLogDestinationArgs s3Bucket)
    {
        @selfRef.S3Bucket = s3Bucket;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lex.Inputs.BotAudioLogDestinationArgs WithS3Bucket(this global::Pulumi.AwsNative.Lex.Inputs.BotAudioLogDestinationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Lex.Inputs.BotS3BucketLogDestinationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Lex.Inputs.BotS3BucketLogDestinationArgs();
        @configure(@item);
        @selfRef.S3Bucket = @item;
        return @selfRef;
    }

}
