// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.AzureStack;

public static partial class RegistrationArgsExtensions
{
    public static global::Pulumi.AzureNative.AzureStack.RegistrationArgs WithLocation(this global::Pulumi.AzureNative.AzureStack.RegistrationArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AzureStack.Location> location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStack.RegistrationArgs WithRegistrationName(this global::Pulumi.AzureNative.AzureStack.RegistrationArgs @selfRef, global::System.String registrationName)
    {
        @selfRef.RegistrationName = registrationName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStack.RegistrationArgs WithRegistrationToken(this global::Pulumi.AzureNative.AzureStack.RegistrationArgs @selfRef, global::System.String registrationToken)
    {
        @selfRef.RegistrationToken = registrationToken;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStack.RegistrationArgs WithResourceGroup(this global::Pulumi.AzureNative.AzureStack.RegistrationArgs @selfRef, global::System.String resourceGroup)
    {
        @selfRef.ResourceGroup = resourceGroup;
        return @selfRef;
    }

}
