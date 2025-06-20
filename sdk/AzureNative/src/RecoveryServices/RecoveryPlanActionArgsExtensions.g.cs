// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.RecoveryServices.Inputs;

namespace Pulumi.AzureNative.RecoveryServices;

public static partial class RecoveryPlanActionArgsExtensions
{
    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.RecoveryPlanActionArgs WithActionName(this global::Pulumi.AzureNative.RecoveryServices.Inputs.RecoveryPlanActionArgs @selfRef, global::System.String actionName)
    {
        @selfRef.ActionName = actionName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.RecoveryPlanActionArgs WithFailoverDirections(this global::Pulumi.AzureNative.RecoveryServices.Inputs.RecoveryPlanActionArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.RecoveryServices.PossibleOperationsDirections>> failoverDirections)
    {
        @selfRef.FailoverDirections = failoverDirections;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.RecoveryPlanActionArgs WithFailoverDirections(this global::Pulumi.AzureNative.RecoveryServices.Inputs.RecoveryPlanActionArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.RecoveryServices.PossibleOperationsDirections>>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.RecoveryServices.PossibleOperationsDirections>>();
        @configure(@list);
        @selfRef.FailoverDirections = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.RecoveryPlanActionArgs WithFailoverDirections(this global::Pulumi.AzureNative.RecoveryServices.Inputs.RecoveryPlanActionArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.RecoveryServices.PossibleOperationsDirections>>> @create)
    {
        @selfRef.FailoverDirections = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.RecoveryPlanActionArgs WithFailoverTypes(this global::Pulumi.AzureNative.RecoveryServices.Inputs.RecoveryPlanActionArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.RecoveryServices.ReplicationProtectedItemOperation>> failoverTypes)
    {
        @selfRef.FailoverTypes = failoverTypes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.RecoveryPlanActionArgs WithFailoverTypes(this global::Pulumi.AzureNative.RecoveryServices.Inputs.RecoveryPlanActionArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.RecoveryServices.ReplicationProtectedItemOperation>>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.RecoveryServices.ReplicationProtectedItemOperation>>();
        @configure(@list);
        @selfRef.FailoverTypes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.RecoveryPlanActionArgs WithFailoverTypes(this global::Pulumi.AzureNative.RecoveryServices.Inputs.RecoveryPlanActionArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.RecoveryServices.ReplicationProtectedItemOperation>>> @create)
    {
        @selfRef.FailoverTypes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
