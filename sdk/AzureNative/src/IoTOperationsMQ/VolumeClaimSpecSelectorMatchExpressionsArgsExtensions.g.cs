// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.IoTOperationsMQ.Inputs;

namespace Pulumi.AzureNative.IoTOperationsMQ;

public static partial class VolumeClaimSpecSelectorMatchExpressionsArgsExtensions
{
    public static global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.VolumeClaimSpecSelectorMatchExpressionsArgs WithKey(this global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.VolumeClaimSpecSelectorMatchExpressionsArgs @selfRef, global::System.String key)
    {
        @selfRef.Key = key;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.VolumeClaimSpecSelectorMatchExpressionsArgs WithOperator(this global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.VolumeClaimSpecSelectorMatchExpressionsArgs @selfRef, global::System.String @operator)
    {
        @selfRef.Operator = @operator;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.VolumeClaimSpecSelectorMatchExpressionsArgs WithValues(this global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.VolumeClaimSpecSelectorMatchExpressionsArgs @selfRef, global::System.Collections.Generic.List<global::System.String> values)
    {
        @selfRef.Values = values;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.VolumeClaimSpecSelectorMatchExpressionsArgs WithValues(this global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.VolumeClaimSpecSelectorMatchExpressionsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Values = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.VolumeClaimSpecSelectorMatchExpressionsArgs WithValues(this global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.VolumeClaimSpecSelectorMatchExpressionsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Values = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
