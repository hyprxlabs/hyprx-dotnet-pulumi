// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.SecurityInsights.Inputs;

namespace Pulumi.AzureNative.SecurityInsights;

public static partial class InstructionStepDetailsArgsExtensions
{
    public static global::Pulumi.AzureNative.SecurityInsights.Inputs.InstructionStepDetailsArgs WithParameters(this global::Pulumi.AzureNative.SecurityInsights.Inputs.InstructionStepDetailsArgs @selfRef, global::System.Object parameters)
    {
        @selfRef.Parameters = parameters;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.Inputs.InstructionStepDetailsArgs WithParameters(this global::Pulumi.AzureNative.SecurityInsights.Inputs.InstructionStepDetailsArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.Parameters = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.Inputs.InstructionStepDetailsArgs WithType(this global::Pulumi.AzureNative.SecurityInsights.Inputs.InstructionStepDetailsArgs @selfRef, global::System.String type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

}
