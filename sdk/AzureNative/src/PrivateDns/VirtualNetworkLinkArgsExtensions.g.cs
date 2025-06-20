// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.PrivateDns;

public static partial class VirtualNetworkLinkArgsExtensions
{
    public static global::Pulumi.AzureNative.PrivateDns.VirtualNetworkLinkArgs WithLocation(this global::Pulumi.AzureNative.PrivateDns.VirtualNetworkLinkArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.PrivateDns.VirtualNetworkLinkArgs WithPrivateZoneName(this global::Pulumi.AzureNative.PrivateDns.VirtualNetworkLinkArgs @selfRef, global::System.String privateZoneName)
    {
        @selfRef.PrivateZoneName = privateZoneName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.PrivateDns.VirtualNetworkLinkArgs WithRegistrationEnabled(this global::Pulumi.AzureNative.PrivateDns.VirtualNetworkLinkArgs @selfRef, bool registrationEnabled = true)
    {
        @selfRef.RegistrationEnabled = registrationEnabled;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.PrivateDns.VirtualNetworkLinkArgs WithResolutionPolicy(this global::Pulumi.AzureNative.PrivateDns.VirtualNetworkLinkArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.PrivateDns.ResolutionPolicy> resolutionPolicy)
    {
        @selfRef.ResolutionPolicy = resolutionPolicy;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.PrivateDns.VirtualNetworkLinkArgs WithResourceGroupName(this global::Pulumi.AzureNative.PrivateDns.VirtualNetworkLinkArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.PrivateDns.VirtualNetworkLinkArgs WithTags(this global::Pulumi.AzureNative.PrivateDns.VirtualNetworkLinkArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.PrivateDns.VirtualNetworkLinkArgs WithTags(this global::Pulumi.AzureNative.PrivateDns.VirtualNetworkLinkArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.PrivateDns.VirtualNetworkLinkArgs WithTags(this global::Pulumi.AzureNative.PrivateDns.VirtualNetworkLinkArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.PrivateDns.VirtualNetworkLinkArgs WithVirtualNetwork(this global::Pulumi.AzureNative.PrivateDns.VirtualNetworkLinkArgs @selfRef, global::Pulumi.AzureNative.PrivateDns.Inputs.SubResourceArgs virtualNetwork)
    {
        @selfRef.VirtualNetwork = virtualNetwork;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.PrivateDns.VirtualNetworkLinkArgs WithVirtualNetwork(this global::Pulumi.AzureNative.PrivateDns.VirtualNetworkLinkArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.PrivateDns.Inputs.SubResourceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.PrivateDns.Inputs.SubResourceArgs();
        @configure(@item);
        @selfRef.VirtualNetwork = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.PrivateDns.VirtualNetworkLinkArgs WithVirtualNetworkLinkName(this global::Pulumi.AzureNative.PrivateDns.VirtualNetworkLinkArgs @selfRef, global::System.String virtualNetworkLinkName)
    {
        @selfRef.VirtualNetworkLinkName = virtualNetworkLinkName;
        return @selfRef;
    }

}
