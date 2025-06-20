// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Network;

public static partial class ReachabilityAnalysisIntentArgsExtensions
{
    public static global::Pulumi.AzureNative.Network.ReachabilityAnalysisIntentArgs WithNetworkManagerName(this global::Pulumi.AzureNative.Network.ReachabilityAnalysisIntentArgs @selfRef, global::System.String networkManagerName)
    {
        @selfRef.NetworkManagerName = networkManagerName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.ReachabilityAnalysisIntentArgs WithProperties(this global::Pulumi.AzureNative.Network.ReachabilityAnalysisIntentArgs @selfRef, global::Pulumi.AzureNative.Network.Inputs.ReachabilityAnalysisIntentPropertiesArgs properties)
    {
        @selfRef.Properties = properties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.ReachabilityAnalysisIntentArgs WithProperties(this global::Pulumi.AzureNative.Network.ReachabilityAnalysisIntentArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Network.Inputs.ReachabilityAnalysisIntentPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Network.Inputs.ReachabilityAnalysisIntentPropertiesArgs();
        @configure(@item);
        @selfRef.Properties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.ReachabilityAnalysisIntentArgs WithReachabilityAnalysisIntentName(this global::Pulumi.AzureNative.Network.ReachabilityAnalysisIntentArgs @selfRef, global::System.String reachabilityAnalysisIntentName)
    {
        @selfRef.ReachabilityAnalysisIntentName = reachabilityAnalysisIntentName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.ReachabilityAnalysisIntentArgs WithResourceGroupName(this global::Pulumi.AzureNative.Network.ReachabilityAnalysisIntentArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.ReachabilityAnalysisIntentArgs WithWorkspaceName(this global::Pulumi.AzureNative.Network.ReachabilityAnalysisIntentArgs @selfRef, global::System.String workspaceName)
    {
        @selfRef.WorkspaceName = workspaceName;
        return @selfRef;
    }

}
