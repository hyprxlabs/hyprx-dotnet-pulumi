// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.CognitiveServices;

public static partial class AccountArgsExtensions
{
    public static global::Pulumi.AzureNative.CognitiveServices.AccountArgs WithAccountName(this global::Pulumi.AzureNative.CognitiveServices.AccountArgs @selfRef, global::System.String accountName)
    {
        @selfRef.AccountName = accountName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CognitiveServices.AccountArgs WithIdentity(this global::Pulumi.AzureNative.CognitiveServices.AccountArgs @selfRef, global::Pulumi.AzureNative.CognitiveServices.Inputs.IdentityArgs identity)
    {
        @selfRef.Identity = identity;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CognitiveServices.AccountArgs WithIdentity(this global::Pulumi.AzureNative.CognitiveServices.AccountArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.CognitiveServices.Inputs.IdentityArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.CognitiveServices.Inputs.IdentityArgs();
        @configure(@item);
        @selfRef.Identity = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CognitiveServices.AccountArgs WithKind(this global::Pulumi.AzureNative.CognitiveServices.AccountArgs @selfRef, global::System.String kind)
    {
        @selfRef.Kind = kind;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CognitiveServices.AccountArgs WithLocation(this global::Pulumi.AzureNative.CognitiveServices.AccountArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CognitiveServices.AccountArgs WithProperties(this global::Pulumi.AzureNative.CognitiveServices.AccountArgs @selfRef, global::Pulumi.AzureNative.CognitiveServices.Inputs.AccountPropertiesArgs properties)
    {
        @selfRef.Properties = properties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CognitiveServices.AccountArgs WithProperties(this global::Pulumi.AzureNative.CognitiveServices.AccountArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.CognitiveServices.Inputs.AccountPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.CognitiveServices.Inputs.AccountPropertiesArgs();
        @configure(@item);
        @selfRef.Properties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CognitiveServices.AccountArgs WithResourceGroupName(this global::Pulumi.AzureNative.CognitiveServices.AccountArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CognitiveServices.AccountArgs WithSku(this global::Pulumi.AzureNative.CognitiveServices.AccountArgs @selfRef, global::Pulumi.AzureNative.CognitiveServices.Inputs.SkuArgs sku)
    {
        @selfRef.Sku = sku;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CognitiveServices.AccountArgs WithSku(this global::Pulumi.AzureNative.CognitiveServices.AccountArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.CognitiveServices.Inputs.SkuArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.CognitiveServices.Inputs.SkuArgs();
        @configure(@item);
        @selfRef.Sku = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CognitiveServices.AccountArgs WithTags(this global::Pulumi.AzureNative.CognitiveServices.AccountArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CognitiveServices.AccountArgs WithTags(this global::Pulumi.AzureNative.CognitiveServices.AccountArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CognitiveServices.AccountArgs WithTags(this global::Pulumi.AzureNative.CognitiveServices.AccountArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
