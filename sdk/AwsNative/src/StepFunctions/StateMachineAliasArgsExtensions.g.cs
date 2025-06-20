// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.StepFunctions;

public static partial class StateMachineAliasArgsExtensions
{
    public static global::Pulumi.AwsNative.StepFunctions.StateMachineAliasArgs WithDeploymentPreference(this global::Pulumi.AwsNative.StepFunctions.StateMachineAliasArgs @selfRef, global::Pulumi.AwsNative.StepFunctions.Inputs.StateMachineAliasDeploymentPreferenceArgs deploymentPreference)
    {
        @selfRef.DeploymentPreference = deploymentPreference;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.StepFunctions.StateMachineAliasArgs WithDeploymentPreference(this global::Pulumi.AwsNative.StepFunctions.StateMachineAliasArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.StepFunctions.Inputs.StateMachineAliasDeploymentPreferenceArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.StepFunctions.Inputs.StateMachineAliasDeploymentPreferenceArgs();
        @configure(@item);
        @selfRef.DeploymentPreference = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.StepFunctions.StateMachineAliasArgs WithDescription(this global::Pulumi.AwsNative.StepFunctions.StateMachineAliasArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.StepFunctions.StateMachineAliasArgs WithName(this global::Pulumi.AwsNative.StepFunctions.StateMachineAliasArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.StepFunctions.StateMachineAliasArgs WithRoutingConfiguration(this global::Pulumi.AwsNative.StepFunctions.StateMachineAliasArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.StepFunctions.Inputs.StateMachineAliasRoutingConfigurationVersionArgs> routingConfiguration)
    {
        @selfRef.RoutingConfiguration = routingConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.StepFunctions.StateMachineAliasArgs WithRoutingConfiguration(this global::Pulumi.AwsNative.StepFunctions.StateMachineAliasArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.StepFunctions.Inputs.StateMachineAliasRoutingConfigurationVersionArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.StepFunctions.Inputs.StateMachineAliasRoutingConfigurationVersionArgs>();
        @configure(@list);
        @selfRef.RoutingConfiguration = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.StepFunctions.StateMachineAliasArgs WithRoutingConfiguration(this global::Pulumi.AwsNative.StepFunctions.StateMachineAliasArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.StepFunctions.Inputs.StateMachineAliasRoutingConfigurationVersionArgs>> @create)
    {
        @selfRef.RoutingConfiguration = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
