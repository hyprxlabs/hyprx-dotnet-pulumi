// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Web.Inputs;

namespace Pulumi.AzureNative.Web;

public static partial class CookieExpirationArgsExtensions
{
    public static global::Pulumi.AzureNative.Web.Inputs.CookieExpirationArgs WithConvention(this global::Pulumi.AzureNative.Web.Inputs.CookieExpirationArgs @selfRef, global::Pulumi.AzureNative.Web.CookieExpirationConvention convention)
    {
        @selfRef.Convention = convention;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.Inputs.CookieExpirationArgs WithConvention(this global::Pulumi.AzureNative.Web.Inputs.CookieExpirationArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Web.CookieExpirationConvention> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AzureNative.Web.CookieExpirationConvention>();
        @configure(@item);
        @selfRef.Convention = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.Inputs.CookieExpirationArgs WithTimeToExpiration(this global::Pulumi.AzureNative.Web.Inputs.CookieExpirationArgs @selfRef, global::System.String timeToExpiration)
    {
        @selfRef.TimeToExpiration = timeToExpiration;
        return @selfRef;
    }

}
