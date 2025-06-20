// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.OperationalInsights;

public static partial class MachineGroupArgsExtensions
{
    public static global::Pulumi.AzureNative.OperationalInsights.MachineGroupArgs WithCount(this global::Pulumi.AzureNative.OperationalInsights.MachineGroupArgs @selfRef, global::System.Int32 count)
    {
        @selfRef.Count = count;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.OperationalInsights.MachineGroupArgs WithDisplayName(this global::Pulumi.AzureNative.OperationalInsights.MachineGroupArgs @selfRef, global::System.String displayName)
    {
        @selfRef.DisplayName = displayName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.OperationalInsights.MachineGroupArgs WithGroupType(this global::Pulumi.AzureNative.OperationalInsights.MachineGroupArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.OperationalInsights.MachineGroupType> groupType)
    {
        @selfRef.GroupType = groupType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.OperationalInsights.MachineGroupArgs WithKind(this global::Pulumi.AzureNative.OperationalInsights.MachineGroupArgs @selfRef, global::System.String kind)
    {
        @selfRef.Kind = kind;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.OperationalInsights.MachineGroupArgs WithMachineGroupName(this global::Pulumi.AzureNative.OperationalInsights.MachineGroupArgs @selfRef, global::System.String machineGroupName)
    {
        @selfRef.MachineGroupName = machineGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.OperationalInsights.MachineGroupArgs WithMachines(this global::Pulumi.AzureNative.OperationalInsights.MachineGroupArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.OperationalInsights.Inputs.MachineReferenceWithHintsArgs> machines)
    {
        @selfRef.Machines = machines;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.OperationalInsights.MachineGroupArgs WithMachines(this global::Pulumi.AzureNative.OperationalInsights.MachineGroupArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.OperationalInsights.Inputs.MachineReferenceWithHintsArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.OperationalInsights.Inputs.MachineReferenceWithHintsArgs>();
        @configure(@list);
        @selfRef.Machines = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.OperationalInsights.MachineGroupArgs WithMachines(this global::Pulumi.AzureNative.OperationalInsights.MachineGroupArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.OperationalInsights.Inputs.MachineReferenceWithHintsArgs>> @create)
    {
        @selfRef.Machines = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.OperationalInsights.MachineGroupArgs WithResourceGroupName(this global::Pulumi.AzureNative.OperationalInsights.MachineGroupArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.OperationalInsights.MachineGroupArgs WithWorkspaceName(this global::Pulumi.AzureNative.OperationalInsights.MachineGroupArgs @selfRef, global::System.String workspaceName)
    {
        @selfRef.WorkspaceName = workspaceName;
        return @selfRef;
    }

}
