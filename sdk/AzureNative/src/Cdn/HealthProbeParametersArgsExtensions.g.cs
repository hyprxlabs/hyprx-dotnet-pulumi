// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Cdn.Inputs;

namespace Pulumi.AzureNative.Cdn;

public static partial class HealthProbeParametersArgsExtensions
{
    public static global::Pulumi.AzureNative.Cdn.Inputs.HealthProbeParametersArgs WithProbeIntervalInSeconds(this global::Pulumi.AzureNative.Cdn.Inputs.HealthProbeParametersArgs @selfRef, global::System.Int32 probeIntervalInSeconds)
    {
        @selfRef.ProbeIntervalInSeconds = probeIntervalInSeconds;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Cdn.Inputs.HealthProbeParametersArgs WithProbePath(this global::Pulumi.AzureNative.Cdn.Inputs.HealthProbeParametersArgs @selfRef, global::System.String probePath)
    {
        @selfRef.ProbePath = probePath;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Cdn.Inputs.HealthProbeParametersArgs WithProbeProtocol(this global::Pulumi.AzureNative.Cdn.Inputs.HealthProbeParametersArgs @selfRef, global::Pulumi.AzureNative.Cdn.ProbeProtocol probeProtocol)
    {
        @selfRef.ProbeProtocol = probeProtocol;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Cdn.Inputs.HealthProbeParametersArgs WithProbeProtocol(this global::Pulumi.AzureNative.Cdn.Inputs.HealthProbeParametersArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Cdn.ProbeProtocol> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AzureNative.Cdn.ProbeProtocol>();
        @configure(@item);
        @selfRef.ProbeProtocol = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Cdn.Inputs.HealthProbeParametersArgs WithProbeRequestType(this global::Pulumi.AzureNative.Cdn.Inputs.HealthProbeParametersArgs @selfRef, global::Pulumi.AzureNative.Cdn.HealthProbeRequestType probeRequestType)
    {
        @selfRef.ProbeRequestType = probeRequestType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Cdn.Inputs.HealthProbeParametersArgs WithProbeRequestType(this global::Pulumi.AzureNative.Cdn.Inputs.HealthProbeParametersArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Cdn.HealthProbeRequestType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AzureNative.Cdn.HealthProbeRequestType>();
        @configure(@item);
        @selfRef.ProbeRequestType = @item;
        return @selfRef;
    }

}
