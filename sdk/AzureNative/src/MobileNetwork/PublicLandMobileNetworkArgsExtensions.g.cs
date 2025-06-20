// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.MobileNetwork.Inputs;

namespace Pulumi.AzureNative.MobileNetwork;

public static partial class PublicLandMobileNetworkArgsExtensions
{
    public static global::Pulumi.AzureNative.MobileNetwork.Inputs.PublicLandMobileNetworkArgs WithHomeNetworkPublicKeys(this global::Pulumi.AzureNative.MobileNetwork.Inputs.PublicLandMobileNetworkArgs @selfRef, global::Pulumi.AzureNative.MobileNetwork.Inputs.PublicLandMobileNetworkHomeNetworkPublicKeysArgs homeNetworkPublicKeys)
    {
        @selfRef.HomeNetworkPublicKeys = homeNetworkPublicKeys;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MobileNetwork.Inputs.PublicLandMobileNetworkArgs WithHomeNetworkPublicKeys(this global::Pulumi.AzureNative.MobileNetwork.Inputs.PublicLandMobileNetworkArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.MobileNetwork.Inputs.PublicLandMobileNetworkHomeNetworkPublicKeysArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.MobileNetwork.Inputs.PublicLandMobileNetworkHomeNetworkPublicKeysArgs();
        @configure(@item);
        @selfRef.HomeNetworkPublicKeys = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MobileNetwork.Inputs.PublicLandMobileNetworkArgs WithMcc(this global::Pulumi.AzureNative.MobileNetwork.Inputs.PublicLandMobileNetworkArgs @selfRef, global::System.String mcc)
    {
        @selfRef.Mcc = mcc;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MobileNetwork.Inputs.PublicLandMobileNetworkArgs WithMnc(this global::Pulumi.AzureNative.MobileNetwork.Inputs.PublicLandMobileNetworkArgs @selfRef, global::System.String mnc)
    {
        @selfRef.Mnc = mnc;
        return @selfRef;
    }

}
