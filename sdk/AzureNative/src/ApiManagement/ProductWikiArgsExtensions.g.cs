// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.ApiManagement;

public static partial class ProductWikiArgsExtensions
{
    public static global::Pulumi.AzureNative.ApiManagement.ProductWikiArgs WithDocuments(this global::Pulumi.AzureNative.ApiManagement.ProductWikiArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.ApiManagement.Inputs.WikiDocumentationContractArgs> documents)
    {
        @selfRef.Documents = documents;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.ProductWikiArgs WithDocuments(this global::Pulumi.AzureNative.ApiManagement.ProductWikiArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.ApiManagement.Inputs.WikiDocumentationContractArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.ApiManagement.Inputs.WikiDocumentationContractArgs>();
        @configure(@list);
        @selfRef.Documents = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.ProductWikiArgs WithDocuments(this global::Pulumi.AzureNative.ApiManagement.ProductWikiArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.ApiManagement.Inputs.WikiDocumentationContractArgs>> @create)
    {
        @selfRef.Documents = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.ProductWikiArgs WithProductId(this global::Pulumi.AzureNative.ApiManagement.ProductWikiArgs @selfRef, global::System.String productId)
    {
        @selfRef.ProductId = productId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.ProductWikiArgs WithResourceGroupName(this global::Pulumi.AzureNative.ApiManagement.ProductWikiArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.ProductWikiArgs WithServiceName(this global::Pulumi.AzureNative.ApiManagement.ProductWikiArgs @selfRef, global::System.String serviceName)
    {
        @selfRef.ServiceName = serviceName;
        return @selfRef;
    }

}
