// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.VerifiedPermissions.Inputs;

namespace Pulumi.AwsNative.VerifiedPermissions;

public static partial class PolicyStoreValidationSettingsArgsExtensions
{
    public static global::Pulumi.AwsNative.VerifiedPermissions.Inputs.PolicyStoreValidationSettingsArgs WithMode(this global::Pulumi.AwsNative.VerifiedPermissions.Inputs.PolicyStoreValidationSettingsArgs @selfRef, global::Pulumi.AwsNative.VerifiedPermissions.PolicyStoreValidationMode mode)
    {
        @selfRef.Mode = mode;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.VerifiedPermissions.Inputs.PolicyStoreValidationSettingsArgs WithMode(this global::Pulumi.AwsNative.VerifiedPermissions.Inputs.PolicyStoreValidationSettingsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.VerifiedPermissions.PolicyStoreValidationMode> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.VerifiedPermissions.PolicyStoreValidationMode>();
        @configure(@item);
        @selfRef.Mode = @item;
        return @selfRef;
    }

}
