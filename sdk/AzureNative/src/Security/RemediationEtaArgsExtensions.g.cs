// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Security.Inputs;

namespace Pulumi.AzureNative.Security;

public static partial class RemediationEtaArgsExtensions
{
    public static global::Pulumi.AzureNative.Security.Inputs.RemediationEtaArgs WithEta(this global::Pulumi.AzureNative.Security.Inputs.RemediationEtaArgs @selfRef, global::System.String eta)
    {
        @selfRef.Eta = eta;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Security.Inputs.RemediationEtaArgs WithJustification(this global::Pulumi.AzureNative.Security.Inputs.RemediationEtaArgs @selfRef, global::System.String justification)
    {
        @selfRef.Justification = justification;
        return @selfRef;
    }

}
