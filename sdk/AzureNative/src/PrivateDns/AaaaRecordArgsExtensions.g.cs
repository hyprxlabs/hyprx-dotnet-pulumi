// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.PrivateDns.Inputs;

namespace Pulumi.AzureNative.PrivateDns;

public static partial class AaaaRecordArgsExtensions
{
    public static global::Pulumi.AzureNative.PrivateDns.Inputs.AaaaRecordArgs WithIpv6Address(this global::Pulumi.AzureNative.PrivateDns.Inputs.AaaaRecordArgs @selfRef, global::System.String ipv6Address)
    {
        @selfRef.Ipv6Address = ipv6Address;
        return @selfRef;
    }

}
