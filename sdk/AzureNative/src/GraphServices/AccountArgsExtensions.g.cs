// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.GraphServices;

public static partial class AccountArgsExtensions
{
    public static global::Pulumi.AzureNative.GraphServices.AccountArgs WithLocation(this global::Pulumi.AzureNative.GraphServices.AccountArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.GraphServices.AccountArgs WithProperties(this global::Pulumi.AzureNative.GraphServices.AccountArgs @selfRef, global::Pulumi.AzureNative.GraphServices.Inputs.AccountResourcePropertiesArgs properties)
    {
        @selfRef.Properties = properties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.GraphServices.AccountArgs WithProperties(this global::Pulumi.AzureNative.GraphServices.AccountArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.GraphServices.Inputs.AccountResourcePropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.GraphServices.Inputs.AccountResourcePropertiesArgs();
        @configure(@item);
        @selfRef.Properties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.GraphServices.AccountArgs WithResourceGroupName(this global::Pulumi.AzureNative.GraphServices.AccountArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.GraphServices.AccountArgs WithResourceName(this global::Pulumi.AzureNative.GraphServices.AccountArgs @selfRef, global::System.String resourceName)
    {
        @selfRef.ResourceName = resourceName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.GraphServices.AccountArgs WithTags(this global::Pulumi.AzureNative.GraphServices.AccountArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.GraphServices.AccountArgs WithTags(this global::Pulumi.AzureNative.GraphServices.AccountArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.GraphServices.AccountArgs WithTags(this global::Pulumi.AzureNative.GraphServices.AccountArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
