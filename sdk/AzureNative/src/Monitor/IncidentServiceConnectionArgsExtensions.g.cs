// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Monitor.Inputs;

namespace Pulumi.AzureNative.Monitor;

public static partial class IncidentServiceConnectionArgsExtensions
{
    public static global::Pulumi.AzureNative.Monitor.Inputs.IncidentServiceConnectionArgs WithId(this global::Pulumi.AzureNative.Monitor.Inputs.IncidentServiceConnectionArgs @selfRef, global::System.String id)
    {
        @selfRef.Id = id;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.IncidentServiceConnectionArgs WithName(this global::Pulumi.AzureNative.Monitor.Inputs.IncidentServiceConnectionArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

}
