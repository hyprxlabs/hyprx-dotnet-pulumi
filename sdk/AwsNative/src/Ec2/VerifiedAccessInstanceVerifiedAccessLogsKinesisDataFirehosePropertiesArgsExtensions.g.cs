// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Ec2.Inputs;

namespace Pulumi.AwsNative.Ec2;

public static partial class VerifiedAccessInstanceVerifiedAccessLogsKinesisDataFirehosePropertiesArgsExtensions
{
    public static global::Pulumi.AwsNative.Ec2.Inputs.VerifiedAccessInstanceVerifiedAccessLogsKinesisDataFirehosePropertiesArgs WithDeliveryStream(this global::Pulumi.AwsNative.Ec2.Inputs.VerifiedAccessInstanceVerifiedAccessLogsKinesisDataFirehosePropertiesArgs @selfRef, global::System.String deliveryStream)
    {
        @selfRef.DeliveryStream = deliveryStream;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.VerifiedAccessInstanceVerifiedAccessLogsKinesisDataFirehosePropertiesArgs WithEnabled(this global::Pulumi.AwsNative.Ec2.Inputs.VerifiedAccessInstanceVerifiedAccessLogsKinesisDataFirehosePropertiesArgs @selfRef, bool enabled = true)
    {
        @selfRef.Enabled = enabled;
        return @selfRef;
    }

}
