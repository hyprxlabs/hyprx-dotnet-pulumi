// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.CodeSigning;

public static partial class CodeSigningAccountArgsExtensions
{
    public static global::Pulumi.AzureNative.CodeSigning.CodeSigningAccountArgs WithAccountName(this global::Pulumi.AzureNative.CodeSigning.CodeSigningAccountArgs @selfRef, global::System.String accountName)
    {
        @selfRef.AccountName = accountName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CodeSigning.CodeSigningAccountArgs WithLocation(this global::Pulumi.AzureNative.CodeSigning.CodeSigningAccountArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CodeSigning.CodeSigningAccountArgs WithResourceGroupName(this global::Pulumi.AzureNative.CodeSigning.CodeSigningAccountArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CodeSigning.CodeSigningAccountArgs WithSku(this global::Pulumi.AzureNative.CodeSigning.CodeSigningAccountArgs @selfRef, global::Pulumi.AzureNative.CodeSigning.Inputs.AccountSkuArgs sku)
    {
        @selfRef.Sku = sku;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CodeSigning.CodeSigningAccountArgs WithSku(this global::Pulumi.AzureNative.CodeSigning.CodeSigningAccountArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.CodeSigning.Inputs.AccountSkuArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.CodeSigning.Inputs.AccountSkuArgs();
        @configure(@item);
        @selfRef.Sku = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CodeSigning.CodeSigningAccountArgs WithTags(this global::Pulumi.AzureNative.CodeSigning.CodeSigningAccountArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CodeSigning.CodeSigningAccountArgs WithTags(this global::Pulumi.AzureNative.CodeSigning.CodeSigningAccountArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CodeSigning.CodeSigningAccountArgs WithTags(this global::Pulumi.AzureNative.CodeSigning.CodeSigningAccountArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
