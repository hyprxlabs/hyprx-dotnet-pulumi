// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.ServiceFabric;

public static partial class ApplicationTypeArgsExtensions
{
    public static global::Pulumi.AzureNative.ServiceFabric.ApplicationTypeArgs WithApplicationTypeName(this global::Pulumi.AzureNative.ServiceFabric.ApplicationTypeArgs @selfRef, global::System.String applicationTypeName)
    {
        @selfRef.ApplicationTypeName = applicationTypeName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.ApplicationTypeArgs WithClusterName(this global::Pulumi.AzureNative.ServiceFabric.ApplicationTypeArgs @selfRef, global::System.String clusterName)
    {
        @selfRef.ClusterName = clusterName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.ApplicationTypeArgs WithLocation(this global::Pulumi.AzureNative.ServiceFabric.ApplicationTypeArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.ApplicationTypeArgs WithResourceGroupName(this global::Pulumi.AzureNative.ServiceFabric.ApplicationTypeArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.ApplicationTypeArgs WithTags(this global::Pulumi.AzureNative.ServiceFabric.ApplicationTypeArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.ApplicationTypeArgs WithTags(this global::Pulumi.AzureNative.ServiceFabric.ApplicationTypeArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.ApplicationTypeArgs WithTags(this global::Pulumi.AzureNative.ServiceFabric.ApplicationTypeArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
