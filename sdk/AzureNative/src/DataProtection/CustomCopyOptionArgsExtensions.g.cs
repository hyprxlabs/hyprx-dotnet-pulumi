// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataProtection.Inputs;

namespace Pulumi.AzureNative.DataProtection;

public static partial class CustomCopyOptionArgsExtensions
{
    public static global::Pulumi.AzureNative.DataProtection.Inputs.CustomCopyOptionArgs WithDuration(this global::Pulumi.AzureNative.DataProtection.Inputs.CustomCopyOptionArgs @selfRef, global::System.String duration)
    {
        @selfRef.Duration = duration;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataProtection.Inputs.CustomCopyOptionArgs WithObjectType(this global::Pulumi.AzureNative.DataProtection.Inputs.CustomCopyOptionArgs @selfRef, global::System.String objectType)
    {
        @selfRef.ObjectType = objectType;
        return @selfRef;
    }

}
