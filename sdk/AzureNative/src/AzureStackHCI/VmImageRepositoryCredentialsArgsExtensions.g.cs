// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AzureStackHCI.Inputs;

namespace Pulumi.AzureNative.AzureStackHCI;

public static partial class VmImageRepositoryCredentialsArgsExtensions
{
    public static global::Pulumi.AzureNative.AzureStackHCI.Inputs.VmImageRepositoryCredentialsArgs WithPassword(this global::Pulumi.AzureNative.AzureStackHCI.Inputs.VmImageRepositoryCredentialsArgs @selfRef, global::System.String password)
    {
        @selfRef.Password = password;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.Inputs.VmImageRepositoryCredentialsArgs WithUsername(this global::Pulumi.AzureNative.AzureStackHCI.Inputs.VmImageRepositoryCredentialsArgs @selfRef, global::System.String username)
    {
        @selfRef.Username = username;
        return @selfRef;
    }

}
