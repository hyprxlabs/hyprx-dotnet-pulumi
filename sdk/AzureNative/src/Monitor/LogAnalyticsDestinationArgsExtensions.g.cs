// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Monitor.Inputs;

namespace Pulumi.AzureNative.Monitor;

public static partial class LogAnalyticsDestinationArgsExtensions
{
    public static global::Pulumi.AzureNative.Monitor.Inputs.LogAnalyticsDestinationArgs WithName(this global::Pulumi.AzureNative.Monitor.Inputs.LogAnalyticsDestinationArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.LogAnalyticsDestinationArgs WithWorkspaceResourceId(this global::Pulumi.AzureNative.Monitor.Inputs.LogAnalyticsDestinationArgs @selfRef, global::System.String workspaceResourceId)
    {
        @selfRef.WorkspaceResourceId = workspaceResourceId;
        return @selfRef;
    }

}
