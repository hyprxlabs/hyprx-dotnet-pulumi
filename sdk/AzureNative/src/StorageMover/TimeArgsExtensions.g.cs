// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.StorageMover.Inputs;

namespace Pulumi.AzureNative.StorageMover;

public static partial class TimeArgsExtensions
{
    public static global::Pulumi.AzureNative.StorageMover.Inputs.TimeArgs WithHour(this global::Pulumi.AzureNative.StorageMover.Inputs.TimeArgs @selfRef, global::System.Int32 hour)
    {
        @selfRef.Hour = hour;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorageMover.Inputs.TimeArgs WithMinute(this global::Pulumi.AzureNative.StorageMover.Inputs.TimeArgs @selfRef, global::System.Int32 minute)
    {
        @selfRef.Minute = minute;
        return @selfRef;
    }

}
