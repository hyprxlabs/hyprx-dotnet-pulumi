// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class ZoneAwarenessConfigArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ZoneAwarenessConfigArgs WithAvailabilityZoneCount(this global::Pulumi.AzureNative.AwsConnector.Inputs.ZoneAwarenessConfigArgs @selfRef, global::System.Int32 availabilityZoneCount)
    {
        @selfRef.AvailabilityZoneCount = availabilityZoneCount;
        return @selfRef;
    }

}
