// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Ses.Inputs;

namespace Pulumi.AwsNative.Ses;

public static partial class ConfigurationSetEventDestinationKinesisFirehoseDestinationArgsExtensions
{
    public static global::Pulumi.AwsNative.Ses.Inputs.ConfigurationSetEventDestinationKinesisFirehoseDestinationArgs WithDeliveryStreamArn(this global::Pulumi.AwsNative.Ses.Inputs.ConfigurationSetEventDestinationKinesisFirehoseDestinationArgs @selfRef, global::System.String deliveryStreamArn)
    {
        @selfRef.DeliveryStreamArn = deliveryStreamArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ses.Inputs.ConfigurationSetEventDestinationKinesisFirehoseDestinationArgs WithIamRoleArn(this global::Pulumi.AwsNative.Ses.Inputs.ConfigurationSetEventDestinationKinesisFirehoseDestinationArgs @selfRef, global::System.String iamRoleArn)
    {
        @selfRef.IamRoleArn = iamRoleArn;
        return @selfRef;
    }

}
