// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AadIam.Inputs;

namespace Pulumi.AzureNative.AadIam;

public static partial class RetentionPolicyArgsExtensions
{
    public static global::Pulumi.AzureNative.AadIam.Inputs.RetentionPolicyArgs WithDays(this global::Pulumi.AzureNative.AadIam.Inputs.RetentionPolicyArgs @selfRef, global::System.Int32 days)
    {
        @selfRef.Days = days;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AadIam.Inputs.RetentionPolicyArgs WithEnabled(this global::Pulumi.AzureNative.AadIam.Inputs.RetentionPolicyArgs @selfRef, bool enabled = true)
    {
        @selfRef.Enabled = enabled;
        return @selfRef;
    }

}
