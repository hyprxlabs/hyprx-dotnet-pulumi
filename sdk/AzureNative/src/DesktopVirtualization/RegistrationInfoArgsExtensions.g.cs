// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DesktopVirtualization.Inputs;

namespace Pulumi.AzureNative.DesktopVirtualization;

public static partial class RegistrationInfoArgsExtensions
{
    public static global::Pulumi.AzureNative.DesktopVirtualization.Inputs.RegistrationInfoArgs WithExpirationTime(this global::Pulumi.AzureNative.DesktopVirtualization.Inputs.RegistrationInfoArgs @selfRef, global::System.String expirationTime)
    {
        @selfRef.ExpirationTime = expirationTime;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DesktopVirtualization.Inputs.RegistrationInfoArgs WithRegistrationTokenOperation(this global::Pulumi.AzureNative.DesktopVirtualization.Inputs.RegistrationInfoArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.DesktopVirtualization.RegistrationTokenOperation> registrationTokenOperation)
    {
        @selfRef.RegistrationTokenOperation = registrationTokenOperation;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DesktopVirtualization.Inputs.RegistrationInfoArgs WithToken(this global::Pulumi.AzureNative.DesktopVirtualization.Inputs.RegistrationInfoArgs @selfRef, global::System.String token)
    {
        @selfRef.Token = token;
        return @selfRef;
    }

}
