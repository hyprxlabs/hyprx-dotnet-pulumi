// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.IntegrationSpaces.Inputs;

namespace Pulumi.AzureNative.IntegrationSpaces;

public static partial class BusinessProcessMappingItemArgsExtensions
{
    public static global::Pulumi.AzureNative.IntegrationSpaces.Inputs.BusinessProcessMappingItemArgs WithLogicAppResourceId(this global::Pulumi.AzureNative.IntegrationSpaces.Inputs.BusinessProcessMappingItemArgs @selfRef, global::System.String logicAppResourceId)
    {
        @selfRef.LogicAppResourceId = logicAppResourceId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IntegrationSpaces.Inputs.BusinessProcessMappingItemArgs WithOperationName(this global::Pulumi.AzureNative.IntegrationSpaces.Inputs.BusinessProcessMappingItemArgs @selfRef, global::System.String operationName)
    {
        @selfRef.OperationName = operationName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IntegrationSpaces.Inputs.BusinessProcessMappingItemArgs WithOperationType(this global::Pulumi.AzureNative.IntegrationSpaces.Inputs.BusinessProcessMappingItemArgs @selfRef, global::System.String operationType)
    {
        @selfRef.OperationType = operationType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IntegrationSpaces.Inputs.BusinessProcessMappingItemArgs WithWorkflowName(this global::Pulumi.AzureNative.IntegrationSpaces.Inputs.BusinessProcessMappingItemArgs @selfRef, global::System.String workflowName)
    {
        @selfRef.WorkflowName = workflowName;
        return @selfRef;
    }

}
