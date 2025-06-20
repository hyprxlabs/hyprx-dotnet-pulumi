// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.AppRunner.Inputs;

namespace Pulumi.AwsNative.AppRunner;

public static partial class ServiceCodeConfigurationValuesArgsExtensions
{
    public static global::Pulumi.AwsNative.AppRunner.Inputs.ServiceCodeConfigurationValuesArgs WithBuildCommand(this global::Pulumi.AwsNative.AppRunner.Inputs.ServiceCodeConfigurationValuesArgs @selfRef, global::System.String buildCommand)
    {
        @selfRef.BuildCommand = buildCommand;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppRunner.Inputs.ServiceCodeConfigurationValuesArgs WithPort(this global::Pulumi.AwsNative.AppRunner.Inputs.ServiceCodeConfigurationValuesArgs @selfRef, global::System.String port)
    {
        @selfRef.Port = port;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppRunner.Inputs.ServiceCodeConfigurationValuesArgs WithRuntime(this global::Pulumi.AwsNative.AppRunner.Inputs.ServiceCodeConfigurationValuesArgs @selfRef, global::Pulumi.AwsNative.AppRunner.ServiceCodeConfigurationValuesRuntime runtime)
    {
        @selfRef.Runtime = runtime;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppRunner.Inputs.ServiceCodeConfigurationValuesArgs WithRuntime(this global::Pulumi.AwsNative.AppRunner.Inputs.ServiceCodeConfigurationValuesArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.AppRunner.ServiceCodeConfigurationValuesRuntime> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.AppRunner.ServiceCodeConfigurationValuesRuntime>();
        @configure(@item);
        @selfRef.Runtime = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppRunner.Inputs.ServiceCodeConfigurationValuesArgs WithRuntimeEnvironmentSecrets(this global::Pulumi.AwsNative.AppRunner.Inputs.ServiceCodeConfigurationValuesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.AppRunner.Inputs.ServiceKeyValuePairArgs> runtimeEnvironmentSecrets)
    {
        @selfRef.RuntimeEnvironmentSecrets = runtimeEnvironmentSecrets;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppRunner.Inputs.ServiceCodeConfigurationValuesArgs WithRuntimeEnvironmentSecrets(this global::Pulumi.AwsNative.AppRunner.Inputs.ServiceCodeConfigurationValuesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.AppRunner.Inputs.ServiceKeyValuePairArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.AppRunner.Inputs.ServiceKeyValuePairArgs>();
        @configure(@list);
        @selfRef.RuntimeEnvironmentSecrets = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppRunner.Inputs.ServiceCodeConfigurationValuesArgs WithRuntimeEnvironmentSecrets(this global::Pulumi.AwsNative.AppRunner.Inputs.ServiceCodeConfigurationValuesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.AppRunner.Inputs.ServiceKeyValuePairArgs>> @create)
    {
        @selfRef.RuntimeEnvironmentSecrets = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppRunner.Inputs.ServiceCodeConfigurationValuesArgs WithRuntimeEnvironmentVariables(this global::Pulumi.AwsNative.AppRunner.Inputs.ServiceCodeConfigurationValuesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.AppRunner.Inputs.ServiceKeyValuePairArgs> runtimeEnvironmentVariables)
    {
        @selfRef.RuntimeEnvironmentVariables = runtimeEnvironmentVariables;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppRunner.Inputs.ServiceCodeConfigurationValuesArgs WithRuntimeEnvironmentVariables(this global::Pulumi.AwsNative.AppRunner.Inputs.ServiceCodeConfigurationValuesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.AppRunner.Inputs.ServiceKeyValuePairArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.AppRunner.Inputs.ServiceKeyValuePairArgs>();
        @configure(@list);
        @selfRef.RuntimeEnvironmentVariables = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppRunner.Inputs.ServiceCodeConfigurationValuesArgs WithRuntimeEnvironmentVariables(this global::Pulumi.AwsNative.AppRunner.Inputs.ServiceCodeConfigurationValuesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.AppRunner.Inputs.ServiceKeyValuePairArgs>> @create)
    {
        @selfRef.RuntimeEnvironmentVariables = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppRunner.Inputs.ServiceCodeConfigurationValuesArgs WithStartCommand(this global::Pulumi.AwsNative.AppRunner.Inputs.ServiceCodeConfigurationValuesArgs @selfRef, global::System.String startCommand)
    {
        @selfRef.StartCommand = startCommand;
        return @selfRef;
    }

}
