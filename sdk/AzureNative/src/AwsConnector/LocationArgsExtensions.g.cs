// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class LocationArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.LocationArgs WithAvailabilityZone(this global::Pulumi.AzureNative.AwsConnector.Inputs.LocationArgs @selfRef, global::System.String availabilityZone)
    {
        @selfRef.AvailabilityZone = availabilityZone;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.LocationArgs WithRegionName(this global::Pulumi.AzureNative.AwsConnector.Inputs.LocationArgs @selfRef, global::System.String regionName)
    {
        @selfRef.RegionName = regionName;
        return @selfRef;
    }

}
