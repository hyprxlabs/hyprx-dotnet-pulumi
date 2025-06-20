// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Web.Inputs;

namespace Pulumi.AzureNative.Web;

public static partial class CustomOpenIdConnectProviderArgsExtensions
{
    public static global::Pulumi.AzureNative.Web.Inputs.CustomOpenIdConnectProviderArgs WithEnabled(this global::Pulumi.AzureNative.Web.Inputs.CustomOpenIdConnectProviderArgs @selfRef, bool enabled = true)
    {
        @selfRef.Enabled = enabled;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.Inputs.CustomOpenIdConnectProviderArgs WithLogin(this global::Pulumi.AzureNative.Web.Inputs.CustomOpenIdConnectProviderArgs @selfRef, global::Pulumi.AzureNative.Web.Inputs.OpenIdConnectLoginArgs login)
    {
        @selfRef.Login = login;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.Inputs.CustomOpenIdConnectProviderArgs WithLogin(this global::Pulumi.AzureNative.Web.Inputs.CustomOpenIdConnectProviderArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Web.Inputs.OpenIdConnectLoginArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Web.Inputs.OpenIdConnectLoginArgs();
        @configure(@item);
        @selfRef.Login = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.Inputs.CustomOpenIdConnectProviderArgs WithRegistration(this global::Pulumi.AzureNative.Web.Inputs.CustomOpenIdConnectProviderArgs @selfRef, global::Pulumi.AzureNative.Web.Inputs.OpenIdConnectRegistrationArgs registration)
    {
        @selfRef.Registration = registration;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.Inputs.CustomOpenIdConnectProviderArgs WithRegistration(this global::Pulumi.AzureNative.Web.Inputs.CustomOpenIdConnectProviderArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Web.Inputs.OpenIdConnectRegistrationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Web.Inputs.OpenIdConnectRegistrationArgs();
        @configure(@item);
        @selfRef.Registration = @item;
        return @selfRef;
    }

}
