// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class Ipv6RangeArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.Ipv6RangeArgs WithCidrIpv6(this global::Pulumi.AzureNative.AwsConnector.Inputs.Ipv6RangeArgs @selfRef, global::System.String cidrIpv6)
    {
        @selfRef.CidrIpv6 = cidrIpv6;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.Ipv6RangeArgs WithDescription(this global::Pulumi.AzureNative.AwsConnector.Inputs.Ipv6RangeArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

}
