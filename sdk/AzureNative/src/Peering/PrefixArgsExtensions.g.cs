// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Peering;

public static partial class PrefixArgsExtensions
{
    public static global::Pulumi.AzureNative.Peering.PrefixArgs WithPeeringServiceName(this global::Pulumi.AzureNative.Peering.PrefixArgs @selfRef, global::System.String peeringServiceName)
    {
        @selfRef.PeeringServiceName = peeringServiceName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Peering.PrefixArgs WithPeeringServicePrefixKey(this global::Pulumi.AzureNative.Peering.PrefixArgs @selfRef, global::System.String peeringServicePrefixKey)
    {
        @selfRef.PeeringServicePrefixKey = peeringServicePrefixKey;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Peering.PrefixArgs WithPrefix(this global::Pulumi.AzureNative.Peering.PrefixArgs @selfRef, global::System.String prefix)
    {
        @selfRef.Prefix = prefix;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Peering.PrefixArgs WithPrefixName(this global::Pulumi.AzureNative.Peering.PrefixArgs @selfRef, global::System.String prefixName)
    {
        @selfRef.PrefixName = prefixName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Peering.PrefixArgs WithResourceGroupName(this global::Pulumi.AzureNative.Peering.PrefixArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

}
