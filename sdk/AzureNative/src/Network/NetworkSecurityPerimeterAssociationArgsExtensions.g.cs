// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Network;

public static partial class NetworkSecurityPerimeterAssociationArgsExtensions
{
    public static global::Pulumi.AzureNative.Network.NetworkSecurityPerimeterAssociationArgs WithAccessMode(this global::Pulumi.AzureNative.Network.NetworkSecurityPerimeterAssociationArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Network.AssociationAccessMode> accessMode)
    {
        @selfRef.AccessMode = accessMode;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkSecurityPerimeterAssociationArgs WithAssociationName(this global::Pulumi.AzureNative.Network.NetworkSecurityPerimeterAssociationArgs @selfRef, global::System.String associationName)
    {
        @selfRef.AssociationName = associationName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkSecurityPerimeterAssociationArgs WithId(this global::Pulumi.AzureNative.Network.NetworkSecurityPerimeterAssociationArgs @selfRef, global::System.String id)
    {
        @selfRef.Id = id;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkSecurityPerimeterAssociationArgs WithLocation(this global::Pulumi.AzureNative.Network.NetworkSecurityPerimeterAssociationArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkSecurityPerimeterAssociationArgs WithNetworkSecurityPerimeterName(this global::Pulumi.AzureNative.Network.NetworkSecurityPerimeterAssociationArgs @selfRef, global::System.String networkSecurityPerimeterName)
    {
        @selfRef.NetworkSecurityPerimeterName = networkSecurityPerimeterName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkSecurityPerimeterAssociationArgs WithPrivateLinkResource(this global::Pulumi.AzureNative.Network.NetworkSecurityPerimeterAssociationArgs @selfRef, global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs privateLinkResource)
    {
        @selfRef.PrivateLinkResource = privateLinkResource;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkSecurityPerimeterAssociationArgs WithPrivateLinkResource(this global::Pulumi.AzureNative.Network.NetworkSecurityPerimeterAssociationArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs();
        @configure(@item);
        @selfRef.PrivateLinkResource = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkSecurityPerimeterAssociationArgs WithProfile(this global::Pulumi.AzureNative.Network.NetworkSecurityPerimeterAssociationArgs @selfRef, global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs profile)
    {
        @selfRef.Profile = profile;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkSecurityPerimeterAssociationArgs WithProfile(this global::Pulumi.AzureNative.Network.NetworkSecurityPerimeterAssociationArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs();
        @configure(@item);
        @selfRef.Profile = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkSecurityPerimeterAssociationArgs WithResourceGroupName(this global::Pulumi.AzureNative.Network.NetworkSecurityPerimeterAssociationArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkSecurityPerimeterAssociationArgs WithTags(this global::Pulumi.AzureNative.Network.NetworkSecurityPerimeterAssociationArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkSecurityPerimeterAssociationArgs WithTags(this global::Pulumi.AzureNative.Network.NetworkSecurityPerimeterAssociationArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkSecurityPerimeterAssociationArgs WithTags(this global::Pulumi.AzureNative.Network.NetworkSecurityPerimeterAssociationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
