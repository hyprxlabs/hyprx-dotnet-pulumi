// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.StorSimple.Inputs;

namespace Pulumi.AzureNative.StorSimple;

public static partial class TimeArgsExtensions
{
    public static global::Pulumi.AzureNative.StorSimple.Inputs.TimeArgs WithHours(this global::Pulumi.AzureNative.StorSimple.Inputs.TimeArgs @selfRef, global::System.Int32 hours)
    {
        @selfRef.Hours = hours;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorSimple.Inputs.TimeArgs WithMinutes(this global::Pulumi.AzureNative.StorSimple.Inputs.TimeArgs @selfRef, global::System.Int32 minutes)
    {
        @selfRef.Minutes = minutes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorSimple.Inputs.TimeArgs WithSeconds(this global::Pulumi.AzureNative.StorSimple.Inputs.TimeArgs @selfRef, global::System.Int32 seconds)
    {
        @selfRef.Seconds = seconds;
        return @selfRef;
    }

}
