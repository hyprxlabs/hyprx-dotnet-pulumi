// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AzureArcData.Inputs;

namespace Pulumi.AzureNative.AzureArcData;

public static partial class ActiveDirectoryConnectorStatusArgsExtensions
{
    public static global::Pulumi.AzureNative.AzureArcData.Inputs.ActiveDirectoryConnectorStatusArgs WithLastUpdateTime(this global::Pulumi.AzureNative.AzureArcData.Inputs.ActiveDirectoryConnectorStatusArgs @selfRef, global::System.String lastUpdateTime)
    {
        @selfRef.LastUpdateTime = lastUpdateTime;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureArcData.Inputs.ActiveDirectoryConnectorStatusArgs WithObservedGeneration(this global::Pulumi.AzureNative.AzureArcData.Inputs.ActiveDirectoryConnectorStatusArgs @selfRef, global::System.Double observedGeneration)
    {
        @selfRef.ObservedGeneration = observedGeneration;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureArcData.Inputs.ActiveDirectoryConnectorStatusArgs WithState(this global::Pulumi.AzureNative.AzureArcData.Inputs.ActiveDirectoryConnectorStatusArgs @selfRef, global::System.String state)
    {
        @selfRef.State = state;
        return @selfRef;
    }

}
