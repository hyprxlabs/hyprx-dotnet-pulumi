// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Media.Inputs;

namespace Pulumi.AzureNative.Media;

public static partial class FilterTrackPropertyConditionArgsExtensions
{
    public static global::Pulumi.AzureNative.Media.Inputs.FilterTrackPropertyConditionArgs WithOperation(this global::Pulumi.AzureNative.Media.Inputs.FilterTrackPropertyConditionArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Media.FilterTrackPropertyCompareOperation> operation)
    {
        @selfRef.Operation = operation;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Media.Inputs.FilterTrackPropertyConditionArgs WithProperty(this global::Pulumi.AzureNative.Media.Inputs.FilterTrackPropertyConditionArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Media.FilterTrackPropertyType> property)
    {
        @selfRef.Property = property;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Media.Inputs.FilterTrackPropertyConditionArgs WithValue(this global::Pulumi.AzureNative.Media.Inputs.FilterTrackPropertyConditionArgs @selfRef, global::System.String value)
    {
        @selfRef.Value = value;
        return @selfRef;
    }

}
