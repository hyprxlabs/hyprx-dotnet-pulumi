// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Network;

public static partial class VirtualWanArgsExtensions
{
    public static global::Pulumi.AzureNative.Network.VirtualWanArgs WithAllowBranchToBranchTraffic(this global::Pulumi.AzureNative.Network.VirtualWanArgs @selfRef, bool allowBranchToBranchTraffic = true)
    {
        @selfRef.AllowBranchToBranchTraffic = allowBranchToBranchTraffic;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.VirtualWanArgs WithAllowVnetToVnetTraffic(this global::Pulumi.AzureNative.Network.VirtualWanArgs @selfRef, bool allowVnetToVnetTraffic = true)
    {
        @selfRef.AllowVnetToVnetTraffic = allowVnetToVnetTraffic;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.VirtualWanArgs WithDisableVpnEncryption(this global::Pulumi.AzureNative.Network.VirtualWanArgs @selfRef, bool disableVpnEncryption = true)
    {
        @selfRef.DisableVpnEncryption = disableVpnEncryption;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.VirtualWanArgs WithId(this global::Pulumi.AzureNative.Network.VirtualWanArgs @selfRef, global::System.String id)
    {
        @selfRef.Id = id;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.VirtualWanArgs WithLocation(this global::Pulumi.AzureNative.Network.VirtualWanArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.VirtualWanArgs WithResourceGroupName(this global::Pulumi.AzureNative.Network.VirtualWanArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.VirtualWanArgs WithTags(this global::Pulumi.AzureNative.Network.VirtualWanArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.VirtualWanArgs WithTags(this global::Pulumi.AzureNative.Network.VirtualWanArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.VirtualWanArgs WithTags(this global::Pulumi.AzureNative.Network.VirtualWanArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.VirtualWanArgs WithType(this global::Pulumi.AzureNative.Network.VirtualWanArgs @selfRef, global::System.String type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.VirtualWanArgs WithVirtualWANName(this global::Pulumi.AzureNative.Network.VirtualWanArgs @selfRef, global::System.String virtualWANName)
    {
        @selfRef.VirtualWANName = virtualWANName;
        return @selfRef;
    }

}
