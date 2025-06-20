// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Storage.Inputs;

namespace Pulumi.AzureNative.Storage;

public static partial class DeleteRetentionPolicyArgsExtensions
{
    public static global::Pulumi.AzureNative.Storage.Inputs.DeleteRetentionPolicyArgs WithAllowPermanentDelete(this global::Pulumi.AzureNative.Storage.Inputs.DeleteRetentionPolicyArgs @selfRef, bool allowPermanentDelete = true)
    {
        @selfRef.AllowPermanentDelete = allowPermanentDelete;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Storage.Inputs.DeleteRetentionPolicyArgs WithDays(this global::Pulumi.AzureNative.Storage.Inputs.DeleteRetentionPolicyArgs @selfRef, global::System.Int32 days)
    {
        @selfRef.Days = days;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Storage.Inputs.DeleteRetentionPolicyArgs WithEnabled(this global::Pulumi.AzureNative.Storage.Inputs.DeleteRetentionPolicyArgs @selfRef, bool enabled = true)
    {
        @selfRef.Enabled = enabled;
        return @selfRef;
    }

}
