// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.ApiManagement.Inputs;

namespace Pulumi.AzureNative.ApiManagement;

public static partial class LLMMessageDiagnosticSettingsArgsExtensions
{
    public static global::Pulumi.AzureNative.ApiManagement.Inputs.LLMMessageDiagnosticSettingsArgs WithMaxSizeInBytes(this global::Pulumi.AzureNative.ApiManagement.Inputs.LLMMessageDiagnosticSettingsArgs @selfRef, global::System.Int32 maxSizeInBytes)
    {
        @selfRef.MaxSizeInBytes = maxSizeInBytes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.Inputs.LLMMessageDiagnosticSettingsArgs WithMessages(this global::Pulumi.AzureNative.ApiManagement.Inputs.LLMMessageDiagnosticSettingsArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.ApiManagement.LlmMessageLogTypes> messages)
    {
        @selfRef.Messages = messages;
        return @selfRef;
    }

}
