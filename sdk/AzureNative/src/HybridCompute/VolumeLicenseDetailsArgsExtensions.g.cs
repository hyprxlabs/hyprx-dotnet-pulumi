// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.HybridCompute.Inputs;

namespace Pulumi.AzureNative.HybridCompute;

public static partial class VolumeLicenseDetailsArgsExtensions
{
    public static global::Pulumi.AzureNative.HybridCompute.Inputs.VolumeLicenseDetailsArgs WithInvoiceId(this global::Pulumi.AzureNative.HybridCompute.Inputs.VolumeLicenseDetailsArgs @selfRef, global::System.String invoiceId)
    {
        @selfRef.InvoiceId = invoiceId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridCompute.Inputs.VolumeLicenseDetailsArgs WithProgramYear(this global::Pulumi.AzureNative.HybridCompute.Inputs.VolumeLicenseDetailsArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.HybridCompute.ProgramYear> programYear)
    {
        @selfRef.ProgramYear = programYear;
        return @selfRef;
    }

}
