// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.App.Inputs;

namespace Pulumi.AzureNative.App;

public static partial class BuildConfigurationArgsExtensions
{
    public static global::Pulumi.AzureNative.App.Inputs.BuildConfigurationArgs WithBaseOs(this global::Pulumi.AzureNative.App.Inputs.BuildConfigurationArgs @selfRef, global::System.String baseOs)
    {
        @selfRef.BaseOs = baseOs;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.BuildConfigurationArgs WithEnvironmentVariables(this global::Pulumi.AzureNative.App.Inputs.BuildConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.App.Inputs.EnvironmentVariableArgs> environmentVariables)
    {
        @selfRef.EnvironmentVariables = environmentVariables;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.BuildConfigurationArgs WithEnvironmentVariables(this global::Pulumi.AzureNative.App.Inputs.BuildConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.App.Inputs.EnvironmentVariableArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.App.Inputs.EnvironmentVariableArgs>();
        @configure(@list);
        @selfRef.EnvironmentVariables = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.BuildConfigurationArgs WithEnvironmentVariables(this global::Pulumi.AzureNative.App.Inputs.BuildConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.App.Inputs.EnvironmentVariableArgs>> @create)
    {
        @selfRef.EnvironmentVariables = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.BuildConfigurationArgs WithPlatform(this global::Pulumi.AzureNative.App.Inputs.BuildConfigurationArgs @selfRef, global::System.String platform)
    {
        @selfRef.Platform = platform;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.BuildConfigurationArgs WithPlatformVersion(this global::Pulumi.AzureNative.App.Inputs.BuildConfigurationArgs @selfRef, global::System.String platformVersion)
    {
        @selfRef.PlatformVersion = platformVersion;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.BuildConfigurationArgs WithPreBuildSteps(this global::Pulumi.AzureNative.App.Inputs.BuildConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.App.Inputs.PreBuildStepArgs> preBuildSteps)
    {
        @selfRef.PreBuildSteps = preBuildSteps;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.BuildConfigurationArgs WithPreBuildSteps(this global::Pulumi.AzureNative.App.Inputs.BuildConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.App.Inputs.PreBuildStepArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.App.Inputs.PreBuildStepArgs>();
        @configure(@list);
        @selfRef.PreBuildSteps = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.BuildConfigurationArgs WithPreBuildSteps(this global::Pulumi.AzureNative.App.Inputs.BuildConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.App.Inputs.PreBuildStepArgs>> @create)
    {
        @selfRef.PreBuildSteps = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
