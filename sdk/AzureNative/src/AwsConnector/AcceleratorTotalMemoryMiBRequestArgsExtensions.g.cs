// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class AcceleratorTotalMemoryMiBRequestArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AcceleratorTotalMemoryMiBRequestArgs WithMax(this global::Pulumi.AzureNative.AwsConnector.Inputs.AcceleratorTotalMemoryMiBRequestArgs @selfRef, global::System.Int32 max)
    {
        @selfRef.Max = max;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AcceleratorTotalMemoryMiBRequestArgs WithMin(this global::Pulumi.AzureNative.AwsConnector.Inputs.AcceleratorTotalMemoryMiBRequestArgs @selfRef, global::System.Int32 min)
    {
        @selfRef.Min = min;
        return @selfRef;
    }

}
