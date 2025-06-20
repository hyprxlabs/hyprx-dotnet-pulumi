// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.VideoAnalyzer;

public static partial class PrivateEndpointConnectionArgsExtensions
{
    public static global::Pulumi.AzureNative.VideoAnalyzer.PrivateEndpointConnectionArgs WithAccountName(this global::Pulumi.AzureNative.VideoAnalyzer.PrivateEndpointConnectionArgs @selfRef, global::System.String accountName)
    {
        @selfRef.AccountName = accountName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.VideoAnalyzer.PrivateEndpointConnectionArgs WithName(this global::Pulumi.AzureNative.VideoAnalyzer.PrivateEndpointConnectionArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.VideoAnalyzer.PrivateEndpointConnectionArgs WithPrivateLinkServiceConnectionState(this global::Pulumi.AzureNative.VideoAnalyzer.PrivateEndpointConnectionArgs @selfRef, global::Pulumi.AzureNative.VideoAnalyzer.Inputs.PrivateLinkServiceConnectionStateArgs privateLinkServiceConnectionState)
    {
        @selfRef.PrivateLinkServiceConnectionState = privateLinkServiceConnectionState;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.VideoAnalyzer.PrivateEndpointConnectionArgs WithPrivateLinkServiceConnectionState(this global::Pulumi.AzureNative.VideoAnalyzer.PrivateEndpointConnectionArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.VideoAnalyzer.Inputs.PrivateLinkServiceConnectionStateArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.VideoAnalyzer.Inputs.PrivateLinkServiceConnectionStateArgs();
        @configure(@item);
        @selfRef.PrivateLinkServiceConnectionState = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.VideoAnalyzer.PrivateEndpointConnectionArgs WithResourceGroupName(this global::Pulumi.AzureNative.VideoAnalyzer.PrivateEndpointConnectionArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

}
