// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.StepFunctions.Inputs;

namespace Pulumi.AwsNative.StepFunctions;

public static partial class StateMachineLoggingConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.StepFunctions.Inputs.StateMachineLoggingConfigurationArgs WithDestinations(this global::Pulumi.AwsNative.StepFunctions.Inputs.StateMachineLoggingConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.StepFunctions.Inputs.StateMachineLogDestinationArgs> destinations)
    {
        @selfRef.Destinations = destinations;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.StepFunctions.Inputs.StateMachineLoggingConfigurationArgs WithDestinations(this global::Pulumi.AwsNative.StepFunctions.Inputs.StateMachineLoggingConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.StepFunctions.Inputs.StateMachineLogDestinationArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.StepFunctions.Inputs.StateMachineLogDestinationArgs>();
        @configure(@list);
        @selfRef.Destinations = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.StepFunctions.Inputs.StateMachineLoggingConfigurationArgs WithDestinations(this global::Pulumi.AwsNative.StepFunctions.Inputs.StateMachineLoggingConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.StepFunctions.Inputs.StateMachineLogDestinationArgs>> @create)
    {
        @selfRef.Destinations = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.StepFunctions.Inputs.StateMachineLoggingConfigurationArgs WithIncludeExecutionData(this global::Pulumi.AwsNative.StepFunctions.Inputs.StateMachineLoggingConfigurationArgs @selfRef, bool includeExecutionData = true)
    {
        @selfRef.IncludeExecutionData = includeExecutionData;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.StepFunctions.Inputs.StateMachineLoggingConfigurationArgs WithLevel(this global::Pulumi.AwsNative.StepFunctions.Inputs.StateMachineLoggingConfigurationArgs @selfRef, global::Pulumi.AwsNative.StepFunctions.StateMachineLoggingConfigurationLevel level)
    {
        @selfRef.Level = level;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.StepFunctions.Inputs.StateMachineLoggingConfigurationArgs WithLevel(this global::Pulumi.AwsNative.StepFunctions.Inputs.StateMachineLoggingConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.StepFunctions.StateMachineLoggingConfigurationLevel> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.StepFunctions.StateMachineLoggingConfigurationLevel>();
        @configure(@item);
        @selfRef.Level = @item;
        return @selfRef;
    }

}
