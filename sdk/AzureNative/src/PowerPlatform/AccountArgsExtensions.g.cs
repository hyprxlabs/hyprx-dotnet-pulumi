// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.PowerPlatform;

public static partial class AccountArgsExtensions
{
    public static global::Pulumi.AzureNative.PowerPlatform.AccountArgs WithAccountName(this global::Pulumi.AzureNative.PowerPlatform.AccountArgs @selfRef, global::System.String accountName)
    {
        @selfRef.AccountName = accountName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.PowerPlatform.AccountArgs WithDescription(this global::Pulumi.AzureNative.PowerPlatform.AccountArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.PowerPlatform.AccountArgs WithLocation(this global::Pulumi.AzureNative.PowerPlatform.AccountArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.PowerPlatform.AccountArgs WithResourceGroupName(this global::Pulumi.AzureNative.PowerPlatform.AccountArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.PowerPlatform.AccountArgs WithTags(this global::Pulumi.AzureNative.PowerPlatform.AccountArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.PowerPlatform.AccountArgs WithTags(this global::Pulumi.AzureNative.PowerPlatform.AccountArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.PowerPlatform.AccountArgs WithTags(this global::Pulumi.AzureNative.PowerPlatform.AccountArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
