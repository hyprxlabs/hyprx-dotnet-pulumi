// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.App.Inputs;

namespace Pulumi.AzureNative.App;

public static partial class HttpSettingsArgsExtensions
{
    public static global::Pulumi.AzureNative.App.Inputs.HttpSettingsArgs WithForwardProxy(this global::Pulumi.AzureNative.App.Inputs.HttpSettingsArgs @selfRef, global::Pulumi.AzureNative.App.Inputs.ForwardProxyArgs forwardProxy)
    {
        @selfRef.ForwardProxy = forwardProxy;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.HttpSettingsArgs WithForwardProxy(this global::Pulumi.AzureNative.App.Inputs.HttpSettingsArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.App.Inputs.ForwardProxyArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.App.Inputs.ForwardProxyArgs();
        @configure(@item);
        @selfRef.ForwardProxy = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.HttpSettingsArgs WithRequireHttps(this global::Pulumi.AzureNative.App.Inputs.HttpSettingsArgs @selfRef, bool requireHttps = true)
    {
        @selfRef.RequireHttps = requireHttps;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.HttpSettingsArgs WithRoutes(this global::Pulumi.AzureNative.App.Inputs.HttpSettingsArgs @selfRef, global::Pulumi.AzureNative.App.Inputs.HttpSettingsRoutesArgs routes)
    {
        @selfRef.Routes = routes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.HttpSettingsArgs WithRoutes(this global::Pulumi.AzureNative.App.Inputs.HttpSettingsArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.App.Inputs.HttpSettingsRoutesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.App.Inputs.HttpSettingsRoutesArgs();
        @configure(@item);
        @selfRef.Routes = @item;
        return @selfRef;
    }

}
