// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Maps;

public static partial class PrivateAtlaseArgsExtensions
{
    public static global::Pulumi.AzureNative.Maps.PrivateAtlaseArgs WithAccountName(this global::Pulumi.AzureNative.Maps.PrivateAtlaseArgs @selfRef, global::System.String accountName)
    {
        @selfRef.AccountName = accountName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Maps.PrivateAtlaseArgs WithLocation(this global::Pulumi.AzureNative.Maps.PrivateAtlaseArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Maps.PrivateAtlaseArgs WithPrivateAtlasName(this global::Pulumi.AzureNative.Maps.PrivateAtlaseArgs @selfRef, global::System.String privateAtlasName)
    {
        @selfRef.PrivateAtlasName = privateAtlasName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Maps.PrivateAtlaseArgs WithResourceGroupName(this global::Pulumi.AzureNative.Maps.PrivateAtlaseArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Maps.PrivateAtlaseArgs WithTags(this global::Pulumi.AzureNative.Maps.PrivateAtlaseArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Maps.PrivateAtlaseArgs WithTags(this global::Pulumi.AzureNative.Maps.PrivateAtlaseArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Maps.PrivateAtlaseArgs WithTags(this global::Pulumi.AzureNative.Maps.PrivateAtlaseArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
