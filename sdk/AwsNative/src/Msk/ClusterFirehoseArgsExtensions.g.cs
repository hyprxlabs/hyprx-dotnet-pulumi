// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Msk.Inputs;

namespace Pulumi.AwsNative.Msk;

public static partial class ClusterFirehoseArgsExtensions
{
    public static global::Pulumi.AwsNative.Msk.Inputs.ClusterFirehoseArgs WithDeliveryStream(this global::Pulumi.AwsNative.Msk.Inputs.ClusterFirehoseArgs @selfRef, global::System.String deliveryStream)
    {
        @selfRef.DeliveryStream = deliveryStream;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Msk.Inputs.ClusterFirehoseArgs WithEnabled(this global::Pulumi.AwsNative.Msk.Inputs.ClusterFirehoseArgs @selfRef, bool enabled = true)
    {
        @selfRef.Enabled = enabled;
        return @selfRef;
    }

}
