// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Datadog.Inputs;

namespace Pulumi.AzureNative.Datadog;

public static partial class UserInfoArgsExtensions
{
    public static global::Pulumi.AzureNative.Datadog.Inputs.UserInfoArgs WithEmailAddress(this global::Pulumi.AzureNative.Datadog.Inputs.UserInfoArgs @selfRef, global::System.String emailAddress)
    {
        @selfRef.EmailAddress = emailAddress;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Datadog.Inputs.UserInfoArgs WithName(this global::Pulumi.AzureNative.Datadog.Inputs.UserInfoArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Datadog.Inputs.UserInfoArgs WithPhoneNumber(this global::Pulumi.AzureNative.Datadog.Inputs.UserInfoArgs @selfRef, global::System.String phoneNumber)
    {
        @selfRef.PhoneNumber = phoneNumber;
        return @selfRef;
    }

}
