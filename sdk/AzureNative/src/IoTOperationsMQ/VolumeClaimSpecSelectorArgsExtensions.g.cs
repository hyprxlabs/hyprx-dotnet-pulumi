// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.IoTOperationsMQ.Inputs;

namespace Pulumi.AzureNative.IoTOperationsMQ;

public static partial class VolumeClaimSpecSelectorArgsExtensions
{
    public static global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.VolumeClaimSpecSelectorArgs WithMatchExpressions(this global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.VolumeClaimSpecSelectorArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.VolumeClaimSpecSelectorMatchExpressionsArgs> matchExpressions)
    {
        @selfRef.MatchExpressions = matchExpressions;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.VolumeClaimSpecSelectorArgs WithMatchExpressions(this global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.VolumeClaimSpecSelectorArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.VolumeClaimSpecSelectorMatchExpressionsArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.VolumeClaimSpecSelectorMatchExpressionsArgs>();
        @configure(@list);
        @selfRef.MatchExpressions = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.VolumeClaimSpecSelectorArgs WithMatchExpressions(this global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.VolumeClaimSpecSelectorArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.VolumeClaimSpecSelectorMatchExpressionsArgs>> @create)
    {
        @selfRef.MatchExpressions = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.VolumeClaimSpecSelectorArgs WithMatchLabels(this global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.VolumeClaimSpecSelectorArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> matchLabels)
    {
        @selfRef.MatchLabels = matchLabels;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.VolumeClaimSpecSelectorArgs WithMatchLabels(this global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.VolumeClaimSpecSelectorArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.MatchLabels = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.VolumeClaimSpecSelectorArgs WithMatchLabels(this global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.VolumeClaimSpecSelectorArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.MatchLabels = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
