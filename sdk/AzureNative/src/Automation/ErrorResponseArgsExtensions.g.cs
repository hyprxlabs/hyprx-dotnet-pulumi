// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Automation.Inputs;

namespace Pulumi.AzureNative.Automation;

public static partial class ErrorResponseArgsExtensions
{
    public static global::Pulumi.AzureNative.Automation.Inputs.ErrorResponseArgs WithCode(this global::Pulumi.AzureNative.Automation.Inputs.ErrorResponseArgs @selfRef, global::System.String code)
    {
        @selfRef.Code = code;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.Inputs.ErrorResponseArgs WithMessage(this global::Pulumi.AzureNative.Automation.Inputs.ErrorResponseArgs @selfRef, global::System.String message)
    {
        @selfRef.Message = message;
        return @selfRef;
    }

}
