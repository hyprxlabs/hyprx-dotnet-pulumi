// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.IoTOperationsOrchestrator;

public static partial class InstanceArgsExtensions
{
    public static global::Pulumi.AzureNative.IoTOperationsOrchestrator.InstanceArgs WithExtendedLocation(this global::Pulumi.AzureNative.IoTOperationsOrchestrator.InstanceArgs @selfRef, global::Pulumi.AzureNative.IoTOperationsOrchestrator.Inputs.ExtendedLocationArgs extendedLocation)
    {
        @selfRef.ExtendedLocation = extendedLocation;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsOrchestrator.InstanceArgs WithExtendedLocation(this global::Pulumi.AzureNative.IoTOperationsOrchestrator.InstanceArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.IoTOperationsOrchestrator.Inputs.ExtendedLocationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.IoTOperationsOrchestrator.Inputs.ExtendedLocationArgs();
        @configure(@item);
        @selfRef.ExtendedLocation = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsOrchestrator.InstanceArgs WithLocation(this global::Pulumi.AzureNative.IoTOperationsOrchestrator.InstanceArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsOrchestrator.InstanceArgs WithName(this global::Pulumi.AzureNative.IoTOperationsOrchestrator.InstanceArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsOrchestrator.InstanceArgs WithReconciliationPolicy(this global::Pulumi.AzureNative.IoTOperationsOrchestrator.InstanceArgs @selfRef, global::Pulumi.AzureNative.IoTOperationsOrchestrator.Inputs.ReconciliationPolicyArgs reconciliationPolicy)
    {
        @selfRef.ReconciliationPolicy = reconciliationPolicy;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsOrchestrator.InstanceArgs WithReconciliationPolicy(this global::Pulumi.AzureNative.IoTOperationsOrchestrator.InstanceArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.IoTOperationsOrchestrator.Inputs.ReconciliationPolicyArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.IoTOperationsOrchestrator.Inputs.ReconciliationPolicyArgs();
        @configure(@item);
        @selfRef.ReconciliationPolicy = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsOrchestrator.InstanceArgs WithResourceGroupName(this global::Pulumi.AzureNative.IoTOperationsOrchestrator.InstanceArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsOrchestrator.InstanceArgs WithScope(this global::Pulumi.AzureNative.IoTOperationsOrchestrator.InstanceArgs @selfRef, global::System.String scope)
    {
        @selfRef.Scope = scope;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsOrchestrator.InstanceArgs WithSolution(this global::Pulumi.AzureNative.IoTOperationsOrchestrator.InstanceArgs @selfRef, global::System.String solution)
    {
        @selfRef.Solution = solution;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsOrchestrator.InstanceArgs WithTags(this global::Pulumi.AzureNative.IoTOperationsOrchestrator.InstanceArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsOrchestrator.InstanceArgs WithTags(this global::Pulumi.AzureNative.IoTOperationsOrchestrator.InstanceArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsOrchestrator.InstanceArgs WithTags(this global::Pulumi.AzureNative.IoTOperationsOrchestrator.InstanceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsOrchestrator.InstanceArgs WithTarget(this global::Pulumi.AzureNative.IoTOperationsOrchestrator.InstanceArgs @selfRef, global::Pulumi.AzureNative.IoTOperationsOrchestrator.Inputs.TargetSelectorPropertiesArgs target)
    {
        @selfRef.Target = target;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsOrchestrator.InstanceArgs WithTarget(this global::Pulumi.AzureNative.IoTOperationsOrchestrator.InstanceArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.IoTOperationsOrchestrator.Inputs.TargetSelectorPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.IoTOperationsOrchestrator.Inputs.TargetSelectorPropertiesArgs();
        @configure(@item);
        @selfRef.Target = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsOrchestrator.InstanceArgs WithVersion(this global::Pulumi.AzureNative.IoTOperationsOrchestrator.InstanceArgs @selfRef, global::System.String version)
    {
        @selfRef.Version = version;
        return @selfRef;
    }

}
