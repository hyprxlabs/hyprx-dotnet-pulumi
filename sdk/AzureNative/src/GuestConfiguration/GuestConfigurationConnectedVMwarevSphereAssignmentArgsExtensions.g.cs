// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.GuestConfiguration;

public static partial class GuestConfigurationConnectedVMwarevSphereAssignmentArgsExtensions
{
    public static global::Pulumi.AzureNative.GuestConfiguration.GuestConfigurationConnectedVMwarevSphereAssignmentArgs WithGuestConfigurationAssignmentName(this global::Pulumi.AzureNative.GuestConfiguration.GuestConfigurationConnectedVMwarevSphereAssignmentArgs @selfRef, global::System.String guestConfigurationAssignmentName)
    {
        @selfRef.GuestConfigurationAssignmentName = guestConfigurationAssignmentName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.GuestConfiguration.GuestConfigurationConnectedVMwarevSphereAssignmentArgs WithLocation(this global::Pulumi.AzureNative.GuestConfiguration.GuestConfigurationConnectedVMwarevSphereAssignmentArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.GuestConfiguration.GuestConfigurationConnectedVMwarevSphereAssignmentArgs WithName(this global::Pulumi.AzureNative.GuestConfiguration.GuestConfigurationConnectedVMwarevSphereAssignmentArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.GuestConfiguration.GuestConfigurationConnectedVMwarevSphereAssignmentArgs WithProperties(this global::Pulumi.AzureNative.GuestConfiguration.GuestConfigurationConnectedVMwarevSphereAssignmentArgs @selfRef, global::Pulumi.AzureNative.GuestConfiguration.Inputs.GuestConfigurationAssignmentPropertiesArgs properties)
    {
        @selfRef.Properties = properties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.GuestConfiguration.GuestConfigurationConnectedVMwarevSphereAssignmentArgs WithProperties(this global::Pulumi.AzureNative.GuestConfiguration.GuestConfigurationConnectedVMwarevSphereAssignmentArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.GuestConfiguration.Inputs.GuestConfigurationAssignmentPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.GuestConfiguration.Inputs.GuestConfigurationAssignmentPropertiesArgs();
        @configure(@item);
        @selfRef.Properties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.GuestConfiguration.GuestConfigurationConnectedVMwarevSphereAssignmentArgs WithResourceGroupName(this global::Pulumi.AzureNative.GuestConfiguration.GuestConfigurationConnectedVMwarevSphereAssignmentArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.GuestConfiguration.GuestConfigurationConnectedVMwarevSphereAssignmentArgs WithVmName(this global::Pulumi.AzureNative.GuestConfiguration.GuestConfigurationConnectedVMwarevSphereAssignmentArgs @selfRef, global::System.String vmName)
    {
        @selfRef.VmName = vmName;
        return @selfRef;
    }

}
