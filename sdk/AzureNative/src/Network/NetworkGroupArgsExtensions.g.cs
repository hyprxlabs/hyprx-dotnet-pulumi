// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Network;

public static partial class NetworkGroupArgsExtensions
{
    public static global::Pulumi.AzureNative.Network.NetworkGroupArgs WithDescription(this global::Pulumi.AzureNative.Network.NetworkGroupArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkGroupArgs WithMemberType(this global::Pulumi.AzureNative.Network.NetworkGroupArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Network.GroupMemberType> memberType)
    {
        @selfRef.MemberType = memberType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkGroupArgs WithNetworkGroupName(this global::Pulumi.AzureNative.Network.NetworkGroupArgs @selfRef, global::System.String networkGroupName)
    {
        @selfRef.NetworkGroupName = networkGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkGroupArgs WithNetworkManagerName(this global::Pulumi.AzureNative.Network.NetworkGroupArgs @selfRef, global::System.String networkManagerName)
    {
        @selfRef.NetworkManagerName = networkManagerName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkGroupArgs WithResourceGroupName(this global::Pulumi.AzureNative.Network.NetworkGroupArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

}
