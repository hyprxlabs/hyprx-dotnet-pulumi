// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Chaos;

public static partial class PrivateAccessArgsExtensions
{
    public static global::Pulumi.AzureNative.Chaos.PrivateAccessArgs WithLocation(this global::Pulumi.AzureNative.Chaos.PrivateAccessArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Chaos.PrivateAccessArgs WithPrivateAccessName(this global::Pulumi.AzureNative.Chaos.PrivateAccessArgs @selfRef, global::System.String privateAccessName)
    {
        @selfRef.PrivateAccessName = privateAccessName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Chaos.PrivateAccessArgs WithPublicNetworkAccess(this global::Pulumi.AzureNative.Chaos.PrivateAccessArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Chaos.PublicNetworkAccessOption> publicNetworkAccess)
    {
        @selfRef.PublicNetworkAccess = publicNetworkAccess;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Chaos.PrivateAccessArgs WithResourceGroupName(this global::Pulumi.AzureNative.Chaos.PrivateAccessArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Chaos.PrivateAccessArgs WithTags(this global::Pulumi.AzureNative.Chaos.PrivateAccessArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Chaos.PrivateAccessArgs WithTags(this global::Pulumi.AzureNative.Chaos.PrivateAccessArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Chaos.PrivateAccessArgs WithTags(this global::Pulumi.AzureNative.Chaos.PrivateAccessArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
