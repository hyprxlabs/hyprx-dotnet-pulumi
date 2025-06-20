// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.MachineLearningServices.Inputs;

namespace Pulumi.AzureNative.MachineLearningServices;

public static partial class CreateMonitorActionArgsExtensions
{
    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.CreateMonitorActionArgs WithActionType(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.CreateMonitorActionArgs @selfRef, global::System.String actionType)
    {
        @selfRef.ActionType = actionType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.CreateMonitorActionArgs WithMonitorDefinition(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.CreateMonitorActionArgs @selfRef, global::Pulumi.AzureNative.MachineLearningServices.Inputs.MonitorDefinitionArgs monitorDefinition)
    {
        @selfRef.MonitorDefinition = monitorDefinition;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.CreateMonitorActionArgs WithMonitorDefinition(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.CreateMonitorActionArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.MachineLearningServices.Inputs.MonitorDefinitionArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.MachineLearningServices.Inputs.MonitorDefinitionArgs();
        @configure(@item);
        @selfRef.MonitorDefinition = @item;
        return @selfRef;
    }

}
