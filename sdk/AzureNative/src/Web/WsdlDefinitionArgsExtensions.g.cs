// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Web.Inputs;

namespace Pulumi.AzureNative.Web;

public static partial class WsdlDefinitionArgsExtensions
{
    public static global::Pulumi.AzureNative.Web.Inputs.WsdlDefinitionArgs WithContent(this global::Pulumi.AzureNative.Web.Inputs.WsdlDefinitionArgs @selfRef, global::System.String content)
    {
        @selfRef.Content = content;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.Inputs.WsdlDefinitionArgs WithImportMethod(this global::Pulumi.AzureNative.Web.Inputs.WsdlDefinitionArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Web.WsdlImportMethod> importMethod)
    {
        @selfRef.ImportMethod = importMethod;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.Inputs.WsdlDefinitionArgs WithService(this global::Pulumi.AzureNative.Web.Inputs.WsdlDefinitionArgs @selfRef, global::Pulumi.AzureNative.Web.Inputs.WsdlServiceArgs service)
    {
        @selfRef.Service = service;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.Inputs.WsdlDefinitionArgs WithService(this global::Pulumi.AzureNative.Web.Inputs.WsdlDefinitionArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Web.Inputs.WsdlServiceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Web.Inputs.WsdlServiceArgs();
        @configure(@item);
        @selfRef.Service = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.Inputs.WsdlDefinitionArgs WithUrl(this global::Pulumi.AzureNative.Web.Inputs.WsdlDefinitionArgs @selfRef, global::System.String url)
    {
        @selfRef.Url = url;
        return @selfRef;
    }

}
