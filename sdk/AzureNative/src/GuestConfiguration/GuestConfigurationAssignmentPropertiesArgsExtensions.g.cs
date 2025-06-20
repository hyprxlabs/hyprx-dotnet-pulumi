// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.GuestConfiguration.Inputs;

namespace Pulumi.AzureNative.GuestConfiguration;

public static partial class GuestConfigurationAssignmentPropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.GuestConfiguration.Inputs.GuestConfigurationAssignmentPropertiesArgs WithContext(this global::Pulumi.AzureNative.GuestConfiguration.Inputs.GuestConfigurationAssignmentPropertiesArgs @selfRef, global::System.String context)
    {
        @selfRef.Context = context;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.GuestConfiguration.Inputs.GuestConfigurationAssignmentPropertiesArgs WithGuestConfiguration(this global::Pulumi.AzureNative.GuestConfiguration.Inputs.GuestConfigurationAssignmentPropertiesArgs @selfRef, global::Pulumi.AzureNative.GuestConfiguration.Inputs.GuestConfigurationNavigationArgs guestConfiguration)
    {
        @selfRef.GuestConfiguration = guestConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.GuestConfiguration.Inputs.GuestConfigurationAssignmentPropertiesArgs WithGuestConfiguration(this global::Pulumi.AzureNative.GuestConfiguration.Inputs.GuestConfigurationAssignmentPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.GuestConfiguration.Inputs.GuestConfigurationNavigationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.GuestConfiguration.Inputs.GuestConfigurationNavigationArgs();
        @configure(@item);
        @selfRef.GuestConfiguration = @item;
        return @selfRef;
    }

}
