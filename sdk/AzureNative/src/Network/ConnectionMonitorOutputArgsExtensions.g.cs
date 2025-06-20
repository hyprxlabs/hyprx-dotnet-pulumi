// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Network.Inputs;

namespace Pulumi.AzureNative.Network;

public static partial class ConnectionMonitorOutputArgsExtensions
{
    public static global::Pulumi.AzureNative.Network.Inputs.ConnectionMonitorOutputArgs WithType(this global::Pulumi.AzureNative.Network.Inputs.ConnectionMonitorOutputArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Network.OutputType> type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ConnectionMonitorOutputArgs WithWorkspaceSettings(this global::Pulumi.AzureNative.Network.Inputs.ConnectionMonitorOutputArgs @selfRef, global::Pulumi.AzureNative.Network.Inputs.ConnectionMonitorWorkspaceSettingsArgs workspaceSettings)
    {
        @selfRef.WorkspaceSettings = workspaceSettings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ConnectionMonitorOutputArgs WithWorkspaceSettings(this global::Pulumi.AzureNative.Network.Inputs.ConnectionMonitorOutputArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Network.Inputs.ConnectionMonitorWorkspaceSettingsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Network.Inputs.ConnectionMonitorWorkspaceSettingsArgs();
        @configure(@item);
        @selfRef.WorkspaceSettings = @item;
        return @selfRef;
    }

}
