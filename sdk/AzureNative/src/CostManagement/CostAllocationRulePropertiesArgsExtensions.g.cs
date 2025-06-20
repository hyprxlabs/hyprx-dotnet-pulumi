// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.CostManagement.Inputs;

namespace Pulumi.AzureNative.CostManagement;

public static partial class CostAllocationRulePropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.CostManagement.Inputs.CostAllocationRulePropertiesArgs WithDescription(this global::Pulumi.AzureNative.CostManagement.Inputs.CostAllocationRulePropertiesArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CostManagement.Inputs.CostAllocationRulePropertiesArgs WithDetails(this global::Pulumi.AzureNative.CostManagement.Inputs.CostAllocationRulePropertiesArgs @selfRef, global::Pulumi.AzureNative.CostManagement.Inputs.CostAllocationRuleDetailsArgs details)
    {
        @selfRef.Details = details;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CostManagement.Inputs.CostAllocationRulePropertiesArgs WithDetails(this global::Pulumi.AzureNative.CostManagement.Inputs.CostAllocationRulePropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.CostManagement.Inputs.CostAllocationRuleDetailsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.CostManagement.Inputs.CostAllocationRuleDetailsArgs();
        @configure(@item);
        @selfRef.Details = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CostManagement.Inputs.CostAllocationRulePropertiesArgs WithStatus(this global::Pulumi.AzureNative.CostManagement.Inputs.CostAllocationRulePropertiesArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.CostManagement.RuleStatus> status)
    {
        @selfRef.Status = status;
        return @selfRef;
    }

}
