// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Workloads.Inputs;

namespace Pulumi.AzureNative.Workloads;

public static partial class UserAssignedServiceIdentityArgsExtensions
{
    public static global::Pulumi.AzureNative.Workloads.Inputs.UserAssignedServiceIdentityArgs WithType(this global::Pulumi.AzureNative.Workloads.Inputs.UserAssignedServiceIdentityArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Workloads.ManagedServiceIdentityType> type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Workloads.Inputs.UserAssignedServiceIdentityArgs WithUserAssignedIdentities(this global::Pulumi.AzureNative.Workloads.Inputs.UserAssignedServiceIdentityArgs @selfRef, global::System.Collections.Generic.List<global::System.String> userAssignedIdentities)
    {
        @selfRef.UserAssignedIdentities = userAssignedIdentities;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Workloads.Inputs.UserAssignedServiceIdentityArgs WithUserAssignedIdentities(this global::Pulumi.AzureNative.Workloads.Inputs.UserAssignedServiceIdentityArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.UserAssignedIdentities = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Workloads.Inputs.UserAssignedServiceIdentityArgs WithUserAssignedIdentities(this global::Pulumi.AzureNative.Workloads.Inputs.UserAssignedServiceIdentityArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.UserAssignedIdentities = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
