// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Web.Inputs;

namespace Pulumi.AzureNative.Web;

public static partial class ApiConnectionTestLinkArgsExtensions
{
    public static global::Pulumi.AzureNative.Web.Inputs.ApiConnectionTestLinkArgs WithMethod(this global::Pulumi.AzureNative.Web.Inputs.ApiConnectionTestLinkArgs @selfRef, global::System.String method)
    {
        @selfRef.Method = method;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.Inputs.ApiConnectionTestLinkArgs WithRequestUri(this global::Pulumi.AzureNative.Web.Inputs.ApiConnectionTestLinkArgs @selfRef, global::System.String requestUri)
    {
        @selfRef.RequestUri = requestUri;
        return @selfRef;
    }

}
