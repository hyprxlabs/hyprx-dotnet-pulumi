// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.SecurityInsights;

public static partial class AnomaliesArgsExtensions
{
    public static global::Pulumi.AzureNative.SecurityInsights.AnomaliesArgs WithKind(this global::Pulumi.AzureNative.SecurityInsights.AnomaliesArgs @selfRef, global::System.String kind)
    {
        @selfRef.Kind = kind;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.AnomaliesArgs WithResourceGroupName(this global::Pulumi.AzureNative.SecurityInsights.AnomaliesArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.AnomaliesArgs WithSettingsName(this global::Pulumi.AzureNative.SecurityInsights.AnomaliesArgs @selfRef, global::System.String settingsName)
    {
        @selfRef.SettingsName = settingsName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.AnomaliesArgs WithWorkspaceName(this global::Pulumi.AzureNative.SecurityInsights.AnomaliesArgs @selfRef, global::System.String workspaceName)
    {
        @selfRef.WorkspaceName = workspaceName;
        return @selfRef;
    }

}
