// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.ApiCenter.Inputs;

namespace Pulumi.AzureNative.ApiCenter;

public static partial class ContactArgsExtensions
{
    public static global::Pulumi.AzureNative.ApiCenter.Inputs.ContactArgs WithEmail(this global::Pulumi.AzureNative.ApiCenter.Inputs.ContactArgs @selfRef, global::System.String email)
    {
        @selfRef.Email = email;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiCenter.Inputs.ContactArgs WithName(this global::Pulumi.AzureNative.ApiCenter.Inputs.ContactArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiCenter.Inputs.ContactArgs WithUrl(this global::Pulumi.AzureNative.ApiCenter.Inputs.ContactArgs @selfRef, global::System.String url)
    {
        @selfRef.Url = url;
        return @selfRef;
    }

}
