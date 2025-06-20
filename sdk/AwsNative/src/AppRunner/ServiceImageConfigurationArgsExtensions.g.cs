// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.AppRunner.Inputs;

namespace Pulumi.AwsNative.AppRunner;

public static partial class ServiceImageConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.AppRunner.Inputs.ServiceImageConfigurationArgs WithPort(this global::Pulumi.AwsNative.AppRunner.Inputs.ServiceImageConfigurationArgs @selfRef, global::System.String port)
    {
        @selfRef.Port = port;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppRunner.Inputs.ServiceImageConfigurationArgs WithRuntimeEnvironmentSecrets(this global::Pulumi.AwsNative.AppRunner.Inputs.ServiceImageConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.AppRunner.Inputs.ServiceKeyValuePairArgs> runtimeEnvironmentSecrets)
    {
        @selfRef.RuntimeEnvironmentSecrets = runtimeEnvironmentSecrets;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppRunner.Inputs.ServiceImageConfigurationArgs WithRuntimeEnvironmentSecrets(this global::Pulumi.AwsNative.AppRunner.Inputs.ServiceImageConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.AppRunner.Inputs.ServiceKeyValuePairArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.AppRunner.Inputs.ServiceKeyValuePairArgs>();
        @configure(@list);
        @selfRef.RuntimeEnvironmentSecrets = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppRunner.Inputs.ServiceImageConfigurationArgs WithRuntimeEnvironmentSecrets(this global::Pulumi.AwsNative.AppRunner.Inputs.ServiceImageConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.AppRunner.Inputs.ServiceKeyValuePairArgs>> @create)
    {
        @selfRef.RuntimeEnvironmentSecrets = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppRunner.Inputs.ServiceImageConfigurationArgs WithRuntimeEnvironmentVariables(this global::Pulumi.AwsNative.AppRunner.Inputs.ServiceImageConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.AppRunner.Inputs.ServiceKeyValuePairArgs> runtimeEnvironmentVariables)
    {
        @selfRef.RuntimeEnvironmentVariables = runtimeEnvironmentVariables;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppRunner.Inputs.ServiceImageConfigurationArgs WithRuntimeEnvironmentVariables(this global::Pulumi.AwsNative.AppRunner.Inputs.ServiceImageConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.AppRunner.Inputs.ServiceKeyValuePairArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.AppRunner.Inputs.ServiceKeyValuePairArgs>();
        @configure(@list);
        @selfRef.RuntimeEnvironmentVariables = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppRunner.Inputs.ServiceImageConfigurationArgs WithRuntimeEnvironmentVariables(this global::Pulumi.AwsNative.AppRunner.Inputs.ServiceImageConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.AppRunner.Inputs.ServiceKeyValuePairArgs>> @create)
    {
        @selfRef.RuntimeEnvironmentVariables = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AppRunner.Inputs.ServiceImageConfigurationArgs WithStartCommand(this global::Pulumi.AwsNative.AppRunner.Inputs.ServiceImageConfigurationArgs @selfRef, global::System.String startCommand)
    {
        @selfRef.StartCommand = startCommand;
        return @selfRef;
    }

}
