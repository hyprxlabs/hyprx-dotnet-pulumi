// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.App.Inputs;

namespace Pulumi.AzureNative.App;

public static partial class CookieExpirationArgsExtensions
{
    public static global::Pulumi.AzureNative.App.Inputs.CookieExpirationArgs WithConvention(this global::Pulumi.AzureNative.App.Inputs.CookieExpirationArgs @selfRef, global::Pulumi.AzureNative.App.CookieExpirationConvention convention)
    {
        @selfRef.Convention = convention;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.CookieExpirationArgs WithConvention(this global::Pulumi.AzureNative.App.Inputs.CookieExpirationArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.App.CookieExpirationConvention> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AzureNative.App.CookieExpirationConvention>();
        @configure(@item);
        @selfRef.Convention = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.CookieExpirationArgs WithTimeToExpiration(this global::Pulumi.AzureNative.App.Inputs.CookieExpirationArgs @selfRef, global::System.String timeToExpiration)
    {
        @selfRef.TimeToExpiration = timeToExpiration;
        return @selfRef;
    }

}
