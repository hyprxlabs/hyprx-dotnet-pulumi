// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.CostManagement.Inputs;

namespace Pulumi.AzureNative.CostManagement;

public static partial class ExportTimePeriodArgsExtensions
{
    public static global::Pulumi.AzureNative.CostManagement.Inputs.ExportTimePeriodArgs WithFrom(this global::Pulumi.AzureNative.CostManagement.Inputs.ExportTimePeriodArgs @selfRef, global::System.String from)
    {
        @selfRef.From = from;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CostManagement.Inputs.ExportTimePeriodArgs WithTo(this global::Pulumi.AzureNative.CostManagement.Inputs.ExportTimePeriodArgs @selfRef, global::System.String to)
    {
        @selfRef.To = to;
        return @selfRef;
    }

}
