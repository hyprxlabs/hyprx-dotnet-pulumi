// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.KinesisFirehose.Inputs;

namespace Pulumi.AwsNative.KinesisFirehose;

public static partial class DeliveryStreamRedshiftRetryOptionsArgsExtensions
{
    public static global::Pulumi.AwsNative.KinesisFirehose.Inputs.DeliveryStreamRedshiftRetryOptionsArgs WithDurationInSeconds(this global::Pulumi.AwsNative.KinesisFirehose.Inputs.DeliveryStreamRedshiftRetryOptionsArgs @selfRef, global::System.Int32 durationInSeconds)
    {
        @selfRef.DurationInSeconds = durationInSeconds;
        return @selfRef;
    }

}
