// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Network.Inputs;

namespace Pulumi.AzureNative.Network;

public static partial class AddressPrefixItemArgsExtensions
{
    public static global::Pulumi.AzureNative.Network.Inputs.AddressPrefixItemArgs WithAddressPrefix(this global::Pulumi.AzureNative.Network.Inputs.AddressPrefixItemArgs @selfRef, global::System.String addressPrefix)
    {
        @selfRef.AddressPrefix = addressPrefix;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.AddressPrefixItemArgs WithAddressPrefixType(this global::Pulumi.AzureNative.Network.Inputs.AddressPrefixItemArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Network.AddressPrefixType> addressPrefixType)
    {
        @selfRef.AddressPrefixType = addressPrefixType;
        return @selfRef;
    }

}
