// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.CloudFront.Inputs;

namespace Pulumi.AwsNative.CloudFront;

public static partial class DistributionOriginShieldArgsExtensions
{
    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionOriginShieldArgs WithEnabled(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionOriginShieldArgs @selfRef, bool enabled = true)
    {
        @selfRef.Enabled = enabled;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionOriginShieldArgs WithOriginShieldRegion(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionOriginShieldArgs @selfRef, global::System.String originShieldRegion)
    {
        @selfRef.OriginShieldRegion = originShieldRegion;
        return @selfRef;
    }

}
