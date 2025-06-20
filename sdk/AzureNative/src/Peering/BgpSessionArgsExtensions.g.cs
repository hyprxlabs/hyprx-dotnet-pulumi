// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Peering.Inputs;

namespace Pulumi.AzureNative.Peering;

public static partial class BgpSessionArgsExtensions
{
    public static global::Pulumi.AzureNative.Peering.Inputs.BgpSessionArgs WithMaxPrefixesAdvertisedV4(this global::Pulumi.AzureNative.Peering.Inputs.BgpSessionArgs @selfRef, global::System.Int32 maxPrefixesAdvertisedV4)
    {
        @selfRef.MaxPrefixesAdvertisedV4 = maxPrefixesAdvertisedV4;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Peering.Inputs.BgpSessionArgs WithMaxPrefixesAdvertisedV6(this global::Pulumi.AzureNative.Peering.Inputs.BgpSessionArgs @selfRef, global::System.Int32 maxPrefixesAdvertisedV6)
    {
        @selfRef.MaxPrefixesAdvertisedV6 = maxPrefixesAdvertisedV6;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Peering.Inputs.BgpSessionArgs WithMd5AuthenticationKey(this global::Pulumi.AzureNative.Peering.Inputs.BgpSessionArgs @selfRef, global::System.String md5AuthenticationKey)
    {
        @selfRef.Md5AuthenticationKey = md5AuthenticationKey;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Peering.Inputs.BgpSessionArgs WithMicrosoftSessionIPv4Address(this global::Pulumi.AzureNative.Peering.Inputs.BgpSessionArgs @selfRef, global::System.String microsoftSessionIPv4Address)
    {
        @selfRef.MicrosoftSessionIPv4Address = microsoftSessionIPv4Address;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Peering.Inputs.BgpSessionArgs WithMicrosoftSessionIPv6Address(this global::Pulumi.AzureNative.Peering.Inputs.BgpSessionArgs @selfRef, global::System.String microsoftSessionIPv6Address)
    {
        @selfRef.MicrosoftSessionIPv6Address = microsoftSessionIPv6Address;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Peering.Inputs.BgpSessionArgs WithPeerSessionIPv4Address(this global::Pulumi.AzureNative.Peering.Inputs.BgpSessionArgs @selfRef, global::System.String peerSessionIPv4Address)
    {
        @selfRef.PeerSessionIPv4Address = peerSessionIPv4Address;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Peering.Inputs.BgpSessionArgs WithPeerSessionIPv6Address(this global::Pulumi.AzureNative.Peering.Inputs.BgpSessionArgs @selfRef, global::System.String peerSessionIPv6Address)
    {
        @selfRef.PeerSessionIPv6Address = peerSessionIPv6Address;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Peering.Inputs.BgpSessionArgs WithSessionPrefixV4(this global::Pulumi.AzureNative.Peering.Inputs.BgpSessionArgs @selfRef, global::System.String sessionPrefixV4)
    {
        @selfRef.SessionPrefixV4 = sessionPrefixV4;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Peering.Inputs.BgpSessionArgs WithSessionPrefixV6(this global::Pulumi.AzureNative.Peering.Inputs.BgpSessionArgs @selfRef, global::System.String sessionPrefixV6)
    {
        @selfRef.SessionPrefixV6 = sessionPrefixV6;
        return @selfRef;
    }

}
