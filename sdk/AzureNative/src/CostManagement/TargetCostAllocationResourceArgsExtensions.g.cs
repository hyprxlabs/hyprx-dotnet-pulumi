// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.CostManagement.Inputs;

namespace Pulumi.AzureNative.CostManagement;

public static partial class TargetCostAllocationResourceArgsExtensions
{
    public static global::Pulumi.AzureNative.CostManagement.Inputs.TargetCostAllocationResourceArgs WithName(this global::Pulumi.AzureNative.CostManagement.Inputs.TargetCostAllocationResourceArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CostManagement.Inputs.TargetCostAllocationResourceArgs WithPolicyType(this global::Pulumi.AzureNative.CostManagement.Inputs.TargetCostAllocationResourceArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.CostManagement.CostAllocationPolicyType> policyType)
    {
        @selfRef.PolicyType = policyType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CostManagement.Inputs.TargetCostAllocationResourceArgs WithResourceType(this global::Pulumi.AzureNative.CostManagement.Inputs.TargetCostAllocationResourceArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.CostManagement.CostAllocationResourceType> resourceType)
    {
        @selfRef.ResourceType = resourceType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CostManagement.Inputs.TargetCostAllocationResourceArgs WithValues(this global::Pulumi.AzureNative.CostManagement.Inputs.TargetCostAllocationResourceArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.CostManagement.Inputs.CostAllocationProportionArgs> values)
    {
        @selfRef.Values = values;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CostManagement.Inputs.TargetCostAllocationResourceArgs WithValues(this global::Pulumi.AzureNative.CostManagement.Inputs.TargetCostAllocationResourceArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.CostManagement.Inputs.CostAllocationProportionArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.CostManagement.Inputs.CostAllocationProportionArgs>();
        @configure(@list);
        @selfRef.Values = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CostManagement.Inputs.TargetCostAllocationResourceArgs WithValues(this global::Pulumi.AzureNative.CostManagement.Inputs.TargetCostAllocationResourceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.CostManagement.Inputs.CostAllocationProportionArgs>> @create)
    {
        @selfRef.Values = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
