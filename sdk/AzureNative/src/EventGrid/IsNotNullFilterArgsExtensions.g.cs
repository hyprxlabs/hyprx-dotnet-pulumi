// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.EventGrid.Inputs;

namespace Pulumi.AzureNative.EventGrid;

public static partial class IsNotNullFilterArgsExtensions
{
    public static global::Pulumi.AzureNative.EventGrid.Inputs.IsNotNullFilterArgs WithKey(this global::Pulumi.AzureNative.EventGrid.Inputs.IsNotNullFilterArgs @selfRef, global::System.String key)
    {
        @selfRef.Key = key;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EventGrid.Inputs.IsNotNullFilterArgs WithOperatorType(this global::Pulumi.AzureNative.EventGrid.Inputs.IsNotNullFilterArgs @selfRef, global::System.String operatorType)
    {
        @selfRef.OperatorType = operatorType;
        return @selfRef;
    }

}
