// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.CloudFront.Inputs;

namespace Pulumi.AwsNative.CloudFront;

public static partial class DistributionGeoRestrictionArgsExtensions
{
    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionGeoRestrictionArgs WithLocations(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionGeoRestrictionArgs @selfRef, global::System.Collections.Generic.List<global::System.String> locations)
    {
        @selfRef.Locations = locations;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionGeoRestrictionArgs WithLocations(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionGeoRestrictionArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Locations = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionGeoRestrictionArgs WithLocations(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionGeoRestrictionArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Locations = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.Inputs.DistributionGeoRestrictionArgs WithRestrictionType(this global::Pulumi.AwsNative.CloudFront.Inputs.DistributionGeoRestrictionArgs @selfRef, global::System.String restrictionType)
    {
        @selfRef.RestrictionType = restrictionType;
        return @selfRef;
    }

}
