// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class CanarySettingArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.CanarySettingArgs WithDeploymentId(this global::Pulumi.AzureNative.AwsConnector.Inputs.CanarySettingArgs @selfRef, global::System.String deploymentId)
    {
        @selfRef.DeploymentId = deploymentId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.CanarySettingArgs WithPercentTraffic(this global::Pulumi.AzureNative.AwsConnector.Inputs.CanarySettingArgs @selfRef, global::System.Int32 percentTraffic)
    {
        @selfRef.PercentTraffic = percentTraffic;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.CanarySettingArgs WithStageVariableOverrides(this global::Pulumi.AzureNative.AwsConnector.Inputs.CanarySettingArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> stageVariableOverrides)
    {
        @selfRef.StageVariableOverrides = stageVariableOverrides;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.CanarySettingArgs WithStageVariableOverrides(this global::Pulumi.AzureNative.AwsConnector.Inputs.CanarySettingArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.StageVariableOverrides = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.CanarySettingArgs WithStageVariableOverrides(this global::Pulumi.AzureNative.AwsConnector.Inputs.CanarySettingArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.StageVariableOverrides = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.CanarySettingArgs WithUseStageCache(this global::Pulumi.AzureNative.AwsConnector.Inputs.CanarySettingArgs @selfRef, bool useStageCache = true)
    {
        @selfRef.UseStageCache = useStageCache;
        return @selfRef;
    }

}
