// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Compute.Inputs;

namespace Pulumi.AzureNative.Compute;

public static partial class OSImageNotificationProfileArgsExtensions
{
    public static global::Pulumi.AzureNative.Compute.Inputs.OSImageNotificationProfileArgs WithEnable(this global::Pulumi.AzureNative.Compute.Inputs.OSImageNotificationProfileArgs @selfRef, bool enable = true)
    {
        @selfRef.Enable = enable;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.OSImageNotificationProfileArgs WithNotBeforeTimeout(this global::Pulumi.AzureNative.Compute.Inputs.OSImageNotificationProfileArgs @selfRef, global::System.String notBeforeTimeout)
    {
        @selfRef.NotBeforeTimeout = notBeforeTimeout;
        return @selfRef;
    }

}
