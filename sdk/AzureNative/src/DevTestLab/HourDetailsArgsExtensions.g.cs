// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DevTestLab.Inputs;

namespace Pulumi.AzureNative.DevTestLab;

public static partial class HourDetailsArgsExtensions
{
    public static global::Pulumi.AzureNative.DevTestLab.Inputs.HourDetailsArgs WithMinute(this global::Pulumi.AzureNative.DevTestLab.Inputs.HourDetailsArgs @selfRef, global::System.Int32 minute)
    {
        @selfRef.Minute = minute;
        return @selfRef;
    }

}
