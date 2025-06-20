// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.NetworkFunction;

public static partial class AzureTrafficCollectorArgsExtensions
{
    public static global::Pulumi.AzureNative.NetworkFunction.AzureTrafficCollectorArgs WithAzureTrafficCollectorName(this global::Pulumi.AzureNative.NetworkFunction.AzureTrafficCollectorArgs @selfRef, global::System.String azureTrafficCollectorName)
    {
        @selfRef.AzureTrafficCollectorName = azureTrafficCollectorName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetworkFunction.AzureTrafficCollectorArgs WithLocation(this global::Pulumi.AzureNative.NetworkFunction.AzureTrafficCollectorArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetworkFunction.AzureTrafficCollectorArgs WithResourceGroupName(this global::Pulumi.AzureNative.NetworkFunction.AzureTrafficCollectorArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetworkFunction.AzureTrafficCollectorArgs WithTags(this global::Pulumi.AzureNative.NetworkFunction.AzureTrafficCollectorArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetworkFunction.AzureTrafficCollectorArgs WithTags(this global::Pulumi.AzureNative.NetworkFunction.AzureTrafficCollectorArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetworkFunction.AzureTrafficCollectorArgs WithTags(this global::Pulumi.AzureNative.NetworkFunction.AzureTrafficCollectorArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
