// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Workloads.Inputs;

namespace Pulumi.AzureNative.Workloads;

public static partial class DayArgsExtensions
{
    public static global::Pulumi.AzureNative.Workloads.Inputs.DayArgs WithDate(this global::Pulumi.AzureNative.Workloads.Inputs.DayArgs @selfRef, global::System.Int32 date)
    {
        @selfRef.Date = date;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Workloads.Inputs.DayArgs WithIsLast(this global::Pulumi.AzureNative.Workloads.Inputs.DayArgs @selfRef, bool isLast = true)
    {
        @selfRef.IsLast = isLast;
        return @selfRef;
    }

}
