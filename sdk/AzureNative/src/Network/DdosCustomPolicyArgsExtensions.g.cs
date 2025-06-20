// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Network;

public static partial class DdosCustomPolicyArgsExtensions
{
    public static global::Pulumi.AzureNative.Network.DdosCustomPolicyArgs WithDdosCustomPolicyName(this global::Pulumi.AzureNative.Network.DdosCustomPolicyArgs @selfRef, global::System.String ddosCustomPolicyName)
    {
        @selfRef.DdosCustomPolicyName = ddosCustomPolicyName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.DdosCustomPolicyArgs WithId(this global::Pulumi.AzureNative.Network.DdosCustomPolicyArgs @selfRef, global::System.String id)
    {
        @selfRef.Id = id;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.DdosCustomPolicyArgs WithLocation(this global::Pulumi.AzureNative.Network.DdosCustomPolicyArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.DdosCustomPolicyArgs WithResourceGroupName(this global::Pulumi.AzureNative.Network.DdosCustomPolicyArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.DdosCustomPolicyArgs WithTags(this global::Pulumi.AzureNative.Network.DdosCustomPolicyArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.DdosCustomPolicyArgs WithTags(this global::Pulumi.AzureNative.Network.DdosCustomPolicyArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.DdosCustomPolicyArgs WithTags(this global::Pulumi.AzureNative.Network.DdosCustomPolicyArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
